using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Domain.Entities
{
    public class Sponsor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public byte[] Logo { get; set; } = null!;
        public string MimeType { get; set; } = null!;
        public ICollection<Team> Teams { get; set; } = [];
    }
}
