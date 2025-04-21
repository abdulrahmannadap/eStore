using System.Diagnostics;
using System.Security.Claims;
using eStore.Application.common.Interfaces;
using eStore.Application.Utilities;
using eStore.Domain.Entity;
using eStore.Web.Models;
using eStore.Web.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eStore.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index(string categoryName = null)
        {
            var comparisonDate = DateOnly.FromDateTime(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(-7).Day));

            IEnumerable<Product> products = new List<Product>();
            if (categoryName is not null)
            {
                products = _unitOfWork.ProductRepositoryUOW.GetAll(x => x.Category == categoryName && x.Stock > 0, "TargetAudienceList");
            }

            if (categoryName is null)
                products = _unitOfWork.ProductRepositoryUOW.GetAll(x => x.Stock > 0, includeProperites: "TargetAudienceList");

            string imageFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "ImageSilder");
            var imageFiles = Directory.GetFiles(imageFolderPath)
                                      .Select(Path.GetFileName)
                                      .ToList();

            ViewBag.ProductImages = imageFiles;


            HomeVM homeVM = new HomeVM()
            {
                ProductList = products,
                FromDate = comparisonDate,
                Rating = StaticDetails.Filter.FilterProduct_Rating__None
            };
            return View(homeVM);
        }
        [HttpPost]
        public IActionResult Index(HomeVM homeVM)
        {
            var filterList = new List<Product>();

            if (homeVM.FromDate == null)
            {
                filterList = _unitOfWork.ProductRepositoryUOW
                    .GetAll(x => x.Rating >= homeVM.Rating, "TargetAudienceList")
                    .ToList();

                string imageFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "ImageSilder");
                var imageFiles = Directory.GetFiles(imageFolderPath)
                                          .Select(Path.GetFileName)
                                          .ToList();

                ViewBag.ProductImages = imageFiles;
            }
            else
            {
                filterList = _unitOfWork.ProductRepositoryUOW
                    .GetAll(x => x.Rating >= homeVM.Rating && x.PublishDate >= homeVM.FromDate, "TargetAudienceList")
                    .ToList();

                string imageFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "ImageSilder");
                var imageFiles = Directory.GetFiles(imageFolderPath)
                                          .Select(Path.GetFileName)
                                          .ToList();

                ViewBag.ProductImages = imageFiles;
            }

            var filteredHomeVm = new HomeVM
            {
                ProductList = filterList,
                FromDate = homeVM.FromDate,
                Rating = homeVM.Rating
            };

            return View(filteredHomeVm);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult IncrementRating(int productId)
        {
            var product = _unitOfWork.ProductRepositoryUOW.Get(x => x.Id == productId);


            if (product.Rating < 5)
            {

                product.Rating += 1;
            }
            _unitOfWork.Save();
            return StatusCode(StatusCodes.Status200OK);
        }


        [Authorize]
        public IActionResult MyOrderDetail()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var orders = _unitOfWork.OrderRepositoryUOW.GetAll(
                x => x.UserId == userId,
                includeProperites: "Product"
            ).OrderByDescending(x => x.OrderDate).ToList();

            return View(orders);
        }





    }
}
