using CompanyTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Our services";
            var s = new Services() { 
                Name = "Online Purchase",
            };

            var s1 = new Services()
            {
                Name = "Replacement facility",
            };

            var s2 = new Services()
            {
                Name = "Installment Service",
            };

            var s3 = new Services()
            {
                Name = "Repair Service",
            };

            Services[] services = new Services[] {s,s1, s2, s3};

            return View(services);
        }

        public ActionResult Team()
        {
            ViewBag.Message = "Team and members";
            var m1 = new Members()
            {
                Name = "Tamim",
                Phone = "123123123"

            };
            var m2 = new Members()
            {
                Name = "Rahim",
                Phone = "623123123"

            };
            var m3 = new Members()
            {
                Name = "Tamyl",
                Phone = "423123123"

            };
            var m4 = new Members()
            {
                Name = "amim",
                Phone = "323123123"

            };
            var m5 = new Members()
            {
                Name = "sdim",
                Phone = "123123123"

            };
            var m6 = new Members()
            {
                Name = "kalim",
                Phone = "143123123"

            };
            var m7 = new Members()
            {
                Name = "sulim",
                Phone = "163123123"

            };
            var m8 = new Members()
            {
                Name = "malim",
                Phone = "113123123"

            };
            var m9 = new Members()
            {
                Name = "gamim",
                Phone = "183123123"

            };
            var m10 = new Members()
            {
                Name = "ramim",
                Phone = "163123123"

            };
            var m11 = new Members()
            {
                Name = "solim",
                Phone = "153123123"

            };
            var m12 = new Members()
            {
                Name = "Thaim",
                Phone = "123123123"

            };
            Members[] A_Team = new Members[] { m1, m2, m3, m4 };
            Members[] B_Team = new Members[] { m5, m6, m7, m8 };
            Members[] C_Team = new Members[] { m9, m10, m11, m12 };

            var t1 = new Team() { Name = "Development Team", Memberss = A_Team };
            var t2 = new Team() { Name = "Testing Team", Memberss = B_Team };
            var t3 = new Team() { Name = "Management Team", Memberss = C_Team };

            Team[] teams = new Team[] { t1,t2,t3 };

            return View(teams);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us";

            var c = new Contacts()
            {
                Name = "",
                Email = "",
                phone = "",
                Query = "",
            };

            return View(c);
        }
    }
}