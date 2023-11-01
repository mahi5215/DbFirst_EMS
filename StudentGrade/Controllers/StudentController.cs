using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentGrade.Models;

namespace StudentGrade.Controllers
{
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly SGDbContext context;

        public StudentController(SGDbContext _context)
        {
            context=_context;
        }

        public IActionResult List()
        {
            var data=context.Students.ToList();
            return View(data);
        }

        
       
        
    }
}