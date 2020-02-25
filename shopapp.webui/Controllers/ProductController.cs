using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;
using shopapp.webui.ViewModels;

namespace shopapp.webui.Controllers
{
    public class ProductController: Controller
    {
        public IActionResult List(){
            var products = new List<Product>(){
                new Product(){Name = "samsung s6", Price = 1000, Description = "iyi telefon"},
                new Product(){Name = "samsung s7", Price = 2000, Description = "çok iyi telefon", IsApproved = true},
                new Product(){Name = "samsung s8", Price = 3000, Description = "çok iyi telefon", IsApproved = true},
                new Product(){Name = "samsung s9", Price = 4000, Description = "çok iyi telefon"}
            };

           

            

            var productViewModel = new ProductViewModel(){
                Products = products
            };


            return View(productViewModel);
        }

        public IActionResult Index(){

            var product = new Product(){
                Name = "samsung s6",
                Price = 1000,
                Description = "iyi telefon"
            };

            string category = "Telefonlar";
            
            /* ViewData["Category"] = category;
            ViewData["Product"] = product; */

            // ViewBag.Product = product;
            ViewBag.Category = category;


            return View(product);
        }

        public IActionResult Details(int id){
/*             ViewBag.Name = "samsung s6";
            ViewBag.Price = 1000;
            ViewBag.Description = "iyi telefon"; */
            Product product = new Product(){
                Name = "samsung s6",
                Price = 1000,
                Description = "iyi telefon"
            };

            return View(product);
        }
    }
}