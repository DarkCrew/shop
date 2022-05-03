using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasShop.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int TreeID { get; set; }
        public uint price { get; set; }
        public virtual Tree tree { get; set; }
        public Order order { get; set; }
    }
}
