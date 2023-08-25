using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
        
        public ICollection<Product> Products { get; set; }
    }
}