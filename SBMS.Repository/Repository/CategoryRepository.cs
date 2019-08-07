using SBMS.DatabaseContext.DatabaseContext;
using SBMS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBMS.Repository.Repository
{
    public class CategoryRepository
    {
        SBMSDbContext db = new SBMSDbContext();
        
        public bool Add(Category category)
        {
            db.Categories.Add(category);
            int ifRowAffected =db.SaveChanges();
            if (ifRowAffected > 0)
            {
                return true;
            }
            return false;
           
        }
    }
}
