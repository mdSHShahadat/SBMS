using SBMS.DatabaseContext.DatabaseContext;
using SBMS.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }
        public bool Delete(Category category)
        {
            int isExecuted = 0;
            Category aCategory = db.Categories.FirstOrDefault(c => c.Id == category.Id);

            db.Categories.Remove(aCategory);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }


            return false;
        }

        public bool Update(Category category)
        {
            db.Entry(category).State =EntityState.Modified;
            int isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public Category GetByID(int categoryId)
        {
            Category category = db.Categories.FirstOrDefault(c => c.Id == categoryId);
            return category;
        }
    }
}
