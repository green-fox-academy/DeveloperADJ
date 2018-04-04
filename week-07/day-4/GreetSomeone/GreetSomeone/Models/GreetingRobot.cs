using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeone.Models
{
    public class GreetingRobot
    {
        public string Name { get; set; }
        public string Message { get; set; }

        public GreetingRobot(string Name = "", string Message = "What is your name?")
        {
            this.Name = Name;
            this.Message = Message;
        }
    }
}
