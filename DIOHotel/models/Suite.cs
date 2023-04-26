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
        public string? Capacity { get; set; }
        public decimal DailyValue { get; set; }

        public Suite() { }

        public Suite(Suite suite)
        {
            this.suite = suite;
        }

        public Suite(string? suiteName, string? capacity, decimal dailyValue)
        {
            SuiteName = suiteName;
            Capacity = capacity;
            DailyValue = dailyValue;
        }


        public Suite SaveSuite(Suite suite)
        {
            return new Suite(suite);
        }
    }

   
}
