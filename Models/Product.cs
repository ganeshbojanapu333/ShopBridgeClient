using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridgeClient.Models
{
    public class Product
    {
        public int id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public string category { get; set; }
     
        [Required]
        [DataType(DataType.Currency)]
        public float? price { get; set; }
        [Required]
        public int quantity { get; set; }
    }
}
