using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class League
    {
        [Key]
        public int LeagueID { get; set; }
        public string LeagueName { get; set; }
        public int LeagueValue { get; set; }
        public int LeagueTeamCount { get; set; }
        public int LeagueFoundationYear { get; set; }
        public string LeagueDescription { get; set; }
        public List<Player> Players { get; set; }
        public List<Team> Teams { get; set; }

    }
}
