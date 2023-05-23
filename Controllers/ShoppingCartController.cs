using GamesWebAppDB.Models;
using GamesWebAppDB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GamesWebAppDB.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly iGameRepo _gameRepo;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(iGameRepo gameRepo, ShoppingCart shoppingCart)
        {
            _gameRepo = gameRepo;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int Id)
        {
            var selectedGame = _gameRepo.allGames.FirstOrDefault(g => g.Id == Id);

            if (selectedGame != null)
            {
                _shoppingCart.AddToCart(selectedGame, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int Id)
        {
            var selectedGame = _gameRepo.allGames.FirstOrDefault(m => m.Id == Id);

            if (selectedGame != null)
            {
                _shoppingCart.RemoveFromCart(selectedGame);
            }
            return RedirectToAction("Index");
        }
    }
}
