﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfTeamRepository : GenericRepository<Team>, ITeamDal
    {
        public List<Team> GetListWithAllAttribution()
        {
            using (var c = new Context())
            {
                return c.Teams.Include(x => x.Country).Include(x => x.League).ToList();
            }
        }
    }
}
