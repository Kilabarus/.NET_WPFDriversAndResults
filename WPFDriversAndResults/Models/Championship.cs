using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDriversAndResults.Models
{
    public class Championship
    {
        public long ChampionshipId { get; set; }
        public int Year { get; set; }
        public Enums.RacingSeries RacingSeries { get; set; }        

        public List<DCResult> DCResults { get; set; }
    }
}
