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
    public class PlayerService(IPlayerRepository playerRepository) : IPlayerService
    {
        public IEnumerable<Player> GetAll()
        {
            return playerRepository.GetAllWithTeam();
        }
    }
}
