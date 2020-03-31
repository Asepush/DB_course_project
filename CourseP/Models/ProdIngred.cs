using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class ProdIngred
    {
        private int id;
        private int id_product;
        private int id_ingredient;
        private double countIngredient;

        public ProdIngred(int id, int id_product, int id_ingredient, double countIngredient)
        {
            this.id = id;
            this.id_product = id_product;
            this.id_ingredient = id_ingredient;
            this.countIngredient = countIngredient;
        }

        public int Id_product { get => id_product; set => id_product = value; }
        public int Id_ingredient { get => id_ingredient; set => id_ingredient = value; }
        public double CountIngredient { get => countIngredient; set => countIngredient = value; }
        public int Id { get => id; set => id = value; }

        public override bool Equals(object obj)
        {
            return obj is ProdIngred ingred &&
                   id == ingred.id &&
                   id_product == ingred.id_product &&
                   id_ingredient == ingred.id_ingredient &&
                   countIngredient == ingred.countIngredient;
        }
    }
}
