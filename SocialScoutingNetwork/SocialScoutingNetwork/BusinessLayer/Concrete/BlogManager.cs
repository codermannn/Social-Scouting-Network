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
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void AddBlog(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void DeleteBlog(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> GetListWithAllAttribution()
        {
            return _blogDal.GetListWithAllAttribution();
        }

        public Blog GetByID(int id)
        {
            return _blogDal.GetByID(id);
        }

        public List<Blog> GetListWithAllAttribution2(int id)
        {
            return _blogDal.GetListWithAllAttribution2(x => x.BlogID == id);
        }
        public List<Blog> GB(int id)
        {
            return _blogDal.GetListAll(x => x.BlogID == id);
        }
        public void UpdateBlog(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterID == id);
        }
    }
}
