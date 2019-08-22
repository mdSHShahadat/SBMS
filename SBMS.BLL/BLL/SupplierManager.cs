using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Models.Models;
using SBMS.Repository.Repository;

namespace SBMS.BLL.BLL
{
    public class SupplierManager
    {
        SupplierRepository _supplierRepository = new SupplierRepository();

        public bool Add(Supplier supplier)
        {
            return _supplierRepository.Add(supplier);
        }

        public bool Delete(Supplier supplier)
        {
            return _supplierRepository.Delete(supplier);
        }

        public bool Update(Supplier supplier)
        {
            return _supplierRepository.Update(supplier);
        }

        public Supplier GetById(int supplierId)
        {
            return _supplierRepository.GetById(supplierId);
        }

        public List<Supplier> GetAll()
        {
            return _supplierRepository.GetAll();
        }
    }
}
