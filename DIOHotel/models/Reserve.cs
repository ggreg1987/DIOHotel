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

        public Client SaveClient(Client client)
        {
            var clients = new List<Client>();
            clients.Add(client);
            return client;
        }

        public List<Client>? AllClient()
        {
            return Clients;
        }

        public decimal TotalDaily(int days, decimal dailyValue)
        {
            if(days > 10)
            {
                return (days * dailyValue) - (days * dailyValue / 10);
            } 
            else
            {
                return dailyValue * days;
            }
        }

        public void CapacityRoom(int room, int people)
        {
            if(people > room)
            {
                throw new ArgumentException("Many people to the suite");
            }
        }
    }
}
