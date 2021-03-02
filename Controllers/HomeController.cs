using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DealerOnShop.Models;
using Microsoft.AspNetCore.Http;

namespace DealerOnShop.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {

            ViewBag.cart = _context.CartItems.Include( c => c.product).ToList();
            ViewBag.products = _context.Products.ToList();
            return View();
        }

        [HttpPost("addProduct")]
        public IActionResult addProduct(Product newProduct)
        {
            if (ModelState.IsValid)
            {

                Product ProductinDB = _context.Products.SingleOrDefault(p => p.Name == newProduct.Name);
                if (ProductinDB != null)
                {
                    ModelState.AddModelError("Name", "Name Already In Use");
                    return View("Index");
                }
                // newProduct.Price = Math.Round(newProduct.Price, 1, MidpointRounding.AwayFromZero);
                Console.WriteLine(newProduct.Price);
                Console.WriteLine(newProduct.Name);
                _context.Products.Add(newProduct);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("addToCart")]
        public IActionResult addToCart(int ProductId)
        {
            CartItem CartItemInDB = _context.CartItems.SingleOrDefault(p => p.ProductId == ProductId);
            if (CartItemInDB != null)
            {
                CartItemInDB.Quantity += 1;
                CartItemInDB.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            CartItem newItem = new CartItem();
            newItem.ProductId = ProductId;
            newItem.Quantity = 1;
            _context.CartItems.Add(newItem);
            Console.WriteLine("Adding to cart...");
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpPost("checkout")]

        public IActionResult checkout()
        {
            

            return RedirectToAction("receipt");
        }


        [HttpGet("receipt")]

        public IActionResult receipt()
        {
            List<CartItem> cartInDB =_context.CartItems.Include( c => c.product).ToList();
            ViewBag.cart = cartInDB;
            foreach (var item in cartInDB)
            {
                _context.CartItems.Remove(item);
            }
            _context.SaveChanges();
            return View();
        }
    }
}
