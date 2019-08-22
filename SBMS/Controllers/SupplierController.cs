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
    public class SupplierController : Controller
    {
        SupplierManager _supplierManager= new SupplierManager();
        [HttpGet]
        public ActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Add(SupplierVM supplierVm)
        {
            var supplier = Mapper.Map<Supplier>(supplierVm);
            _supplierManager.Add(supplier);
            return RedirectToAction("Show");
        }

        public ActionResult Show()
        {
            SupplierVM supplierVm = new SupplierVM();
            supplierVm.Suppliers = _supplierManager.GetAll();
            return View(supplierVm);

        }

        public ActionResult Search()
        {
            SupplierVM supplierVM = new SupplierVM();
            supplierVM.Suppliers = _supplierManager.GetAll();

            return View(supplierVM);
        }
        [HttpPost]
        public ActionResult Search(SupplierVM supplierVm)
        {
            var supplier = _supplierManager.GetAll();
            if (supplierVm.Code != null)
            {
                supplier = supplier.Where(c => c.Code.ToLower().Contains(supplierVm.Code.ToLower())).ToList();
            }

            supplierVm.Suppliers = supplier;

            return View(supplierVm);
        }

        public ActionResult Delete(SupplierVM supplierVm)
        {
            var supplier = Mapper.Map<Supplier>(supplierVm);
            _supplierManager.Delete(supplier);
            return RedirectToAction("Show");
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var supplier = _supplierManager.GetById(Id);
            var aCustomer = Mapper.Map<SupplierVM>(supplier);
            return View(aCustomer);
        }

        [HttpPost]
        public ActionResult Edit(SupplierVM supplierVm)
        {
            var supplier = Mapper.Map<Supplier>(supplierVm);
            _supplierManager.Update(supplier);
            return RedirectToAction("Show");

        }
    }
}