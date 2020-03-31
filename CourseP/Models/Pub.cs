using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Lab4
{
    class Pub
    {
        private int id;
        private string address;
        private DateTime openTime;
        private DateTime closeTime;

        public Pub(int id, string address, DateTime openTime, DateTime closeTime)
        {
            this.id = id;
            this.address = address;
            this.openTime = openTime;
            this.closeTime = closeTime;
        }

        public string Address { get => address; set => address = value; }
        public DateTime OpenTime { get => openTime; set => openTime = value; }
        public DateTime CloseTime { get => closeTime; set => closeTime = value; }
        public int Id { get => id; set => id = value; }

        public override bool Equals(object obj)
        {
            return obj is Pub pub &&
                   id == pub.id &&
                   address == pub.address &&
                   openTime == pub.openTime &&
                   closeTime == pub.closeTime;
        }
    }
}
