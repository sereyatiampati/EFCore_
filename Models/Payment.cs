using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Payment
    {
            public int PaymentId { get; set; }
            public decimal Amount { get; set; }
            
            public int OrderId { get; set; }
            public Order Order { get; set; }
    }
}