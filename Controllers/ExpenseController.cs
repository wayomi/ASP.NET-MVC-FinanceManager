using FinanceManage.Data;
using FinanceManage.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceManage.Controllers
{
    public class ExpenseController : Controller
    {
            private readonly ApplicataionDbContext _db;

            public ExpenseController(ApplicataionDbContext db)
            {
                _db = db;
            }

            public IActionResult Index()
            {
                IEnumerable<Expense> objList = _db.Expenses;
                return View(objList);
            
            }

            //Get Create
            public IActionResult Create()
            {
                return View();
            }

            //Post Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Create(Expense obj)
            {
            if (ModelState.IsValid)
            {

                _db.Expenses.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
            }

        
        // GET Delete
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Expenses.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        //Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Expenses.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Expenses.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }

    }
}
