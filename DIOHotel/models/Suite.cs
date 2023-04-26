using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIOHotel.models
{
    internal class Suite
    {
        public string? SuiteName { get; set; }
        public string? Capacity { get; set; }
        public decimal DailyValue { get; set; }

        public Suite() { }

        public Suite(string? suiteName, string? capacity, decimal dailyValue)
        {
            SuiteName = suiteName;
            Capacity = capacity;
            DailyValue = dailyValue;
        }
    }
}
