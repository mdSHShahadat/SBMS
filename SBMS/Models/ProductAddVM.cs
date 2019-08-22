using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SBMS.Models.Models;


namespace SBMS.Models
{
    public class ProductAddVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter category code!!!")]
        [MinLength(3)]
        public string Code { get; set; }
        [Required(ErrorMessage = "Please enter category name!!!")]
        [MaxLength(24)]
        public string Name { get; set; }
        public string ReorderLevel { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}