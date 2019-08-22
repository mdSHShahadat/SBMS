using SBMS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SBMS.Models
{
    public class CustomerVM
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Image { get; set; }
        public int LolaltyPoint { get; set; }

        public List<Customer> Customers { get; set; }
    }
}