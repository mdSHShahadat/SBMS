using SBMS.DatabaseContext.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Models.Models;
using System.Data.Entity;

namespace SBMS.Repository.Repository
{
    public class ProductRepository
    {
        SBMSDbContext db = new SBMSDbContext();

        public bool Add(Product product)
        {
            db.Products.Add(product);
            int ifRowAffected = db.SaveChanges();
            if (ifRowAffected > 0)
            {
                return true;
            }
            return false;

        }

        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }
        public bool Delete(Product product)
        {
            int isExecuted = 0;
            Product aProduct = db.Products.FirstOrDefault(c => c.Id == product.Id);

            db.Products.Remove(aProduct);
            isExecuted = db.SaveChanges();

            if (isExecuted > 0)
            {
                return true;
            }


            return false;
        }

        public bool Update(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            int isExecuted = db.SaveChanges();
            if (isExecuted > 0)
            {
                return true;
            }
            return false;
        }

        public Product GetByID(int productId)
        {
            Product product = db.Products.FirstOrDefault(c => c.Id == productId);
            return product;
        }
    }
}
