﻿using DemoEF.BLL.Interfaces.Repositories;
using DemoEF.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoEF.DAL.Repositories
{
    public class PlayerRepository(DemoEFContext dbContext) : IPlayerRepository
    {
        public IEnumerable<Player> GetAll()
        {
            // SELECT * FROM Player
            return dbContext.Set<Player>().ToList();
        }

        public IEnumerable<Player> GetAllWithTeam()
        {
            // SELECT * FROM Player p LEFT JOIN Team t ON t.Id = p.TeamId
            return dbContext.Set<Player>()
                .Include(p => p.Team).ToList();
        }

        public IEnumerable<Player> GetPlayerByTeam(int TeamId)
        {
            return dbContext.Set<Player>()
                .Where(p => p.TeamId == TeamId).ToList();
        }
    }
}
