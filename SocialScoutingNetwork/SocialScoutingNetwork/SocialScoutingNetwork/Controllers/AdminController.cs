using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SocialScoutingNetwork.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SocialScoutingNetwork.Controllers
{
    
    public class AdminController : Controller
    {
        PlayerManager pm = new PlayerManager(new EfPlayerRepository());
        CountryManager cm = new CountryManager(new EfCountryRepository());
        TeamManager tm = new TeamManager(new EfTeamRepository());
        LeagueManager lm = new LeagueManager(new EfLeagueRepository());
        SkillManager sm = new SkillManager(new EfSkillRepository());
        BlogManager blgm = new BlogManager(new EfBlogRepository());
        WriterManager wm = new WriterManager(new EfWriterRepository());
        CommentManager cmnt = new CommentManager(new EfCommentRepository());
        AdminManager am = new AdminManager(new EfAdminRepository());
        CountryManager cou = new CountryManager(new EfCountryRepository());
        ContactManager cnt = new ContactManager(new EfContactRepository());

        [AllowAnonymous]
        public IActionResult AdminLoginIndex(Admin p)
        {
            AdminLoginValidator alv = new AdminLoginValidator();
            ValidationResult results = alv.Validate(p);

            var c = new Context();
            var datavalue = c.Admins.FirstOrDefault(x => x.AdminUserName == p.AdminUserName && x.AdminPassword == p.AdminPassword);

            if (results.IsValid)
            {
                if (datavalue != null)
                {
                    return RedirectToAction("Index", "Admin");
                }
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }
        public async Task<IActionResult> Logout()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("AdminLoginIndex", "Admin");
        }
        public IActionResult ContactIndex()
        {
            var values = cnt.GetList();
            return View(values);
        }

        public IActionResult CountryIndex()
        {
            var values = cou.GetListCountry();
            return View(values);
        }

        public IActionResult AdminIndex()
        {
            var values = am.GetList();
            return View(values);
        }

        
        public IActionResult Index()
        {
            var values = pm.GetListWithAllAttribution().ToList();
            return View(values);
        }
        public IActionResult SkillIndex()
        {
            var values = sm.GetList().ToList();
            return View(values);
        }
        public IActionResult TeamIndex()
        {
            var values = tm.GetListWithAllAttribution().ToList();
            return View(values);
        }
        public IActionResult LeagueIndex()
        {
            var values = lm.GetList();
            return View(values);
        }

        public IActionResult BlogIndex()
        {
            var values = blgm.GetListWithAllAttribution().ToList();
            return View(values);
        }

        public IActionResult WriterIndex()
        {
            var values = wm.GetListWithAllAttribution().ToList();
            return View(values);
        }
        public IActionResult CommentIndex()
        {
            var values = cmnt.GetListWithAllAttribution().ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPlayer()
        {
            List<SelectListItem> valuecountry = (from x in cm.GetListCountry()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CountryName,
                                                     Value = x.CountryID.ToString()
                                                 }
                                                  ).ToList();
            ViewBag.country = valuecountry;

            List<SelectListItem> valueteam = (from x in tm.GetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.TeamName,
                                                  Value = x.TeamID.ToString()
                                              }
                                                  ).ToList();
            ViewBag.team = valueteam;

            List<SelectListItem> valueleague = (from x in lm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.LeagueName,
                                                    Value = x.LeagueID.ToString()
                                                }
                                                  ).ToList();
            ViewBag.league = valueleague;

            List<SelectListItem> valueskill = (from x in sm.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.SkillPlayerName,
                                                   Value = x.SkillID.ToString()
                                               }
                                                  ).ToList();
            ViewBag.skill = valueskill;


            return View();
        }

        [HttpPost]
        public IActionResult AddPlayer(Player p)
        {
            p.PlayerStatus = true;
            p.SkillID = 3;
            pm.AddPlayer(p);
            return RedirectToAction("Index", "Admin");
        }

        [HttpGet]
        public IActionResult AddSkill()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill p)
        {
            sm.AddSkill(p);
            return RedirectToAction("SkillIndex", "Admin");
        }

        [HttpGet]
        public IActionResult AddAdmin()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddAdmin(Admin p)
        {
            am.AddAdmin(p);
            return RedirectToAction("AdminIndex", "Admin");
        }

        [HttpGet]
        public IActionResult AddTeam()
        {
            List<SelectListItem> valuecountry = (from x in cm.GetListCountry()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CountryName,
                                                     Value = x.CountryID.ToString()
                                                 }
                                                  ).ToList();
            ViewBag.country = valuecountry;

            List<SelectListItem> valueleague = (from x in lm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.LeagueName,
                                                    Value = x.LeagueID.ToString()
                                                }
                                                  ).ToList();
            ViewBag.league = valueleague;

            return View();
        }

        [HttpPost]
        public IActionResult AddTeam(Team p)
        {
            tm.AddTeam(p);
            return RedirectToAction("TeamIndex", "Admin");
        }
        [HttpGet]
        public IActionResult AddLeague()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddLeague(League p)
        {
            lm.AddLeague(p);
            return RedirectToAction("LeagueIndex", "Admin");
        }
        [HttpGet]
        public IActionResult AddBlog()
        {
            List<SelectListItem> valueblog = (from x in wm.GetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.WriterName + " " + x.WriterSurname,
                                                  Value = x.WriterID.ToString()
                                              }
                                                  ).ToList();
            ViewBag.blog = valueblog;


            return View();
        }

        [HttpPost]
        public IActionResult AddBlog(Blog p, AddBlogImage i)
        {
            if (i.BlogImage != null)
            {
                var extension = Path.GetExtension(i.BlogImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/BlogImageFiles/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                i.BlogImage.CopyTo(stream);
                p.BlogImage = newimagename;
            }

            p.BlogStatus = true;
            blgm.AddBlog(p);
            return RedirectToAction("BlogIndex", "Admin");
        }

        [HttpGet]
        public IActionResult AddWriter()
        {
            List<SelectListItem> valuecountry = (from x in cm.GetListCountry()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CountryName,
                                                     Value = x.CountryID.ToString()
                                                 }
                                                  ).ToList();
            ViewBag.country = valuecountry;


            return View();
        }

        [HttpPost]
        public IActionResult AddWriter(Writer p, AddProfileImage i)
        {
            if (i.WriterImage != null)
            {
                var extension = Path.GetExtension(i.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                i.WriterImage.CopyTo(stream);
                p.WriterImage = newimagename;
            }

            p.WriterCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterStatus = true;
            wm.AddWriter(p);
            return RedirectToAction("WriterIndex", "Admin");
        }

        [HttpGet]
        public IActionResult UpdatePlayer(int id)
        {
            List<SelectListItem> valuecountry = (from x in cm.GetListCountry()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CountryName,
                                                     Value = x.CountryID.ToString()
                                                 }
                                                  ).ToList();
            ViewBag.country = valuecountry;

            List<SelectListItem> valueteam = (from x in tm.GetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.TeamName,
                                                  Value = x.TeamID.ToString()
                                              }
                                                  ).ToList();
            ViewBag.team = valueteam;

            List<SelectListItem> valueleague = (from x in lm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.LeagueName,
                                                    Value = x.LeagueID.ToString()
                                                }
                                                  ).ToList();
            ViewBag.league = valueleague;

            List<SelectListItem> valueskill = (from x in sm.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.SkillPlayerName,
                                                   Value = x.SkillID.ToString()
                                               }
                                                  ).ToList();
            ViewBag.skill = valueskill;

            var values = pm.GeyByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdatePlayer(Player p)
        {
            p.PlayerStatus = true;
            pm.UpdatePlayer(p);
            return RedirectToAction("Index", "Admin");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var values = sm.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAdmin(Admin p)
        {
            var list = new List<SelectListItem>
            {
                new SelectListItem{ Text="A", Value = "A" },
                new SelectListItem{ Text="B", Value = "B" },
                new SelectListItem{ Text="C", Value = "C", Selected = true },
            };

            ViewBag.role = list;

            p.AdminStatus = true;
            am.UpdateAdmin(p);
            return RedirectToAction("AdminIndex", "Admin");
        }

        [HttpGet]
        public IActionResult UpdateAdmin(int id)
        {
            var values = am.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill p)
        {
            sm.UpdateSkill(p);
            return RedirectToAction("SkillIndex", "Admin");
        }
        [HttpGet]
        public IActionResult UpdateTeam(int id)
        {
            List<SelectListItem> valuecountry = (from x in cm.GetListCountry()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CountryName,
                                                     Value = x.CountryID.ToString()
                                                 }
                                                  ).ToList();
            ViewBag.country = valuecountry;

            List<SelectListItem> valueleague = (from x in lm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.LeagueName,
                                                    Value = x.LeagueID.ToString()
                                                }
                                                  ).ToList();
            ViewBag.league = valueleague;



            var values = tm.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateTeam(Team p)
        {
            tm.UpdateTeam(p);
            return RedirectToAction("TeamIndex", "Admin");
        }
        [HttpGet]
        public IActionResult UpdateLeague(int id)
        {
            var values = lm.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateLeague(League p)
        {
            lm.UpdateLeague(p);
            return RedirectToAction("LeagueIndex", "Admin");
        }

        [HttpGet]
        public IActionResult UpdateBlog(int id)
        {
            var c = new Context();
            List<SelectListItem> valueblog = (from x in wm.GetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.WriterName + " " + x.WriterSurname,
                                                  Value = x.WriterID.ToString()
                                              }
                                                  ).ToList();
            ViewBag.blog = valueblog;
            ViewBag.pp = c.Blogs.Where(x => x.BlogID == id).Select(y => y.BlogImage).FirstOrDefault();
            var values = blgm.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateBlog(Blog p)
        {

            p.BlogStatus = true;
            blgm.UpdateBlog(p);
            return RedirectToAction("BlogIndex", "Admin");
        }

        [HttpGet]
        public IActionResult UpdateWriter(int id)
        {
            var c = new Context();
            List<SelectListItem> valuecountry = (from x in cm.GetListCountry()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CountryName,
                                                     Value = x.CountryID.ToString()
                                                 }
                                                  ).ToList();
            ViewBag.country = valuecountry;

            ViewBag.pp = c.Writers.Where(x => x.WriterID == id).Select(y => y.WriterImage).FirstOrDefault();

            var values = wm.GetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateWriter(Writer p)
        {
            p.WriterCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterStatus = true;
            wm.UpdateWriter(p);
            return RedirectToAction("WriterIndex", "Admin");
        }

        public IActionResult DeletePlayer(int id)
        {
            var playervalue = pm.GeyByID(id);
            pm.DeletePlayer(playervalue);
            return RedirectToAction("Index", "Admin");
        }

        public IActionResult DeleteSkill(int id)
        {
            var skillvalue = sm.GetByID(id);
            sm.DeleteSkill(skillvalue);
            return RedirectToAction("SkillIndex", "Admin");
        }

        public IActionResult DeleteTeam(int id)
        {
            var teamvalue = tm.GetByID(id);
            tm.DeleteTeam(teamvalue);
            return RedirectToAction("TeamIndex", "Admin");
        }

        public IActionResult DeleteLeague(int id)
        {
            var leaguevalue = lm.GetByID(id);
            lm.DeleteLeague(leaguevalue);
            return RedirectToAction("LeagueIndex", "Admin");
        }

        public IActionResult DeleteBlog(int id)
        {
            var blogvalue = blgm.GetByID(id);
            blgm.DeleteBlog(blogvalue);
            return RedirectToAction("BlogIndex", "Admin");
        }
        public IActionResult DeleteWriter(int id)
        {
            var writervalue = wm.GetByID(id);
            wm.DeleteWriter(writervalue);
            return RedirectToAction("WriterIndex", "Admin");
        }

        public IActionResult DeleteAdmin(int id)
        {
            var adminvalue = am.GetByID(id);
            am.DeleteAdmin(adminvalue);
            return RedirectToAction("AdminIndex", "Admin");
        }
    }
}
