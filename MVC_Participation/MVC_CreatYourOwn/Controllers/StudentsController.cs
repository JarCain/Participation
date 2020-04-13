using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_CreatYourOwn.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Students()
        {


            return View();
        }
    }
}