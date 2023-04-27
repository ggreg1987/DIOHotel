using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIOHotel.models
{
    internal class Suite
    {
        private Suite suite;

        public string? SuiteName { get; set; }
        public int Capacity { get; set; }
        public decimal DailyValue { get; set; }

        public Suite() { }

        public Suite(Suite suite)
        {
            this.suite = suite;
        }

        public Suite(string? suiteName, int capacity, decimal dailyValue)
        {
            SuiteName = suiteName;
            Capacity = capacity;
            DailyValue = dailyValue;
        }


        public Suite SaveSuite(Suite suite)
        {
            return new Suite(suite);
        }

        public string ShowSuite
        {
            get
            {
                return $"Name: {SuiteName} \n" +
                    $"Capacity: {Capacity} \n" +
                    $"Daily: {DailyValue} \n" +
                    $"--------------------------------------------------";
            }
        }
    }
   
}
