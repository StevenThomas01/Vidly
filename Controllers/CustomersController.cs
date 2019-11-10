using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        [HttpGet]
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(x => x.MembershipType).ToList();

            return View(customers);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var customerDetails = _context.Customers.SingleOrDefault(x => x.Id == id);

            if (customerDetails == null)
                return HttpNotFound();

            return View(customerDetails);
        }
    }
}