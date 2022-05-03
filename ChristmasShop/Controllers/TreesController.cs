using ChristmasShop.Data.interfaces;
using ChristmasShop.Data.Models;
using ChristmasShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasShop.Controllers
{
    public class TreesController : Controller
    {
        private readonly IAllTrees _allTrees;
        private readonly ITreesCategory _allCategoriesTrees;

        public TreesController(IAllTrees iAllTrees, ITreesCategory iTreesCat)
        {
            _allTrees = iAllTrees;
            _allCategoriesTrees = iTreesCat;
        }

        [Route("Trees/List")]
        [Route("Trees/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Tree> trees = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                trees = _allTrees.Trees.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("natural", category, StringComparison.OrdinalIgnoreCase))
                {
                    trees = _allTrees.Trees.Where(i => i.CategoryTree.categoryName.Equals("natural Christmas trees")).OrderBy(i => i.id);
                    currCategory = "natural Christmas trees";
                }
                else if (string.Equals("artificial", category, StringComparison.OrdinalIgnoreCase))
                {
                    trees = _allTrees.Trees.Where(i => i.CategoryTree.categoryName.Equals("artificial Christmas trees")).OrderBy(i => i.id);
                    currCategory = "artificial Christmas trees";
                }

            }

            var treeObj = new TreesListViewModel
            {
                allTrees = trees,
                currCategory = currCategory
            };

            ViewBag.Title = "Page with trees";

            return View(treeObj);
        }

    }
}
