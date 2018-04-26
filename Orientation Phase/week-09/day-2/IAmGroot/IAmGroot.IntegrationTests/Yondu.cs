using System;
using System.Collections.Generic;
using System.Text;

namespace IAmGroot.IntegrationTests
{
    class Yondu
    {
        public double Distance { get; set; }
        public double Time { get; set; }
        public double Speed { get; set; }

        public Yondu()
        {
            Speed = Distance / Time;
        }
    }
}
