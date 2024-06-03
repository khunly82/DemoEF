using DemoEF.BLL.Interfaces.Repositories;
using DemoEF.BLL.Interfaces.Services;
using DemoEF.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.BLL.Services
{
    public class SponsorService(ISponsorRepository sponsorRepository) : ISponsorService
    {
        public void AddSponsor(Sponsor sponsor)
        {
            sponsorRepository.Add(sponsor);
        }

        public IEnumerable<Sponsor> GetAll()
        {
            return sponsorRepository.GetAll();
        }

        public Sponsor GetById(int sponsorId)
        {
            Sponsor? sponsor = sponsorRepository.GetById(sponsorId);
            if (sponsor is null)
            {
                throw new KeyNotFoundException();
            }
            return sponsor;
        }
    }
}
