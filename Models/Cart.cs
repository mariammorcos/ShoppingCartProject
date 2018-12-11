using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingProject.Models
{
    public class Cart
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Product { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Features { get; set; }

        [Required]
        public string color { get; set; }

        [Required]
        public double Total { get; set; }

        public void Total()
        {
            
        }
    }
}
