using ChristmasShop.Data.interfaces;
using ChristmasShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasShop.Data.mocks
{
    public class MockTrees : IAllTrees
    {
        private readonly ITreesCategory _categoryTrees = new MockCategoryTree();

        public IEnumerable<Tree> Trees { 
            get
            {
                return new List<Tree>
                {
                    new Tree {
                        name = "EVERGREEN",
                        shortDesc = "Ель искусственная Скандинавская светлая (на деревянном пне) - 2 метра",
                        img = "/img/EVERGREEN.jpg",
                        price = 439,
                        isFavourite = true,
                        isAvailable = true,
                        CategoryTree = _categoryTrees.AllCategories.First()
                    },
                    new Tree {
                        name = "GreenTerra",
                        shortDesc = "Ель Аляска заснеженная 180 см",
                        img = "/img/GreenTerra.jpg",
                        price = 1000,
                        isFavourite = true,
                        isAvailable = true,
                        CategoryTree = _categoryTrees.AllCategories.First()
                    },
                    new Tree {
                        name = "BelarusTree",
                        shortDesc = "Ель живая",
                        img = "/img/BelarusTree.jpg",
                        price = 319,
                        isFavourite = true,
                        isAvailable = true,
                        CategoryTree = _categoryTrees.AllCategories.Last()
                    },
                    new Tree {
                        name = "Dommelochi",
                        shortDesc = "Ель искусственная Grace c LED-подсветкой 180 см",
                        img = "/img/Dommelochi.jpg",
                        price = 572,
                        isFavourite = true,
                        isAvailable = true,
                        CategoryTree = _categoryTrees.AllCategories.First()
                    },
                    new Tree {
                        name = "Max Christmas",
                        shortDesc = "Ель искусственная Романовская заснеженная 180 см",
                        img = "/img/MaxChristmas.jpg",
                        price = 1078,
                        isFavourite = false,
                        isAvailable = true,
                        CategoryTree = _categoryTrees.AllCategories.First()
                    },
                    new Tree {
                        name = "National Tree Company",
                        shortDesc = "Ель искусственная Glenridge Fir Slim Hinged 183 см",
                        img = "/img/NationalTreeCompany.jpg",
                        price = 567,
                        isFavourite = false,
                        isAvailable = true,
                        CategoryTree = _categoryTrees.AllCategories.First()
                    },
                    new Tree {
                        name = "Nordic Collection",
                        shortDesc = "Ель розовая Teddy Pink Flocked 180 см",
                        img = "/img/NordicCollection.jpg",
                        price = 469,
                        isFavourite = false,
                        isAvailable = true,
                        CategoryTree = _categoryTrees.AllCategories.First()
                    },
                    new Tree {
                        name = "GrandSITI",
                        shortDesc = "Ель литая GrandSiti Parma 150 см",
                        img = "/img/GrandSITI.jpg",
                        price = 418,
                        isFavourite = true,
                        isAvailable = true,
                        CategoryTree = _categoryTrees.AllCategories.First()
                    },
                    new Tree {
                        name = "Matpol",
                        shortDesc = "Ель новогодняя Альпийская премиум 180 см",
                        img = "/img/Matpol.jpg",
                        price = 670,
                        isFavourite = false,
                        isAvailable = true,
                        CategoryTree = _categoryTrees.AllCategories.First()
                    }
                };
            }
        }

        public IEnumerable<Tree> getFavTrees { get; set; }

        public Tree getObjectTree(int treeId)
        {
            throw new NotImplementedException();
        }
    }
}
