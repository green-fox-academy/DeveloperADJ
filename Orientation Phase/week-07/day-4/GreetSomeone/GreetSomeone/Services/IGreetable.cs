﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeone.Services
{
    public interface IGreetable
    {
        string Greet(string name);
    }
}
