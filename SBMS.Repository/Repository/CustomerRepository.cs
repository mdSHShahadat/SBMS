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
    public class CustomerRepository
    {
        SBMSDbContext db = new SBMSDbContext();
        public bool Add(Customer customer)
        {
            db.Customers.Add(customer);
            int ifRowAffected = db.SaveChanges();
            if (ifRowAffected > 0)
            {
                return true;
            }

            return false;
        }

        public bool Delete(Customer customer)
        {
            Customer aCustomer = db.Customers.FirstOrDefault(c => c.Id == customer.Id);
            db.Customers.Remove(aCustomer);
            int ifAffected = db.SaveChanges();
            if (ifAffected > 0)
            {
                return true;
            }

            return false;
        }

        public bool Update(Customer customer)
        {
            db.Entry(customer).State = EntityState.Modified;
            int ifAffected = db.SaveChanges();
            if (ifAffected > 0)
            {
                return true;
            }

            return false;
        }

        public Customer GetById(int customerId)
        {
            Customer customer = db.Customers.FirstOrDefault(c => c.Id == customerId);
            return customer;
        }

        public List<Customer> GetAll()
        {
            return db.Customers.ToList();
        }
    }
}
