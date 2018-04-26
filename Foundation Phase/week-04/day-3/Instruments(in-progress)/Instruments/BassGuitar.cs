using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    class BassGuitar: StringedInstrument
    {
        public BassGuitar(int numberOfStrings = 4, string name = "Bass Guitar"): base(numberOfStrings, name)
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
