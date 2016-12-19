using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
          
            MVCProjectEntities1 db = new MVCProjectEntities1();
            return View(db.Product);
        }

        public ActionResult Index1()
        {
            ProductModel pm = new ProductModel();
            return View(pm.Get());
        }
     
    }
}