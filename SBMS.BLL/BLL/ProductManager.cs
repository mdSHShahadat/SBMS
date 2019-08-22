using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBMS.Models.Models;
using SBMS.Repository.Repository;

namespace SBMS.BLL.BLL
{
    public class ProductManager
    {
        ProductRepository _productRepository = new ProductRepository();
        Product product = new Product();
        
        public bool Add(Product product)
        {
            return _productRepository.Add(product);
        }
        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }
        public bool Delete(Product product)
        {
            return _productRepository.Delete(product);
        }
        public Product GetByID(int productId)
        {

            return _productRepository.GetByID(productId);
        }

        public bool Update(Product product)
        {
            return _productRepository.Update(product);
        }
    }
}
