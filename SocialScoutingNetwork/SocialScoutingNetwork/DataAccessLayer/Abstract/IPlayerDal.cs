using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IPlayerDal : IGenericDal<Player>
    {
        List<Player> GetListWithAllAttribution();
        List<Player> GetListWithAllAttribution2(Expression<Func<Player, bool>> filter);
    }
}
