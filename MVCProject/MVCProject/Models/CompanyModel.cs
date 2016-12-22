using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCProject.Models
{
    public class CompanyModel
    {
        public class Company
        {
            [Key]
            public int CompanyId { get; set;}
            public string Name { get; set; }
        }
        MVCProjectEntities1 db = new MVCProjectEntities1();
        public List<Company> Get()
        {
            var data = db.Company;
            List<Company> CompanyList = new List<Company>();
            if (data != null)
            {
                CompanyList = (from item in data
                               select new Company
                               {
                                   CompanyId = item.CompanyId,
                                   Name = item.Name
                               }).ToList();
            }
            return CompanyList;

        }

        public int Create(Company item)
        {
            Models.Company data = new Models.Company()
            {
                CompanyId = item.CompanyId,
                Name = item.Name
            };
            db.Company.Add(data);
            db.SaveChanges();
            return 1;
        }


    }
}