using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SessionCart.Web.DAL;
using SessionCart.Web.Models;

namespace SessionCart.Web.Controllers
{
    public class StoreController : Controller
    {
        /* Steps
          
       */
       // TODO 01 Dependency injection
       private IProductDAO productDAO { get; }
        public StoreController(IProductDAO productDAO)
        {
            this.productDAO = productDAO;
        }

        public ActionResult Index()
        {
            return View(productDAO.GetProducts());
        }

        // TODO 06 Method to handle post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddToCart(Product product, int quantity)
        {
            // TODO 07 Get the rest of the product information
            product = productDAO.GetProduct(product.Id);

            // TODO 08 Create a shopping cart and add the item
            //ShoppingCart cart = new ShoppingCart();
            // TODO 20 Replace above line with the method
            ShoppingCart cart = GetActiveShoppingCart();
            cart.AddToCart(product, quantity);
            SaveActiveShoppingCart(cart);
            return RedirectToAction("ViewCart");
        }

        public IActionResult ViewCart()
        {
            // TODO 12 Get the shopping cart json out of the session
            string shopping_cart = HttpContext.Session.GetString("Shopping_Cart");
            // TODO 13 Turn the json back into an object
            ShoppingCart cart = JsonConvert.DeserializeObject<ShoppingCart>(shopping_cart);
            return View(cart);
        }

        [HttpPost]
        // Always a good idea
        [ValidateAntiForgeryToken]
        public ActionResult RemoveFromCart(int id)
        {
            //TODO 35 Get the product
            Product product = productDAO.GetProduct(id);
            //TODO 36 Get the cart from Session or create a new on
            ShoppingCart cart = GetActiveShoppingCart();
            //TODO 37 call remove on cart object.
            cart.RemoveOne(product);
            //TODO 38 don't forget to return the cart to the session
            SaveActiveShoppingCart(cart);

            return RedirectToAction("ViewCart");
        }

        // TODO 09 Private method to save a cart to the session
        private void SaveActiveShoppingCart(ShoppingCart cart)
        {
            // TODO 10 Convert cart object to json
            string shopping_cart_string = JsonConvert.SerializeObject(cart);
            // TODO 11 Add to session
            HttpContext.Session.SetString("Shopping_Cart", shopping_cart_string);
        }

        // TODO 14 Need a new method to get the cart from session if there, if not, create a new one
        // This is going to replace TODO 08
        private ShoppingCart GetActiveShoppingCart()
        {
            // TODO 15 Create a bucket
            ShoppingCart cart = null;

            // TODO 16 Check to see if we already have a cart in the Session
            if (HttpContext.Session.GetString("Shopping_Cart") == null)
            {
                // TODO 17 If we're here, no shopping cart saved
                cart = new ShoppingCart();
                SaveActiveShoppingCart(cart);
            } else
            {
                // TODO 18 Since there is a shopping cart, get it from the session
                string shopping_cart = HttpContext.Session.GetString("Shopping_Cart");
                // TODO 19 Turn back into an object
                cart = JsonConvert.DeserializeObject<ShoppingCart>(shopping_cart);
            }
            return cart;
        }
    }
}