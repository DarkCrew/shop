using ChristmasShop.Data.interfaces;
using ChristmasShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasShop.Data.Repository
{
    public class TreeRepository : IAllTrees
    {
        private readonly AppDBContent appDBContent;

        public TreeRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Tree> Trees => appDBContent.Tree.Include(c => c.CategoryTree);

        public IEnumerable<Tree> getFavTrees => appDBContent.Tree.Where(p => p.isFavourite).Include(c => c.CategoryTree);

        public Tree getObjectTree(int treeId) => appDBContent.Tree.FirstOrDefault(p => p.id == treeId);
    }
}
