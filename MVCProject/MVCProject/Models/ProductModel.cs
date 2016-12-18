using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCProject.Models
{
    public class ProductModel
    {
        public class Product
        {
            [Key]
            public int Id { get; set; }
            public string ProductName { get; set; }
            public int CompanyId { get; set; }
            public decimal Price { get; set; }
            public bool Active { get; set; }
            public int Stock { get; set; }
            public bool IdDeleted { get; set; }

        }

        


        public  List<Product> Get()
        {
            MVCProjectEntities1 db = new MVCProjectEntities1();
            var data = db.Product;
            List<Product> ProductList = new List<Product>();
            
            //方法一
                //foreach (var item in data)
                //{
                //    Product p = new Product
                //    {
                //        Id = item.Id,
                //        ProductName = item.ProductName,
                //        CompanyId = item.CompanyId,
                //        Price = item.Price,
                //        Active = item.Active.Value,
                //        Stock = item.Stock.Value,
                //        IdDeleted = item.IdDeleted
                //    };
                //    ProductList.Add(p);
                //}
            //方法二
            ProductList = (from item in data
                           select new Product
                           {
                               Id = item.Id,
                               ProductName = item.ProductName,
                               CompanyId = item.CompanyId,
                               Price = item.Price,
                               Active = item.Active.Value,
                               Stock = item.Stock.Value,
                               IdDeleted = item.IdDeleted
                           }).ToList();
                
                return ProductList;
            
        }
    }

}
    