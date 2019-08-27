﻿using SBMS.Models.Models;
using SBMS.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SBMS.BLL.BLL
{
    public class CategoryManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();

        public bool AddCategory(Category category)
        {
            return _categoryRepository.AddCategory(category);
        }

        public bool DeleteCategory(Category category)
        {
            return _categoryRepository.DeleteCategory(category);
        }

        public bool UpdateCategory(Category category)
        {
            return _categoryRepository.UpdateCategory(category);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetByID(Category category)
        {
            return _categoryRepository.GetByID(category);
        }

        public bool IsCodeExist(string code)
        {
            return _categoryRepository.IsCodeExist(code);
        }

        public bool IsNameExist(string name)
        {
            return _categoryRepository.IsNameExist(name);
        }
    }
}
