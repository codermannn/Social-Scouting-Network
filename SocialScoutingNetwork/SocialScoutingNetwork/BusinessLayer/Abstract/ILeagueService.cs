using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILeagueService
    {
        void AddLeague(League league);
        void DeleteLeague(League league);
        void UpdateLeague(League league);
        List<League> GetList();
        League GetByID(int id);
        List<League> GetListWithAllAttribution();
    }
}
