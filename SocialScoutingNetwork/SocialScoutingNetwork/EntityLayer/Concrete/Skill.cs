using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Skill
    {
        [Key]
        public int SkillID { get; set; }
        public string SkillPlayerName { get; set; }
        public int Goal { get; set; }
        public int Assist { get; set; }
        public int BBC { get; set; }
        public int KeyPass { get; set; }
        public int ShootsOffTarget { get; set; }
        public int ShootsOnTarget { get; set; }
        public int RedCards { get; set; }
        public int YellowCards { get; set; }
        public int UnsuccessfulDribbling { get; set; }
        public int SuccesfulDribbling { get; set; }
        public int AerialDuelsWon { get; set; }
        public int AerialDuelsLost { get; set; }
        public int PossesionLost { get; set; }
        public int PossesionWon { get; set; }
        public int Penalties { get; set; }
        public int LongBall { get; set; }
        public int BenchMatch { get; set; }
        public int StartedMatch { get; set; }
        public int Rating { get; set; }
        public int MOTM { get; set; }
        public List<Player> Players { get; set; }


    }
}
