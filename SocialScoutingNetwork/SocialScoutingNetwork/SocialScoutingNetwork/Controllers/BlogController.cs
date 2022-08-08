using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using SocialScoutingNetwork.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SocialScoutingNetwork.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        [HttpGet]
        public IActionResult Index()
        {
            var values = bm.GetListWithAllAttribution();
            return View(values);
        }

    
        [HttpPost]
        public IActionResult Index(Blog p, AddBlogImage i)
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
            p.BlogThumbnailImage = "";
            p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterID = 5;
            bm.AddBlog(p);
            return RedirectToAction("Index", "Blog");
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetListWithAllAttribution2(id);
            return View(values);
        }


    }
}
