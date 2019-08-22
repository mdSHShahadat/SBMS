using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SBMS.Models
{
    public class SupplierVM
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string ContactPerson { get; set; }
        public string Image { get; set; }

    }
}