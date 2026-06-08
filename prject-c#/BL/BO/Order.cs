using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        public bool member { get; set; }
        public double TotalPrice { get; set; } = 0;
        public List<ProductInOrder> ProductListInOrder { get; set; } = new List<ProductInOrder>();
        public Order()
        {
            
        }
        public Order(bool m)
        {
            member = m; 
        }
    }
}
