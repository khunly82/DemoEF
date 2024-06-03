using DemoEF.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.BLL.Interfaces.Services
{
    public interface ISponsorService
    {
        void AddSponsor(Sponsor sponsor);
        IEnumerable<Sponsor> GetAll();
        Sponsor GetById(int sponsorId);
    }
}
