using System.Security.Claims;
using eStore.Application.common.Interfaces;
using eStore.Application.Utilities;
using eStore.Domain.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;

namespace eStore.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Authorize]
        public IActionResult Index(int id)
        {

            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            Order order = new Order()
            {

                OrderDetails = new OrderDetails() { Product = _unitOfWork.ProductRepositoryUOW.Get(x => x.Id == id, "TargetAudienceList"), ApplicationUser = _unitOfWork.ApplicationUserRepositoryUOW.Get(x => x.Id == userId) },


            };
            order.OrderDetails.Product.IsOrderForm = true;
            order.ProductId = order.OrderDetails.Product.Id;


            return View(order);
        }


        [HttpPost, Authorize]
        public IActionResult Index(Order order)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

            order.PublicId = Guid.NewGuid().ToString();
            order.UserId = userId;
            order.OrderDate = DateOnly.FromDateTime(DateTime.Now);
            order.Status = "Pending";

            var product = _unitOfWork.ProductRepositoryUOW.Get(x => x.Id == order.ProductId);
            product.OrderStage = StaticDetails.Products.OrderStages.OrderConfirmed;
            product.Stock -= 1;
            if (product.Stock <= 0)
                product.IsOutOfStock = true;

            _unitOfWork.OrderRepositoryUOW.Add(order);
            _unitOfWork.Save();

            return RedirectToAction("StripeCheckout", new { publicId = order.PublicId });
        }

        [Authorize]
        public IActionResult StripeCheckout(string publicId)
        {
            var order = _unitOfWork.OrderRepositoryUOW.Get(x => x.PublicId == publicId, includeProperties: "Product");
            if (order == null) return NotFound();

            // Rebuild OrderDetails
            var user = _unitOfWork.ApplicationUserRepositoryUOW.Get(x => x.Id == order.UserId);
            order.OrderDetails = new OrderDetails
            {
                Product = order.Product,
                ApplicationUser = user
            };

            var domain = $"{Request.Scheme}://{Request.Host}/";

            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
                LineItems = new List<SessionLineItemOptions>
        {
            new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    UnitAmount = (long)(order.Product.Price * 100),
                    Currency = "usd",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = order.Product.Name,
                    },
                },
                Quantity = 1,
            },
        },
                Mode = "payment",
                SuccessUrl = domain + $"Order/Success?publicId={order.PublicId}",
                CancelUrl = domain + $"Order/Cancel?publicId={order.PublicId}",
            };

            var service = new SessionService();
            Session session = service.Create(options);

            return Redirect(session.Url);
        }

        public IActionResult Success(string publicId)
        {
            var order = _unitOfWork.OrderRepositoryUOW.Get(x => x.PublicId == publicId);
            if (order != null)
            {
                order.Status = "Paid";
                _unitOfWork.Save();
            }

            ViewBag.PublicId = publicId;
            return View();
        }

        public IActionResult Cancel(string publicId)
        {
            var order = _unitOfWork.OrderRepositoryUOW.Get(x => x.PublicId == publicId);
            if (order != null)
            {
                order.Status = "Canceled";
                _unitOfWork.Save();
            }

            ViewBag.PublicId = publicId;
            return View();
        }



    }
}

// database ma avaliable ka property lage ga
