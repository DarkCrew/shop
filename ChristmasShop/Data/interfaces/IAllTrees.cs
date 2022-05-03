using ChristmasShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasShop.Data.interfaces
{
    public interface IAllTrees
    {
        IEnumerable<Tree> Trees { get; }
        IEnumerable<Tree> getFavTrees { get; }
        Tree getObjectTree(int treeId);
    }
}
