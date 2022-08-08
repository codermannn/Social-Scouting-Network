using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PlayerManager : IPlayerService
    {
        IPlayerDal _playerDal;
        
        public PlayerManager(IPlayerDal playerDal)
        {
            _playerDal = playerDal;
        }

        public void AddPlayer(Player player)
        {
            _playerDal.Insert(player);
        }

        public void DeletePlayer(Player player)
        {
            _playerDal.Delete(player);
        }

        public List<Player> GetList()
        {
            return _playerDal.GetListAll();
        }

        public List<Player> GetListWithAllAttribution()
        {
            return _playerDal.GetListWithAllAttribution();
        }

        public List<Player> GetListWithAllAttribution2(int id)
        {
            return _playerDal.GetListWithAllAttribution2(x => x.PlayerID == id);
        }


        public Player GeyByID(int id)
        {
            return _playerDal.GetByID(id);
        }

        public void UpdatePlayer(Player player)
        {
            _playerDal.Update(player);
        }
    }
}
