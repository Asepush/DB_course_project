using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Prod_type
    {
        private int id;
        private string name;

        public Prod_type(int id, string name)
        {
            this.Id = id;
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }

        public override bool Equals(object obj)
        {
            return obj is Prod_type type &&
                   Id == type.Id &&
                   name == type.name;
        }
    }
}
