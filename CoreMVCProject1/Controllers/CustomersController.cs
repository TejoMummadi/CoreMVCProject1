﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVCProject1.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVCProject1.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerRepository _repository;

        public CustomersController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var customers = _repository.GetCustomers();
            return View(customers);
        }
    }
}