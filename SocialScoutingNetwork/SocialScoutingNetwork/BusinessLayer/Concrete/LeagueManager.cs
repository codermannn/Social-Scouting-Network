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
    public class LeagueManager : ILeagueService
    {
        ILeagueDal  _leagueDal;

        public LeagueManager(ILeagueDal leagueDal)
        {
            _leagueDal = leagueDal;
        }

        public void AddLeague(League league)
        {
            _leagueDal.Insert(league);
        }

        public void DeleteLeague(League league)
        {
            _leagueDal.Delete(league);
        }

        public League GetByID(int id)
        {
            return _leagueDal.GetByID(id);
        }

        public List<League> GetList()
        {
            return _leagueDal.GetListAll();
        }

        public List<League> GetListWithAllAttribution()
        {
            throw new NotImplementedException();
        }

        public void UpdateLeague(League league)
        {
            _leagueDal.Update(league);
        }
    }
}
