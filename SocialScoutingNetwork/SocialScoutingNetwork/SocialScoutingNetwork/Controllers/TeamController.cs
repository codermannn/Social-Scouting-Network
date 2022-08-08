using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialScoutingNetwork.Controllers
{
    public class TeamController : Controller
    {
        TeamManager tm = new TeamManager(new EfTeamRepository());
        public IActionResult Index()
        {
            var values = tm.GetListWithAllAttribution();
            return View(values);
        }
    }
}
