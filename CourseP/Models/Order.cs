using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Order
    {
        private int id;
        private DateTime time;
        private bool issued;
        private int idworker;

        public Order(int id, DateTime time, bool issued, int idworker)
        {
            this.id = id;
            this.time = time;
            this.issued = issued;
            this.idworker = idworker;
        }

        public DateTime Time { get => time; set => time = value; }
        public int Idworker { get => idworker; set => idworker = value; }
        public bool Issued { get => issued; set => issued = value; }
        public int Id { get => id; set => id = value; }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   id == order.id &&
                   time == order.time &&
                   issued == order.issued &&
                   idworker == order.idworker;
        }
    }
}
