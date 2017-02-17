using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdminLTE.Models
{
    public class ProductModels
    {
        [Key]
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string Productname { get; set; }
        public decimal Price { get; set; }

    }
}