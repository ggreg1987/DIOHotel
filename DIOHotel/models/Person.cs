﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIOHotel.models
{
    internal class Person
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }

        public Person() { }

        public Person(string? name, string? lastName)
        {
            Name = name;
            LastName = lastName;
        }
    }
}
