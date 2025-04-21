using eStore.Application.common.Interfaces;
using eStore.Application.Utilities;
using eStore.Domain.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eStore.Web.Controllers
{
    [Authorize(Roles = StaticDetails.ApplicationUserRoles.Role_Seller)]
    public class TargetAudienceController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        public TargetAudienceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        private void EnableProductsDropdown()
        {
            IEnumerable<Product> products = _unitOfWork.ProductRepositoryUOW.GetAll();
            IEnumerable<SelectListItem> selectListItem = products.Select(v => new SelectListItem
            {
                Text = v.Name,
                Value = v.Id.ToString()
            });
            ViewBag.SelectListItems = selectListItem;
            return;
        }
        public IActionResult Index()
        {


            var targetAudiences = _unitOfWork.TargetAudienceRepositoryUOW.GetAll(includeProperites: "Product");
            return View(targetAudiences);

        }


        public IActionResult Create()
        {
            //List<Villa> villas = _db.Villas.ToList();
            EnableProductsDropdown();
            return View("Create");
        }
        [HttpPost]
        public IActionResult Create(TargetAudience targetAudience)
        {
            if (ModelState.IsValid)
            {

                _unitOfWork.TargetAudienceRepositoryUOW.Add(targetAudience);
                _unitOfWork.Save();
                TempData["SuccessMessage"] = " Audience targeted successfully!";
                return RedirectToAction(nameof(Index));

            }

            EnableProductsDropdown();

            TempData["ErrorMessage"] = "Audience could not be targeted!";
            return View(targetAudience);

        }

        public IActionResult Edit(int id)
        {
            var targetAudience = _unitOfWork.TargetAudienceRepositoryUOW.Get(ta => ta.Id == id);


            if (targetAudience is null)

                return RedirectToAction("Error", "Home");

            EnableProductsDropdown();
            return View(targetAudience);
        }
        [HttpPost]
        public IActionResult Edit(TargetAudience targetAudience)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.TargetAudienceRepositoryUOW.Update(targetAudience);
                _unitOfWork.Save();
                TempData["SuccessMessage"] = "targeted audience updated successfully!";
                return RedirectToAction(nameof(Index));
            }
            EnableProductsDropdown();
            return View(targetAudience);
        }


        public IActionResult Delete(int id)
        {

            var targetAudience = _unitOfWork.TargetAudienceRepositoryUOW.Get(ta => ta.Id == id);
            if (targetAudience is null)

                return NotFound();



            EnableProductsDropdown();

            return View(targetAudience);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id, TargetAudience targetAudience)
        {
            var targetAudienceFromDb = _unitOfWork.TargetAudienceRepositoryUOW.Get(ta => ta.Id == id);
            _unitOfWork.TargetAudienceRepositoryUOW.Remove(targetAudienceFromDb);
            _unitOfWork.Save();
            TempData["SuccessMessage"] = "Targeted audience deleted successfully!";

            return RedirectToAction(nameof(Index));
        }


    }
}
