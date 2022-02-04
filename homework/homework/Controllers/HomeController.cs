
using homework.DAL;
using homework.HomeViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace homework.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext innerdb;
        public HomeController(AppDbContext db)
        {
            innerdb = db;
        }

        public IActionResult Index()
        {
            HomeViewModel hwm = new HomeViewModel
            {
                jumborton = innerdb.jumborton.FirstOrDefault(),
                counter = innerdb.counters.ToList(),
                counterItem = innerdb.counterItems.ToList(),
                features = innerdb.features.ToList(),
                socialMedias = innerdb.socialMedias.ToList(),
                news = innerdb.news.ToList(),
                categories = innerdb.categories.ToList(),
                portfolios = innerdb.portfolios.ToList(),
                pricings = innerdb.pricing.ToList(),
                clients = innerdb.clients.ToList(),
            };

            return View(hwm);
        }

    }
}
