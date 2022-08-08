using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialScoutingNetwork.Controllers
{
    public class LeagueController : Controller
    {
        LeagueManager lm = new LeagueManager(new EfLeagueRepository());
        public IActionResult Index()
        {
            var values = lm.GetList();
            return View(values);
        }
    }
}
