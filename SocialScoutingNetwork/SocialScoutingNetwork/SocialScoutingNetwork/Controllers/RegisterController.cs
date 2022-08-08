using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        CountryManager cm = new CountryManager(new EfCountryRepository()); 

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
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

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Index(Writer p,AddProfileImage i)
        {
            RegisterValidator rv = new RegisterValidator();
            ValidationResult results = rv.Validate(p);
            if (results.IsValid)
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

                p.WriterStatus = true;
                p.WriterAbout = "";
                p.WriterCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterAddress = "";
                wm.AddWriter(p);
                return RedirectToAction("Index", "Login");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

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
    }
}
