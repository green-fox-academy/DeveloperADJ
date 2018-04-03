using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccounts
    {
        public List<BankAccount> animals = new List<BankAccount>{
            new BankAccount("Simba", "2000", "Lion", "https://i.pinimg.com/originals/e7/fa/fb/e7fafb0b1581a411b56d9edd2e4a6734.png", true, false),
            new BankAccount("Pumbaa", "0", "Warthog", "http://icons.iconarchive.com/icons/shwz/disney/128/pumbaa-icon.png"),
            new BankAccount("Timon", "0", "Meerkat", "http://icons.iconarchive.com/icons/shwz/disney/256/timon-icon.png"),
            new BankAccount("Ed", "5", "Hyena", "http://www.fordesigner.com/imguploads/Image/cjbc/zcool/png20080526/1211808789.png", false, true),
            new BankAccount("Zazu", "1500", "Bird", "http://www.fordesigner.com/imguploads/Image/cjbc/zcool/png20080526/1211808830.png", false, true)
        };

        public BankAccounts()
        {
        }
    }
}
