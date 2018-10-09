using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyApp.Controllers
{
    public class HomeController : Controller
    {
        private ICandyRepository candyRepo;

        public HomeController(ICandyRepository candyRepo)
        {
            this.candyRepo = candyRepo;
        }

        public ViewResult Index()
        {
            candyRepo.GetAll();
            return View();
        }
    }
}
