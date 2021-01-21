using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDriversAndResults.Models
{
    public class Driver
    {
        public long DriverId { get; set; }
        public string FullName { get; set; }        
        public Enums.Country Country { get; set; }

        public List<DCResult> DCResults { get; set; }
    }
}
