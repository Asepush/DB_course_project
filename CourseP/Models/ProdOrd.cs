using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class ProdOrd
    {
        private int id;
        private int id_product;
        private int id_order;
        private double countProduct;

        public ProdOrd(int id, int id_product, int id_order, double countProduct)
        {
            this.id = id;
            this.id_product = id_product;
            this.id_order = id_order;
            this.countProduct = countProduct;
        }

        public int Id_product { get => id_product; set => id_product = value; }
        public int Id_order { get => id_order; set => id_order = value; }
        public double CountProduct { get => countProduct; set => countProduct = value; }
        public int Id { get => id; set => id = value; }

        public override bool Equals(object obj)
        {
            return obj is ProdOrd ord &&
                   id == ord.id &&
                   id_product == ord.id_product &&
                   id_order == ord.id_order &&
                   countProduct == ord.countProduct;
        }
    }
}
