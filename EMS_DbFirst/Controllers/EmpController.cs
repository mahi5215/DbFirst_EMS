using Microsoft.AspNetCore.Mvc;
namespace EMS_DbFirst.Controllers;
using EMS_DbFirst.Models;
public class EmpController:Controller
{
    private readonly EmsDbContext context;
    public EmpController(EmsDbContext _context)
    {
        context=_context;
    }
public IActionResult List()
{
    return View();
}
}