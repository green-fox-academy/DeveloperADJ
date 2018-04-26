using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    abstract class StringedInstrument: Instrument
    {
        protected int numberOfStrings;

        public StringedInstrument(int numberOfStrings, string name):base(name)
        {
            this.numberOfStrings = numberOfStrings;
            this.name = name;
        }

        public abstract void Sound();
    }
}
