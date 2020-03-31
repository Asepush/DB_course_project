using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Provider
    {
        private int id;
        private string company;
        private string address;
        private string phone;

        public Provider(int id, string company, string address, string phone)
        {
            this.id = id;
            this.company = company;
            this.address = address;
            this.phone = phone;
        }

        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Company { get => company; set => company = value; }
        public int Id { get => id; set => id = value; }

        public override bool Equals(object obj)
        {
            return obj is Provider provider &&
                   id == provider.id &&
                   company == provider.company &&
                   address == provider.address &&
                   phone == provider.phone;
        }
    }
}
