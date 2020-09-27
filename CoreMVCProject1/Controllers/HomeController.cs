using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVCProject1.Models;
using CoreMVCProject1.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCProject1.Controllers
{
    public class HomeController : Controller
    {
        private ICustomerRepository _customerRepository;

        public HomeController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

       // [Route("Home/MyIndex")]
        public IActionResult Index()
        {
            //return Content("Hello from Index");
            //return View();

            //return Json(new { id = 1, name = "Arun" });
            var customers = _customerRepository.GetCustomers();

            return View(customers);
        }

        public IActionResult Details(int id)
        {
            var customer = _customerRepository.GetCustomer(id);
            //return Json(customer);
            return View(customer);
        }
    }
}
