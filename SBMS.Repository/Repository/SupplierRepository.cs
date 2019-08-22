using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.DatabaseContext.DatabaseContext;
using SBMS.Models.Models;

namespace SBMS.Repository.Repository
{
    public class SupplierRepository
    {
       
        SBMSDbContext db= new SBMSDbContext();

        public bool Add(Supplier supplier)
        {
            db.Suppliers.Add(supplier);
            int status = db.SaveChanges();
            if (status > 0)
            {
                return true;
            }

            return false;
        }

        public bool Delete(Supplier supplier)
        {
            Supplier aSupplier = db.Suppliers.FirstOrDefault(c => c.Id == supplier.Id);
            db.Suppliers.Remove(aSupplier);
            int status = db.SaveChanges();
            if (status > 0)
            {
                return true;
            }

            return false;
        }

        public bool Update(Supplier supplier)
        {
            db.Entry(supplier).State = EntityState.Modified;
            int status = db.SaveChanges();
            if (status > 0)
            {
                return true;
            }

            return false;

        }

        public Supplier GetById(int supplierId)
        {
            Supplier aSupplier = db.Suppliers.FirstOrDefault(c => c.Id == supplierId);
            return aSupplier;
        }

        public List<Supplier> GetAll()
        {
            return db.Suppliers.ToList();
        }
       
    }
}
