using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SocialScoutingNetwork.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;



namespace SocialScoutingNetwork.Controllers
{
    public class WriterProfile : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        WriterManager wm = new WriterManager(new EfWriterRepository());
        CountryManager cm = new CountryManager(new EfCountryRepository());

        [Authorize]
        [HttpGet]
        public IActionResult Index(int id)
        {

            var username = User.Identity.Name;
            ViewBag.un = username;

            var c = new Context();

            var name = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterName).FirstOrDefault();
            var surname = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterSurname).FirstOrDefault();
            var tt = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterTitle).FirstOrDefault();
            ViewBag.i = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterID).FirstOrDefault();
            var pp = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterImage).FirstOrDefault();

            ViewBag.pp = pp;
            ViewBag.tt = tt;
            ViewBag.n = name;
            ViewBag.s = surname;
            
            var values = bm.GetListWithAllAttribution2(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Index(Blog p, AddBlogImage i, int id)
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

            var username = User.Identity.Name;
            ViewBag.un = username;

            var c = new Context();

            var name = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterName).FirstOrDefault();
            var surname = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterSurname).FirstOrDefault();
            var tt = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterTitle).FirstOrDefault();
            ViewBag.i = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterID).FirstOrDefault();
            var pp = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterImage).FirstOrDefault();

            ViewBag.pp = pp;
            ViewBag.tt = tt;
            ViewBag.n = name;
            ViewBag.s = surname;


            p.BlogStatus = true;
            p.BlogThumbnailImage = "";
            p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterID = ViewBag.i;

            bm.AddBlog(p);

            var values = bm.GetListWithAllAttribution2(id);
            return View(values);
        }


        public IActionResult WriterProfiles(int id)
        {
            var c = new Context();
            var username = c.Writers.Find(id).WriterName;
            var surname = c.Writers.Find(id).WriterSurname;
            var title = c.Writers.Find(id).WriterTitle;
            var pp = c.Writers.Find(id).WriterImage;

            ViewBag.pp = pp;
            ViewBag.un = username;
            ViewBag.sn = surname;
            ViewBag.tt = title;
            ViewBag.i = id;
            var values = bm.GetListWithAllAttribution2(id);
            return View(values);
        }

        [Authorize]
        [HttpGet]
        public IActionResult WriterSettings(int id)
        {
            var username = User.Identity.Name;
            ViewBag.un = username;

            var c = new Context();

            var name = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterName).FirstOrDefault();
            var surname = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterSurname).FirstOrDefault();
            var tt = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterTitle).FirstOrDefault();
            ViewBag.i = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterID).FirstOrDefault();
            var pp = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterImage).FirstOrDefault();
            var un = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterUserName).FirstOrDefault();
            var ct = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.Country.CountryName).FirstOrDefault();
            var ab = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterAbout).FirstOrDefault();
            var ad = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterAddress).FirstOrDefault();
            var ml = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterMail).FirstOrDefault();
            var dt = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterBirthDate).FirstOrDefault();
            var pass = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterPassword).FirstOrDefault();


            var s = (((DateTime)dt).ToString("dd.MM.yyyy"));

            ViewBag.pass = pass;
            ViewBag.dt = s;
            ViewBag.ab = ab;
            ViewBag.ad = ad;
            ViewBag.ml = ml;
            ViewBag.ct = ct;
            ViewBag.un = un;
            ViewBag.pp = pp;
            ViewBag.tt = tt;
            ViewBag.n = name;
            ViewBag.s = surname;

            List<SelectListItem> valuecountry = (from x in cm.GetListCountry()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CountryName,
                                                     Value = x.CountryID.ToString()
                                                 }
                                                  ).ToList();
            ViewBag.country = valuecountry;

            var values = wm.GetByID(ViewBag.i);
            return View(values);
        }

        [HttpPost]
        public IActionResult WriterSettings(Writer p)
        {
            var username = User.Identity.Name;
            ViewBag.un = username;

            var c = new Context();
            var pp = c.Writers.Where(x => x.WriterUserName == username).Select(y => y.WriterImage).FirstOrDefault();

            ViewBag.pp = pp;
            p.WriterImage = pp;

            wm.UpdateWriter(p);
            return RedirectToAction("WriterSettings","WriterProfile");
        }
    }
}
