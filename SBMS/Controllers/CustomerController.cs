using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using SBMS.BLL.BLL;
using SBMS.Models;
using SBMS.Models.Models;

namespace SBMS.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager _customerManager = new CustomerManager();
        [HttpGet]
        public ActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Add(CustomerVM customerVm)
        {
            var customer = Mapper.Map<Customer>(customerVm);
            _customerManager.Add(customer);
            return RedirectToAction("Show");
        }

        public ActionResult Show()
        {
            CustomerVM customerVm = new CustomerVM();
            customerVm.Customers = _customerManager.GetAll();
            return View(customerVm);

        }

        public ActionResult Search()
        {
             CustomerVM customerVM = new CustomerVM();
             customerVM.Customers = _customerManager.GetAll();
             
            return View(customerVM);
        }

        public ActionResult Delete(CustomerVM customerVm)
        {
            var customer = Mapper.Map<Customer>(customerVm);
            _customerManager.Delete(customer);
            return RedirectToAction("Show");
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var customer = _customerManager.GetById(Id);
            var aCustomer = Mapper.Map<CustomerVM>(customer);
            return View(aCustomer);
        }

        [HttpPost]
        public ActionResult Edit(CustomerVM customerVm)
        {
            var customer = Mapper.Map<Customer>(customerVm);
            _customerManager.Update(customer);
            return RedirectToAction("Show");

        }
    }
}