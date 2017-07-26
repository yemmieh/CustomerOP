using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerOP.Models;

namespace CustomerOP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            //var bb = dd.Customers.Where(Id.).e;
            return View();
        }
        [HttpGet]
        public ActionResult Customers()
        {
            yemiatworkdbEntities dd = new yemiatworkdbEntities();
            //var bb = dd.Customers.Where(Id.).e;
            return View(dd.Customers.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer cust)
        {
            if (ModelState.IsValid)
            {
                yemiatworkdbEntities dd = new yemiatworkdbEntities();
                //var bb = dd.Customers.Where(Id.).e;
                dd.Customers.Add(cust);
                dd.SaveChanges();
            }
           
            return RedirectToAction("Customers");
        }
        public ActionResult Details(int id)
        {
            yemiatworkdbEntities dd = new yemiatworkdbEntities();
            Customer cust = new Customer();
            cust = dd.Customers.Where(r => id.Equals(id)).First();
            dd.Customers.Remove(cust);


            return View(cust);
        }
        public ActionResult Delete(int id)
        {
            yemiatworkdbEntities dd = new yemiatworkdbEntities();
            Customer cust = new Customer();
            cust = dd.Customers.Where(r => id.Equals(id)).First();
            dd.Customers.Remove(cust);
            dd.SaveChanges();


            return RedirectToAction("Customers");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}