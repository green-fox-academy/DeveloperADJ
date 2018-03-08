using System;
using System.Collections.Generic;
using System.Text;

namespace CA
{
    public class Tree
    {
        string name;
        double waterConsumption;
        int wateLevel;

        public Tree(string name, double waterConsumption, int wateLevel)
        {
            this.name = name;
            this.waterConsumption = waterConsumption;
            this.wateLevel = wateLevel;
        }

        public string GetName()
        {
            return name;
        }
    }
}
