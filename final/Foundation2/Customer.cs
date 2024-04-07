using System;

namespace EncapsulationWithOnlineOrdering
{
    public class Customer
    {
        private string name;
        private Address address;

        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public bool IsInUSA()
        {
            return address.IsInUSA();
        }

        public string Name { get { return name; } }
        public Address Address { get { return address; } }
    }
}
