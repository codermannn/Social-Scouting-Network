using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPlayerService
    {
        void AddPlayer(Player player);
        void DeletePlayer(Player player);
        void UpdatePlayer(Player player);
        List<Player> GetList();
        Player GeyByID(int id);
        List<Player> GetListWithAllAttribution();

    }
}
