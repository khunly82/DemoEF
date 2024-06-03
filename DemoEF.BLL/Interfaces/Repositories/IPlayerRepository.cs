using DemoEF.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.BLL.Interfaces.Repositories
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> GetAll();
        IEnumerable<Player> GetAllWithTeam();
    }
}
