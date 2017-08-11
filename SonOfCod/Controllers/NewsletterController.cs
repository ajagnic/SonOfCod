using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace SonOfCod.Controllers
{
    public class NewsletterController : Controller
    {
        private readonly ApplicationDbContext _db;

        public NewsletterController(ApplicationDbContext db)
        {
            _db = db;
        }

       /* public NewsletterController()
        {

        }*/ //TEMP CONSTRUCT FOR TESTING

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Subscriber subscriber)
        {
            _db.Subscribers.Add(subscriber);
            _db.SaveChanges();
            return Redirect("~/Marketing/Index");
        }

        [Authorize]
        public IActionResult SubList()
        {
            return View(_db.Subscribers);
        }

    }
}
