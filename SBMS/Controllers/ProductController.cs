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
    public class ProductController : Controller
    {
        Product _product = new Product();
        ProductManager _productManager = new ProductManager();
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(ProductAddVM productAddVM)
        {
            var product = Mapper.Map<Product>(productAddVM);
            _productManager.Add(product);

            return RedirectToAction("Show");
        }
        public ActionResult Show()
        {
            ProductAddVM productAddVm= new ProductAddVM();
            productAddVm.Products = _productManager.GetAll();
            return View(productAddVm);
        }
        [HttpGet]
        public ActionResult Search()
        {
            ProductAddVM productAddVm = new ProductAddVM();
            productAddVm.Products = _productManager.GetAll();
            return View(productAddVm);
        }
        [HttpPost]
        public ActionResult Search(ProductAddVM productAddVm)
        {
            var product = _productManager.GetAll();
            if (productAddVm.Code != null)
            {
                product = product.Where(c => c.Code.ToLower().Contains(productAddVm.Code.ToLower())).ToList();
            }
            
            productAddVm.Products = product;

            return View(productAddVm);
        }
        public ActionResult Delete(ProductAddVM productAddVm)
        {
            var product = Mapper.Map<Product>(productAddVm);
            //category.Id = categoryAddVM.Id;

            _productManager.Delete(product);

            return RedirectToAction("Show");
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var product = _productManager.GetByID(Id);
            var productAddVm = Mapper.Map<ProductAddVM>(product);
            return View(productAddVm);
        }
        [HttpPost]
        public ActionResult Edit(ProductAddVM productAddVm)
        {
            var product = Mapper.Map<Product>(productAddVm);

            _productManager.Update(product);
            return RedirectToAction("Show");
        }
    }
}