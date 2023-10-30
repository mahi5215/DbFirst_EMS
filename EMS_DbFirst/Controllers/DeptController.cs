namespace EMS_DbFirst.Controllers;
using Microsoft.AspNetCore.Mvc;
public class DeptController:Controller
{
public IActionResult List()
{
    return View();
}
}