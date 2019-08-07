using SBMS.BLL.BLL;
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
        public ActionResult Add(Category category)
        {
            Category categoryAdd = new Category();
            categoryAdd.Code = category.Code;
            categoryAdd.Name = category.Name;
            var status= _categoryManager.Add(categoryAdd);
            
            return View(categoryAdd);
        }
    }
}