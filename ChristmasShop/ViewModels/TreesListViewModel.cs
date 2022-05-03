using ChristmasShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasShop.ViewModels
{
    public class TreesListViewModel
    {
        public IEnumerable<Tree> allTrees { get; set; }
        public string currCategory { get; set; }
    }
}
