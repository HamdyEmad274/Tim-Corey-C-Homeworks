﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instantiated
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public Person(string FirstName, string LastName, Address Address)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
        }
    }
}
