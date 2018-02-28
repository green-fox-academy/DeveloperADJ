using System;

namespace FleetOfThings
{
    public class Thing
    {
        public string Name;
        public bool Completed;

        public Thing(string Name, bool Completed)
        {
            this.Name = Name;
            this.Completed = Completed;
        }

        public Thing(string name)
        {
            this.Name = name;
        }

        public void Complete()
        {
            this.Completed = true;
        }

    }
}