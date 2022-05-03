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
    public class ShopCartController : Controller
    {
        private readonly IAllTrees _treeRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllTrees treeRep, ShopCart shopCart)
        {
            _treeRep = treeRep;
            _shopCart = shopCart;
        }

        public RedirectResult Delete(int id)
        {
            _shopCart.DeleteByID(id);
            return Redirect("/ShopCart/Index");
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _treeRep.Trees.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
