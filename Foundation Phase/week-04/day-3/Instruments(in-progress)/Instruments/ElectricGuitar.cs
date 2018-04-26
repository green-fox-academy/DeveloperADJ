using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    class ElectricGuitar: StringedInstrument
    {
        public ElectricGuitar(int numberOfStrings = 6, string name = "Electric Guitar"):base(numberOfStrings, name)
        {
            this.numberOfStrings = numberOfStrings;
            this.name = name;
        }

        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override void Sound()
        {
            throw new NotImplementedException();
        }
    }
}
