using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Country
    {
        [Key]
        public int CountryID { get; set; }
        public string CountryISO { get; set; }
        public string CountryName { get; set; }
        public string CountryNName { get; set; }
        public string CountryISO3 { get; set; }
        public int CountryNumCode { get; set; }
        public int CountryPhoneCode { get; set; }
        public List<Writer> Writers { get; set; }
        public List<Player> Players { get; set; }
        public List<Team> Teams { get; set; }

    }
}
