using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDriversAndResults.Models
{
    public class DCResult
    {
        public long DriverId { get; set; }
        public long ChampionshipId { get; set; }
        public int Place { get; set; }
        public int Points { get; set; }
        public int Wins { get; set; }
        public Enums.Team Team { get; set; }

        public virtual Driver Driver { get; set; }
        public virtual Championship Championship { get; set; }
    }
}
