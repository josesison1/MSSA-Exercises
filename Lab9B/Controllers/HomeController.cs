using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Lab9B.Models;

namespace Lab9B.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<string> results = new List<string>();

            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name ?? "<No Name>";
                decimal? price = p?.Price ?? 0;
                string relatedName = p?.Related?.Name ?? "<None>";
                results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            }
            return View(results);
        }

        public ViewResult Index2()
        {
            string[] names = new string[3];
            names[0] = "Bob";
            names[1] = "Joe";
            names[2] = "Alice";
            return View("Index", names);
        }

        public ViewResult Index3()
        {
        Dictionary<string, Product> products = new Dictionary<string, Product>
        {
            ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
            ["Lifejacket"] = new Product { Name = "LifeJacket", Price = 48.95M }
        };
        return View("Index", products.Keys);
        }
    }

}

