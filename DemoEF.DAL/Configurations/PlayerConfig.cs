using DemoEF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.DAL.Configurations
{
    internal class PlayerConfig : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(50);
            builder.Property(p => p.BirthDate).HasColumnType("DATE");
            builder.HasOne(p => p.Team)
                .WithMany(t => t.Players)
                .OnDelete(DeleteBehavior.SetNull);
            builder.HasIndex(p => p.Name).IsDescending();
            builder.HasIndex(p => new { p.Number, p.TeamId }).IsUnique();


#if DEBUG
            builder.HasData([
                    new Player{ Id = 1, Name= "Steve", BirthDate = new DateTime(2000,1,1) },
                new Player{ Id = 2, Name= "Mike", BirthDate = new DateTime(1982,3,14) },
            ]); 
#endif

        }
    }
}
