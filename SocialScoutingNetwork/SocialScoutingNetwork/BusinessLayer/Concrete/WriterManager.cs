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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void AddWriter(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        public void DeleteWriter(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public Writer GetByID(int id)
        {
            return _writerDal.GetByID(id);
        }
        public List<Writer> GetListWithAllAttribution()
        {
            return _writerDal.GetListWithAllAttribution();
        }
        public List<Writer> GetList()
        {
            return _writerDal.GetListAll();
        }
        public List<Writer> GetListWithAllAttribution2(int id)
        {
            return _writerDal.GetListWithAllAttribution2(x => x.WriterID == id);
        }

        public void UpdateWriter(Writer writer)
        {
            _writerDal.Update(writer);
        }
    }
}
