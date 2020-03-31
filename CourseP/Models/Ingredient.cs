using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Ingredient
    {
        private int id;
        private string name;
        private int id_provider;
        private int id_typeOfIngredient;

        public Ingredient(int id, string name,int id_provider, int id_typeOfIngredient)
        {
            this.Id = id;
            this.name = name;
            this.id_provider = id_provider;
            this.id_typeOfIngredient = id_typeOfIngredient;
        }

        public string Name { get => name; set => name = value; }
        public int Id_provider { get => id_provider; set => id_provider = value; }
        public int Id_typeOfIngredient { get => id_typeOfIngredient; set => id_typeOfIngredient = value; }
        public int Id { get => id; set => id = value; }

        public override bool Equals(object obj)
        {
            return obj is Ingredient ingredient &&
                   Id == ingredient.Id &&
                   name == ingredient.name &&
                   id_provider == ingredient.id_provider &&
                   id_typeOfIngredient == ingredient.id_typeOfIngredient;
        }
    }
}
