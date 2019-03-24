using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        private static List<Contact> contacts = new List<Contact>
        {
            new Contact
            {
                Id = "001",
                FirstName = "San",
                LastName = "Zhang",
                EmailAddress = "zhangsan@gmail.com",
                PhoneNo = "123"
            },
            new Contact
            {
                Id = "002",
                FirstName = "Si",
                LastName = "Li",
                EmailAddress = "lisi@gmail.com",
                PhoneNo = "456"
            }
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Find(string firstName = "", string lastName = "")
        {
            var result = from contact in contacts
                         where (string.IsNullOrEmpty(firstName) || contact.FirstName.ToLower().Contains(firstName.ToLower()))
                            && (string.IsNullOrEmpty(lastName) || contact.LastName.ToLower().Contains(lastName.ToLower()))
                         orderby contact.Id
                         select contact;
            return View("ContactListPartial", result.ToArray());
        }
    }
}
