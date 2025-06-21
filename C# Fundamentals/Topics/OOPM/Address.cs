using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.OOPM
{
    internal class Address(string addressLane, string city, string state, int pinCode)
    {
        public string AddressLane { get; set; } = addressLane;
        public string City { get; set; } = city;

        public string State { get; set; } = state;
        public int PinCode { get; set; } = pinCode;


        public void ShowAddress()
        {
            Console.WriteLine($"Address Lane: {AddressLane}  City: {City} State: {State} PinCode {PinCode}");
        }
    }


}
