using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        
        public ICollection<Order> Orders { get; set; }
        public ICollection<Cart> Carts { get; set; }  // Many-to-many with Cart
        
    }
}