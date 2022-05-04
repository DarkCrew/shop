using ChristmasShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasShop.ViewModels
{
    public class SearchViewModel
    {
        public List<Tree> trees { get; set; }

        public string Text { get; set; }
    }
}
