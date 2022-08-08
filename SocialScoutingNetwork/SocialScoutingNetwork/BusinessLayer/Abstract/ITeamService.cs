using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITeamService
    {
        void AddTeam(Team team);
        void DeleteTeam(Team team);
        void UpdateTeam(Team team);
        List<Team> GetList();
        Team GetByID(int id);
        List<Team> GetListWithAllAttribution();
    }
}
