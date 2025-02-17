using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;

namespace FirstWebMVC.Controllers
{
    public class BMIController : Controller
    {
        // GET: Hiển thị form nhập dữ liệu
        public IActionResult Index()
        {
            return View();
        }

        // POST: Nhận dữ liệu từ form, tính toán BMI và trả về kết quả
        [HttpPost]
        public IActionResult Index(BMIModel model)
        {
            if (ModelState.IsValid) // Kiểm tra dữ liệu hợp lệ
            {
                double bmi = model.Weight / (model.Height * model.Height);

                string result;
                if (bmi < 18.5)
                    result = "Thiếu cân";
                else if (bmi < 24.9)
                    result = "Bình thường";
                else if (bmi < 29.9)
                    result = "Thừa cân";
                else
                    result = "Béo phì";

                ViewBag.BMI = bmi.ToString("0.00");
                ViewBag.Result = result;
            }

            return View();
        }
    }
}
