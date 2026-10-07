using Assignment1.Models;
using Assignment1.Repositories;
using Assignment1.Service;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class EquipmentRequestController : Controller
    {
        public IActionResult RequestForm() // EquipmentRequest/RequestForm
        {
            return View();
        }

        [HttpPost]
        public IActionResult RequestForm(EquipmentRequest equipmentRequest)
        {
            if (ModelState.IsValid)
            {
                EquipmentService.EquipmentRequest.AddRequest(equipmentRequest);
                return RedirectToAction("Confirmation");
            }
            return View(equipmentRequest);
        }
        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult Admin()
        {
            var allRequests = EquipmentService.EquipmentRequest.GetAllRequests();
            return View(allRequests);
        }
    }
}
