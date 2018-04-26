using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAmGroot.Models
{
    public class Rocket
    {
        public int Caliber25 { get; set; }
        public int Caliber30 { get; set; }
        public int Caliber50 { get; set; }
        public string Shipstatus { get; set; }
        public bool Ready { get; set; }

        public Rocket()
        {
            Shipstatus = "empty";
        }
    }
}
