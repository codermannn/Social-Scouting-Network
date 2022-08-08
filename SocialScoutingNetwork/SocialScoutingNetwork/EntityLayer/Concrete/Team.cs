using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string TeamCoach { get; set; }
        public int TeamValue { get; set; }
        public string TeamStatName { get; set; }
        public int TeamPlayerCount { get; set; }
        public string TeamDescription { get; set; }
        public int TeamFoundationYear { get; set; }
        public string TeamImage { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
        public int LeagueID { get; set; }
        public League League { get; set; }
        public List<Player> Players { get; set; }
       

    }
}
