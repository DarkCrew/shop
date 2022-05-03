using ChristmasShop.Data.interfaces;
using ChristmasShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasShop.Data.Repository
{
    public class CategoryTreeRepository : ITreesCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryTreeRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<CategoryTree> AllCategories => appDBContent.CategoryTree;
    }
}
