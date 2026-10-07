using Assignment1.Models;
using Assignment1.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class EquipmentRequestController : Controller
    {
        private static EquipmentRequestRepository _equipmentRequestRepository = new EquipmentRequestRepository();

        public IActionResult RequestForm() // EquipmentRequest/RequestForm
        {
            return View();
        }

        [HttpPost]
        public IActionResult RequestForm(EquipmentRequest equipmentRequest)
        {
            if (ModelState.IsValid)
            {
                _equipmentRequestRepository.AddRequest(equipmentRequest);
                return RedirectToAction("Confirmation");
            }
            return View(equipmentRequest);
        }
        public IActionResult Confirmation()
        {
            return View();
        }
    }
}
