using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Pub_ingred
    {
        private int id;
        private int id_pub;
        private int id_ingred;
        private double countLeft;

        public Pub_ingred(int id, int id_pub, int id_ingred, double countLeft)
        {
            this.id = id;
            this.id_pub = id_pub;
            this.id_ingred = id_ingred;
            this.countLeft = countLeft;
        }
        public int Id { get => id; set => id = value; }
        public int Id_pub { get => id_pub; set => id_pub = value; }
        public int Id_ingred { get => id_ingred; set => id_ingred = value; }
        public double CountLeft { get => countLeft; set => countLeft = value; }

        public override bool Equals(object obj)
        {
            return obj is Pub_ingred ingred &&
                   id == ingred.id &&
                   id_pub == ingred.id_pub &&
                   id_ingred == ingred.id_ingred &&
                   countLeft == ingred.countLeft;
        }
    }
}
