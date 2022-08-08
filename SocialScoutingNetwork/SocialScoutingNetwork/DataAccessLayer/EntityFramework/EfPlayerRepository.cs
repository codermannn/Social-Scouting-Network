using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfPlayerRepository : GenericRepository<Player>, IPlayerDal
    {
        public List<Player> GetListWithAllAttribution()
        {
            using (var c = new Context())
            {
                return c.Players.Include(x => x.Country).Include(x => x.League).Include(x => x.Skill).Include(x => x.Team).ToList();
            }
        }

        public List<Player> GetListWithAllAttribution2(Expression<Func<Player, bool>> filter)
        {
            using (var k = new Context())
            {
                return k.Set<Player>().Include(x => x.Country).Include(x => x.League).Include(x => x.Skill).Include(x => x.Team).Where(filter).ToList();
                //return k.Blogs.Include(x => x.Writer).ToList();
            }
        }
    }
}
