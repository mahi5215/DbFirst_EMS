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
}