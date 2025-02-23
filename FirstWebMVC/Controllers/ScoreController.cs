using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;

namespace FirstWebMVC.Controllers
{
    public class ScoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ScoreModel model)
        {
            if (ModelState.IsValid)
            {
                // Tính điểm theo công thức: 0.6A + 0.3B + 0.1C
                model.FinalScore = 0.6 * model.A + 0.3 * model.B + 0.1 * model.C;

                // Trả kết quả về View bằng ViewBag
                ViewBag.FinalScore = model.FinalScore;
            }

            return View(model);
        }
    }
}
