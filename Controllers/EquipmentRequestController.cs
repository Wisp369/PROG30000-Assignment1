using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class EquipmentRequestController : Controller
    {

        [HttpGet]
        public IActionResult RequestForm() // EquipmentRequest/RequestForm
        {
            return View();
        }
    }
}
