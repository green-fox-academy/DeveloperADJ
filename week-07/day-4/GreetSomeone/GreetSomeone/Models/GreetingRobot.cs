using GreetSomeone.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeone.Models
{
    public class GreetingRobot : IGreetable
    {
        public string Greet(string name)
        {
            return "Hello " + name;
        }
    }
}
