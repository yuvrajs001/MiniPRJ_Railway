using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeChallange9_mvc.Models;



namespace CodeChallange9_mvc.Controllers
{
    public class CodeController : Controller
    {
        private NorthwindEntities1 db = new NorthwindEntities1();
        // GET: Code
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult CustomerOfGerman()
        {
            var Germanlist = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(Germanlist);
        }

        // GET: Customer details with orderId == 10248
        public ActionResult CustomerOrder()
        {
            var OrderId = db.Customers.Where(c => c.Orders.Any(o => o.OrderID == 10248)).FirstOrDefault();

            return View(OrderId);
        }

    }
}