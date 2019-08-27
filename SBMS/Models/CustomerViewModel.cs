﻿using SBMS.Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SBMS.Models
{
    public class CustomerViewModel
    {
        public int ID { get; set; }

        [Display(Name = "Code")]
        [Required(ErrorMessage = "Please enter Code")]
        [StringLength(10, MinimumLength = 3)]
        public string Code { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter Name")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter Email")]
        [StringLength(50)]
        public string Email { get; set; }

        [Display(Name = "Contact")]
        [Required(ErrorMessage = "Please enter Contact No")]
        [StringLength(12)]
        public string Contact { get; set; }

        [Display(Name = "Loyalty point")]
        [Required(ErrorMessage = "Please enter Loyalty point")]
        public int LoyaltyPoint { get; set; }

        [Display(Name = "Image")]
        public string Image { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }

        public List<Customer> Customers { get; set; }
    }
}