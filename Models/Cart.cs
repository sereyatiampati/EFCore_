using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
   public class Cart
{
    public int CartId { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    
    public ICollection<CartItem> CartItems { get; set; }  // Joining entity
    
    
}

public class CartItem
{
    public int CartItemId { get; set; }
    public int CartId { get; set; }
    public Cart Cart { get; set; }
    
    public int ProductId { get; set; }
    public Product Product { get; set; }
    

}

public class UserCart
{
    public int UserId { get; set; }
    public User User { get; set; }

    public int CartId { get; set; }
    public Cart Cart { get; set; }
}

}