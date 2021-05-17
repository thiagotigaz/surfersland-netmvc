using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using SurfersLand.Models;

namespace SurfersLand.Controllers
{
    public class CustomersController : Controller
    {
        // GET
        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "John Smith"},
                new Customer {Id = 2, Name = " Mary Williams"}
            };
        }
    }
}