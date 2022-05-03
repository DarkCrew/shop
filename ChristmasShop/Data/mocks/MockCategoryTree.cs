using ChristmasShop.Data.interfaces;
using ChristmasShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasShop.Data.mocks
{
    public class MockCategoryTree : ITreesCategory
    {
        public IEnumerable<CategoryTree> AllCategories {
            get
            {
                return new List<CategoryTree>{
                    new CategoryTree { categoryName = "artificial Christmas trees", desc = "Trees with artificial needles"},
                    new CategoryTree { categoryName = "natural Christmas trees", desc = "Trees with natural needles" }
                };
            }
        }
    }
}
