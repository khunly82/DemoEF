using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Domain.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public byte[]? Logo { get; set; }
        public string? MimeType { get; set; }
        public ICollection<Player> Players { get; set; } = [];
        public ICollection<Sponsor> Sponsors { get; set; } = [];
    }
}
