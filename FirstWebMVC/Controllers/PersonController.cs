using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Data;
using FirstWebMVC.Models;
using System.Linq;

public class PersonController : Controller
{
    private readonly ApplicationDbContext _context;

    public PersonController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Hiển thị danh sách Person
    public IActionResult Index()
    {
        var persons = _context.Persons.ToList();
        return View(persons);
    }

    // Form tạo mới Person
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Person person)
    {
        if (ModelState.IsValid)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(person);
    }

    // Sửa Person
    public IActionResult Edit(int id)
    {
        var person = _context.Persons.Find(id);
        if (person == null) return NotFound();
        return View(person);
    }

    [HttpPost]
    public IActionResult Edit(Person person)
    {
        if (ModelState.IsValid)
        {
            _context.Persons.Update(person);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(person);
    }

    // Xoá Person
    public IActionResult Delete(int id)
    {
        var person = _context.Persons.Find(id);
        if (person == null) return NotFound();
        return View(person);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        var person = _context.Persons.Find(id);
        if (person != null)
        {
            _context.Persons.Remove(person);
            _context.SaveChanges();
        }
        return RedirectToAction("Index");
    }
}
