using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasShop.Data.Models
{
    public class CategoryTree
    {
        public int id { set; get; }

        public string categoryName { set; get; }

        public string desc { set; get; }

        public List<Tree> trees { set; get; }
    }
}
