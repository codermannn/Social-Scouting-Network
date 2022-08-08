using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Player
    {
        [Key]
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public string PlayerSurname { get; set; }
        public int PlayerAge { get; set; }
        public int PlayerHeight { get; set; }
        public int PlayerWeight { get; set; }
        public string PlayerPositionISO { get; set; }
        public string PlayerPosition { get; set; }
        public string PlayerDescription { get; set; }
        public string PlayerClub { get; set; }
        public DateTime PlayerBirthDate { get; set; }
        public string PlayerManager { get; set; }
        public int PlayerValue { get; set; }
        public int PlayerNumber { get; set; }
        public bool PlayerStatus { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
        public int TeamID { get; set; }
        public Team Team { get; set; }
        public int LeagueID { get; set; }
        public League League { get; set; }
        public int SkillID { get; set; }
        public Skill Skill { get; set; }

    }
}
