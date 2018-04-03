using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; private set; }
        public string Balance { get; private set; }
        public string AnimalType { get; private set; }
        public bool IsKing { get; private set; }
        public bool IsBadGuy { get; private set; }

        public BankAccount(string name, string balance, string animalType, bool isKing = false, bool isBadGuy = false)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            IsKing = isKing;
            IsBadGuy = isBadGuy;
        }
    }
}
