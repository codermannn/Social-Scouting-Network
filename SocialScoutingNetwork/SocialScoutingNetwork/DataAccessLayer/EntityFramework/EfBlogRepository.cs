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
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithAllAttribution()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Writer).ToList();
            }
        }

        public List<Blog> GetListWithAllAttribution2(Expression<Func<Blog, bool>> filter)
        {
            using (var k = new Context())
            {
                return k.Set<Blog>().Include(x => x.Writer).Where(filter).ToList();
                //return k.Blogs.Include(x => x.Writer).ToList();
            }
        }
    }
}
