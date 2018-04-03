using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccounts
    {
        public List<BankAccount> animals = new List<BankAccount>{
            new BankAccount("Simba", "2000", "Lion", true, false),
            new BankAccount("Pumbaa", "0", "Warthog"),
            new BankAccount("Timon", "0", "Meerkat"),
            new BankAccount("Rafiki", "1000", "Mandrill"),
            new BankAccount("Nala", "1500", "Lioness")
        };

        public BankAccounts()
        {
        }
    }
}
