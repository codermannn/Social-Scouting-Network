using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TeamManager : ITeamService
    {
        ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public void AddTeam(Team team)
        {
            _teamDal.Insert(team);
        }

        public void DeleteTeam(Team team)
        {
            _teamDal.Delete(team);
        }

        public Team GetByID(int id)
        {
            return _teamDal.GetByID(id);
        }

        public List<Team> GetList()
        {
            return _teamDal.GetListAll();
        }

        public List<Team> GetListWithAllAttribution()
        {
            return _teamDal.GetListWithAllAttribution();
        }

        public void UpdateTeam(Team team)
        {
            _teamDal.Update(team);
        }
    }
}
