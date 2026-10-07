using Assignment1.Service;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class EquipmentController : Controller
    {

        public IActionResult AllEquipment()
        {
            var allEquipment = EquipmentService.Equipment.GetAllEquipment();
            return View(allEquipment);
        }
        public IActionResult AvailableEquipment()
        {
            //TODO: Create view
            return View();
        }
    }
}
