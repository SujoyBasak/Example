using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpenseManagement.Models;

namespace ExpenseManagement.Models
{
    public class ExpenseViewModel
    {
        public EMS_DB Expense { get; set; }


        public IEnumerable<SelectListItem> ExpenseTypeList
        {
            get
            {
                return new List<SelectListItem>()
                     {
                       new SelectListItem { Text = "Food Expense", Value = "Food Expense" },
                        new SelectListItem { Text = "Health Expense", Value = "Health Expense" },
                        new SelectListItem { Text = "Travel Expense", Value = "Travel Expense" },
                        new SelectListItem { Text = "Entertainment Expense", Value = "Entertainment Expense" },
                     };
            }
            set
            {

            }

        }
    }
}