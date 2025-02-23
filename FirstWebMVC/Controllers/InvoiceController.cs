using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;

namespace FirstWebMVC.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int Quantity, double UnitPrice)
        {
            double TotalPrice = Quantity * UnitPrice; // Tính tổng tiền

            ViewBag.TotalPrice = TotalPrice; // Trả kết quả về View

            return View();
        }
    }
}
