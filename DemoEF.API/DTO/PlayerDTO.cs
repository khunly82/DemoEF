using DemoEF.Domain.Entities;
using System.Runtime.CompilerServices;

namespace DemoEF.API.DTO
{
    public class PlayerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int? TeamId { get; set; }
        public short? Number { get; set; }
        public string? TeamName { get; set; }
        public int Age 
        {
            get {
                int age = DateTime.Now.Year - BirthDate.Year;
                if (DateTime.Now < new DateTime(DateTime.Now.Year, BirthDate.Month, BirthDate.Day))
                {
                    age--;
                }
                return age;
            }   
        }
        public PlayerDTO(Player player)
        {
            Id = player.Id;
            Name = player.Name;
            BirthDate = player.BirthDate;
            Number = player.Number;
            TeamId = player.TeamId;
            TeamName = player.Team?.Name;
        }
    }
}
