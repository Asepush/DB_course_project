using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Product
    {
        private int id;
        private string name;
        private double price;
        private int id_productType;

        public Product(int id, string name, double price, int id_productType)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.id_productType = id_productType;
        }

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Id_productType { get => id_productType; set => id_productType = value; }
        public int Id { get => id; set => id = value; }

        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   id == product.id &&
                   name == product.name &&
                   price == product.price &&
                   id_productType == product.id_productType;
        }
    }
}
