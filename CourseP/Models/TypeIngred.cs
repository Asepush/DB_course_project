using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class TypeIngred
    {
        private int id;
        private string measureUnits;

        public TypeIngred(int id, string measureUnits)
        {
            this.id = id;
            this.measureUnits = measureUnits;
        }

        public string MeasureUnits { get => measureUnits; set => measureUnits = value; }
        public int Id { get => id; set => id = value; }

        public override bool Equals(object obj)
        {
            return obj is TypeIngred ingred &&
                   id == ingred.id &&
                   measureUnits == ingred.measureUnits;
        }
    }
}
