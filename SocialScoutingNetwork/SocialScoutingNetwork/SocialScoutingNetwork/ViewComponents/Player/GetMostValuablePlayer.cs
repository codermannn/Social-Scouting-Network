using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialScoutingNetwork.ViewComponents.Player
{
    
    public class GetMostValuablePlayer : ViewComponent
    {
        PlayerManager pm = new PlayerManager(new EfPlayerRepository());
        public IViewComponentResult Invoke()
        {
            var values = pm.GetListWithAllAttribution().OrderByDescending(x => x.PlayerValue).Take(3).ToList();
            return View(values);
        }
    }
}
