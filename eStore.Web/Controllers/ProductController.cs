using eStore.Application.common.Interfaces;
using eStore.Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace eStore.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;

        }
        public IActionResult Index()
        {

            var products = _unitOfWork.ProductRepositoryUOW.GetAll();

            return View(products);
        }


        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (product.ShortDescription == product.Name)
            {
                ModelState.AddModelError("Name", "Name and short description cannot be same.");
            }
            if (ModelState.IsValid)
            {
                if (product.Image is not null)
                {
                    string webRootPath = _webHostEnvironment.WebRootPath;
                    string imagePath = Path.Combine(webRootPath, @"Images\ProductImages");
                    string newFileName = "MyImage" + product.Image.FileName.Split('.')[0] + "_" + Guid.NewGuid().ToString().Substring(0, 5) + Path.GetExtension(product.Image.FileName);
                    string finalPath = Path.Combine(imagePath, newFileName);
                    using (FileStream fileStream = new FileStream(finalPath, FileMode.Create))
                    {
                        product.Image.CopyTo(fileStream);
                        product.ImageURL = Path.Combine(@"\Images\ProductImages", newFileName);
                    }
                }
                else
                    product.ImageURL = "www.dummy.com";
                product.PublishDate = DateOnly.FromDateTime(dateTime: DateTime.Now);

                _unitOfWork.ProductRepositoryUOW.Add(product);
                _unitOfWork.Save();
                TempData["SuccessMessage"] = "Product added successfully!";
                return RedirectToAction(nameof(Index));

            }

            return View(product);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {

                var product = _unitOfWork.ProductRepositoryUOW.Get(x => x.Id == id);
                return View(product);
            }
            catch (Exception)
            {

            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.Image is not null)
                {
                    string webRootPath = _webHostEnvironment.WebRootPath;
                    string imagePath = Path.Combine(webRootPath, @"Images\ProductImages");
                    string newFileName = "MyImage" + "_" + Guid.NewGuid().ToString().Substring(0, 5) + Path.GetExtension(product.Image.FileName);
                    string finalPath = Path.Combine(imagePath, newFileName);
                    if (!string.IsNullOrEmpty(product.ImageURL))
                    {
                        string oldImagePath = Path.Combine(webRootPath, product.ImageURL.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    using (FileStream fileStream = new FileStream(finalPath, FileMode.Create))
                    {
                        product.Image.CopyTo(fileStream);
                        product.ImageURL = Path.Combine(@"\Images\ProductImages", newFileName);
                    }

                }
                _unitOfWork.ProductRepositoryUOW.Update(product);
                _unitOfWork.Save();
                TempData["SuccessMessage"] = "Product details updated successfully!";
                return RedirectToAction(nameof(Index));
            }

            return View(product);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = _unitOfWork.ProductRepositoryUOW.Get(x => x.Id == id);
            return View(product);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(Product incomingProduct)
        {
            var product = _unitOfWork.ProductRepositoryUOW.Get(x => x.Id == incomingProduct.Id);
            if (!string.IsNullOrEmpty(product.ImageURL))
            {
                string webRootPath = _webHostEnvironment.WebRootPath;
                string oldImagePath = Path.Combine(webRootPath, product.ImageURL.TrimStart('\\'));

                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            _unitOfWork.ProductRepositoryUOW.Remove(product);
            _unitOfWork.Save();
            TempData["SuccessMessage"] = "Product deleted successfully!";

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Purches()
        {
            var orders = _unitOfWork.OrderRepositoryUOW.GetAll(includeProperites: "Product").ToList();
            return View(orders);
        }


    }
}
