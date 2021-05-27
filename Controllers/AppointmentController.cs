using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceManage.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //string todaydate = DateTime.Now.ToLongDateString();
            //return Ok(todaydate);
        }

        public IActionResult Detail(int id)
        {
            return Ok("You have entered id = {id}" + id);
           
        }
    }
}
