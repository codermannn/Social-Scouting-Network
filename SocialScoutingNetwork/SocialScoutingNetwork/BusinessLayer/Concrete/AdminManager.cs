﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void AddAdmin(Admin admin)
        {
            _adminDal.Insert(admin);
        }

        public void DeleteAdmin(Admin admin)
        {
            _adminDal.Delete(admin);
        }

        public Admin GetByID(int id)
        {
            return _adminDal.GetByID(id);
        }

        public List<Admin> GetList()
        {
            return _adminDal.GetListAll();
        }

        public void UpdateAdmin(Admin admin)
        {
            _adminDal.Update(admin);
        }
    }
}
