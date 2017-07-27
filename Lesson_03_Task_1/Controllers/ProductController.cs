using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lesson_03_Task_1.Models;

namespace Lesson_03_Task_1.Controllers
{
    public class ProductController : Controller
    {        
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateProducts()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product()
            {
                ID = 1,
                Name = "product 1",
                Price = 11.42m,
                CreateDate = DateTime.Now.ToShortDateString()
            });

            products.Add(new Product()
            {
                ID = 2,
                Name = "product 2",
                Price = 42.20m,
                CreateDate = DateTime.Now.ToShortDateString()
            });

            products.Add(new Product()
            {
                ID = 3,
                Name = "product 3",
                Price = 64.95m,
                CreateDate = DateTime.Now.ToShortDateString()
            });

            return View(products);
        }
    }
}