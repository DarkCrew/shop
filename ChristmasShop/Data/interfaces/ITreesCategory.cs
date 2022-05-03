using ChristmasShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasShop.Data.interfaces
{
    public interface ITreesCategory
    {
        IEnumerable<CategoryTree> AllCategories { get; } // function that receives data
    }
}
