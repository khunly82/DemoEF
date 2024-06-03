using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Domain.Entities
{
    public class Training
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Team Team { get; set; } = null!;

    }
}
