using ChristmasShop.Data;
using ChristmasShop.Data.Models;
using Korzh.EasyQuery.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChristmasShop.ViewModels;

namespace ChristmasShop.Controllers
{
    public class SearchController : Controller
    {

        private readonly AppDBContent appDBContent;

        public SearchController(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IActionResult Search()
        {
            SearchViewModel model = new SearchViewModel();
            model.trees = appDBContent.Tree.ToList();
            return View(model);
        }

        private List<Tree> SearchEverywhere(string text) => appDBContent.Tree.FullTextSearchQuery(text).ToList();


        [HttpPost]
        public IActionResult Search(SearchViewModel model)
        {

            if (!string.IsNullOrEmpty(model.Text))
            {
                model.trees = SearchEverywhere(model.Text).ToList();
            }
            else model.trees = appDBContent.Tree.ToList();
            model.trees = model.trees.Distinct().ToList();
            return View(model);
        }
    }
}
