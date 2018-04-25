using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            List <Contact> allContacts = Contact.GetAll();
            return View(allContacts);
        }

        [HttpGet("/contact/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/contact")]
        public ActionResult Create()
        {
        Contact newContact = new Contact(Request.Form["first-name"], Request.Form["last-name"], Request.Form["phone-number"], Request.Form["email"], Request.Form["street"], Request.Form["city"], Request.Form["state"], Request.Form["zip"]);
        List <Contact> allContacts = Contact.GetAll();
        return View("Index", allContacts);
        }

        [HttpPost("contact/clear")]
        public ActionResult Clear()
        {
            Contact.ClearAll();
            return View();
        }
    }
}
