﻿using DemoEF.BLL.Interfaces.Repositories;
using DemoEF.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.DAL.Repositories
{
    public class SponsorRepository(DemoEFContext dbContext): ISponsorRepository
    {
        public void Add(Sponsor sponsor)
        {
            dbContext.Add(sponsor);
            dbContext.SaveChanges();
        }

        public IEnumerable<Sponsor> GetAll()
        {
            return dbContext.Set<Sponsor>().ToList();
        }

        public Sponsor? GetById(int sponsorId)
        {
            return dbContext.Set<Sponsor>().Find(sponsorId);
        }
    }
}
