using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Models.Models;
using SBMS.Repository.Repository;

namespace SBMS.BLL.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();

        public bool Add(Customer customer)
        {
            return _customerRepository.Add(customer);
        }

        public bool Delete(Customer customer)
        {
            return _customerRepository.Delete(customer);
        }

        public bool Update(Customer customer)
        {
            return _customerRepository.Update(customer);
        }

        public Customer GetById(int customerId)
        {
            return _customerRepository.GetById(customerId);
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }
        
    }
}
