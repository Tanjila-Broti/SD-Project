using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cart.Models;

namespace cart.Controllers
{
    public class CustomerController : Controller
    {



      [HttpGet]
        

        public ActionResult AddOrEdit(int id=0)
        {
            Customer customerModel = new Customer();
            return View(customerModel);
        }

       [HttpPost]
       public ActionResult AddOrEdit (Customer customerModel)
        {
            using(DBModel dbModel = new DBModel())
            {
                if(dbModel.Customer.Any(x => x.Name == customerModel.Name))
                {
                    ViewBag.DuplicateMessage = "Customer Name already exists!!";
                    retrun View("AddOrEdit", customerModel());
                }
                dbModel.Customer.Add(customerModel);
                dbModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful!!";
            return View("AddOrEdit", new Customer());
        }


        
    }
}