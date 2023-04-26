using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIOHotel.models
{
    internal class Reserve
    {
        public List<Client>? Clients;

        public Suite? Suite;
        public int ReservedDays { get; set; }

        public Reserve() { }

        public Reserve(List<Client>? clients, Suite? suite, int reservedDays)
        {
            Clients = clients;
            Suite = suite;
            ReservedDays = reservedDays;
        }


    }
}
