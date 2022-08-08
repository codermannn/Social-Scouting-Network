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
    public class EfWriterRepository : GenericRepository<Writer>, IWriterDal
    {
        public List<Writer> GetListWithAllAttribution()
        {
            using (var c = new Context())
            {
                return c.Writers.Include(x => x.Country).ToList();
            }
        }

        public List<Writer> GetListWithAllAttribution2(Expression<Func<Writer, bool>> filter)
        {
            using (var k = new Context())
            {
                return k.Set<Writer>().Include(x => x.Country).Where(filter).ToList();
                //return k.Blogs.Include(x => x.Writer).ToList();
            }
        }

       
    }
}
