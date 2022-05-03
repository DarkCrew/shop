using ChristmasShop.Data.interfaces;
using ChristmasShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllTrees _treeRep;

        public HomeController(IAllTrees treeRep)
        {
            _treeRep = treeRep;
        }

        public ViewResult Index()
        {
            var homeTrees = new HomeViewModel
            {
                favTrees = _treeRep.getFavTrees
            };
            return View(homeTrees);
        }
    }
}
