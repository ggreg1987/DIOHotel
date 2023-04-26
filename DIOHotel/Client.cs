using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIOHotel
{
    internal class Client : Person
    {
        private int _credCard;

        public Client() {}

        public Client(string? name, string? lastName ,int credCard)
            : base(name,lastName)
        {
            _credCard = credCard;
        }

        public string CredCard
        {
            get
            {
                if(_credCard == 1)
                {
                    return "VISA";
                } else
                {
                    return "MASTER";
                }
            }
            set { }
        }
    }
}
