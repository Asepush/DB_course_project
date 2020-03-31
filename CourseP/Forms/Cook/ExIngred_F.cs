using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class ExIngred_F : Form
    {
        Db Pub_db = new Db();
        int Pub_id;
        public ExIngred_F(int pub_id)
        {
            Pub_id = pub_id;
            InitializeComponent();

            List<Ingredient> products = Pub_db.GetAllIngredients();
            foreach (Ingredient prod in products)
            {
                ExIngred_name.Items.Add(prod.Name);

            }
        }

        private void ExIngred_add_Click(object sender, EventArgs e)
        {
            Ingredient ingred = Pub_db.GetIngredientByName(ExIngred_name.Text.ToString());

            Pub_db.AddPubIngred( new Pub_ingred(0, Pub_id, ingred.Id, Convert.ToDouble(ExIngred_count.Value) ) );


            ExIngred_name.Text = "";
            ExIngred_count.Value = ExIngred_count.Minimum;

            System.Windows.Forms.MessageBox.Show("Ingredient adding is successful", "Add Ingredient");
        }
    }
}
