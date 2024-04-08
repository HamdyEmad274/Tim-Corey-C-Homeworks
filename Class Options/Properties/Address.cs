using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string FullAddress
        {
            get
            {
                return $"{StreetAddress} , {City} , {State} , {PostalCode}";
            }
            //by not creating set it means it's read only and vice versa means write only ^_^
        }
        public Address()
        {
        }
        public Address(string Streetaddress , string city , string state , string postalcode)
        {
            StreetAddress = Streetaddress;
            City = city;
            State = state;
            PostalCode= postalcode;
        }
    }
}
