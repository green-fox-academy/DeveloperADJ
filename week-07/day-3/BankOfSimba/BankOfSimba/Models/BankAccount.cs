using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string Balance { get; private set; }
        public string AnimalType { get; private set; }
        public bool IsKing { get; private set; }
        public bool IsBadGuy { get; private set; }
        public string ImageURL { get; set; }

        public BankAccount(string name, string balance, string animalType, string imageURL, bool isKing = false, bool isBadGuy = false)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            ImageURL = imageURL;
            IsKing = isKing;
            IsBadGuy = isBadGuy;
        }

        public void IncreaseFunds()
        {
            double newBalance = Double.Parse(Balance);

            newBalance += IsKing ? 100 : 10;

            Balance = Convert.ToString(newBalance);
        }
    }
}
