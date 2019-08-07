using SBMS.Models.Models;
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
        CategoryRepository _categoryRepositoy = new CategoryRepository();
        Category _category = new Category();
        public bool Add(Category category)
        {
            return _categoryRepositoy.Add(category);
        }
    }
}
