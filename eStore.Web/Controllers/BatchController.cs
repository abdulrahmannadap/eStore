using eStore.Application.common.Interfaces;
using eStore.Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eStore.Web.Controllers
{
    public class BatchController : Controller
    {
        private void EnableBatchDropdown()
        {
            ViewBag.SelectListItem = _unitOfWork.ProductRepositoryUOW.GetAll().Select(v => new SelectListItem { Value = v.Id.ToString(), Text = v.Name });

            return;
        }
        private readonly IUnitOfWork _unitOfWork;
        public BatchController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var batches = _unitOfWork.BatchRepositoryUOW.GetAll(includeProperites: "Product");
            return View(batches);
        }


        public IActionResult Create()
        {
            //List<Villa> villas = _db.Villas.ToList();
            IEnumerable<Product> products = _unitOfWork.ProductRepositoryUOW.GetAll();
            IEnumerable<SelectListItem> selectListItem = products.Select(v => new SelectListItem
            {
                Text = v.Name,
                Value = v.Id.ToString()
            });
            ViewBag.SelectListItem = selectListItem;
            return View("Create");
        }
        [HttpPost]
        public IActionResult Create(Batch batch)
        {
            bool isBatch = _unitOfWork.BatchRepositoryUOW.GetAll().Any(b => b.BatchNumber == batch.BatchNumber);
            if (ModelState.IsValid && !isBatch)
            {


                _unitOfWork.BatchRepositoryUOW.Add(batch);
                _unitOfWork.Save();
                TempData["SuccessMessage"] = "batch added successfully!";
                return RedirectToAction(nameof(Index));

            }

            EnableBatchDropdown();
            TempData["ErrorMessage"] = "This batch already exists!";
            return View(batch);

        }

        public IActionResult Edit(int id)
        {
            var batch = _unitOfWork.BatchRepositoryUOW.GetAll().FirstOrDefault(b => b.BatchNumber == id);


            if (batch is null)
            {
                return RedirectToAction("Error", "Home");
            }
            EnableBatchDropdown();
            return View(batch);
        }
        [HttpPost]
        public IActionResult Edit(Batch batch)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.BatchRepositoryUOW.Update(batch);
                _unitOfWork.Save();
                TempData["SuccessMessage"] = "Batch details updated successfully!";
                return RedirectToAction(nameof(Index));
            }
            return View(batch);
        }


        public IActionResult Delete(int batchNumber)
        {
            var batch = _unitOfWork.BatchRepositoryUOW.Get(b => b.BatchNumber == batchNumber);
            if (batch is null)
                return NotFound();



            EnableBatchDropdown();
            return View(batch);
        }
        [HttpPost]
        public IActionResult DeleteConfirm(int batchNumber)
        {
            //var text = Convert.ToInt16(formValues["Villa_Number"]);
            var batchToBeDeleted = _unitOfWork.BatchRepositoryUOW.Get(b => b.BatchNumber == batchNumber);
            _unitOfWork.BatchRepositoryUOW.Remove(batchToBeDeleted);
            _unitOfWork.Save();
            TempData["SuccessMessage"] = "Batch deleted successfully!";

            return RedirectToAction(nameof(Index));
        }
    }

}

