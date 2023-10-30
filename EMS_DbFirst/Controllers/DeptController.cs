namespace EMS_DbFirst.Controllers;
using Microsoft.AspNetCore.Mvc;
using EMS_DbFirst.Models;
public class DeptController:Controller
{
    private readonly EmsDbContext context;
    public DeptController(EmsDbContext _context)
    {
        context=_context;
    }
public IActionResult List()
{
    var data=context.Departments.ToList();
    return View(data);
}
public IActionResult Create()
{
    return View();
}
[HttpPost]
public IActionResult Create(Department department)
{
    if(ModelState.IsValid)
    {
        context.Departments.Add(department);
        context.SaveChanges();
        return RedirectToAction("List");
    }
    return View();
}
}