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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string ProductName="",int CompanyId=0,int Price=0,bool Active=false,int Stock=0,bool IdDeleted=false)
        {


            return RedirectToAction("Index");
        }
     
    }
}