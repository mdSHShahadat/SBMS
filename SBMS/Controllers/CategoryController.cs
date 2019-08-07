using AutoMapper;
using SBMS.BLL.BLL;
using SBMS.Models;
using SBMS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBMS.Controllers
{
    public class CategoryController : Controller
    {
        Category _category = new Category();
        CategoryManager _categoryManager = new CategoryManager();
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(CategoryAddVM categoryAddVM)
        {
                        
            var category = Mapper.Map<Category>(categoryAddVM);
            if (ModelState.IsValid)
            {
                if (_categoryManager.Add(category))
                {
                    ViewBag.SuccessMsg="Saved!!!";   
                }
                else
                {
                    ViewBag.FailedMsg="Faield!!!";
                }
            }else
            {
                ViewBag.ValidationMsg="Validation Failed!!!";
            }
            
            
            return View(categoryAddVM);
        }
    }
}