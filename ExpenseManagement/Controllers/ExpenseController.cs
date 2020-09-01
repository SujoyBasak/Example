using ExpenseManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpenseManagement.Controllers
{
    public class ExpenseController : Controller
    {
        // GET: Expense
        ExpenseContext con = new ExpenseContext();
        [HttpGet]
        public ActionResult Index()
        {
            
            return View(con.EMS_DB.ToList());
            
        }
        public ActionResult AddExpense()
        {
            ViewBag.msg = "Expense added Successfully";
            var x = new ExpenseViewModel();
            return View(x);
        }
        [HttpPost]
        public ActionResult AddExpense(EMS_DB expense)
        {
            con.EMS_DB.Add(expense);
            con.SaveChanges();
            return View("AddExpense");
        }
    }
}