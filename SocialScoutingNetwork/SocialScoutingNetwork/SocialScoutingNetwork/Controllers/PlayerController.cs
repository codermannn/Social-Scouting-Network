using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialScoutingNetwork.Controllers
{
    public class PlayerController : Controller
    {
        PlayerManager pm = new PlayerManager(new EfPlayerRepository());
        public IActionResult Index()
        {
            var values = pm.GetListWithAllAttribution();
            return View(values);
        }

        public IActionResult GetMostValuablePlayer()
        {
            var c = new Context();
            var values = pm.GetListWithAllAttribution().OrderByDescending(x => x.PlayerValue).Take(3);
            return View(values);
        }

        

        public IActionResult PlayerDetails(int id)
        {
            var c = new Context();
            ViewBag.i = id;
            ViewBag.pn = c.Players.Find(id).PlayerName;
            ViewBag.ps = c.Players.Find(id).PlayerSurname;
            var values = pm.GetListWithAllAttribution2(id);
            return View(values);
        }
    }
}
