using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialScoutingNetwork.Models
{
    public class AddProfileImage
    {
        public int WriterID { get; set; }
        public string WriterUserName { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public IFormFile WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public string WriterAbout { get; set; }
        public string WriterTitle { get; set; }
        public DateTime WriterBirthDate { get; set; }
        public DateTime WriterCreateDate { get; set; }
        public string WriterAddress { get; set; }
        public int CountryID { get; set; }
        public bool WriterStatus { get; set; }
    }
}
