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
    
    public partial class NewProduct_F : Form
    {
        Db Pub_db = new Db();
        int Pub_id;


        public NewProduct_F(int pub_id)
        {
            Pub_id = pub_id;
            InitializeComponent();

            Pub_db.GetAllprod_types().ForEach(elem => newProd_type.Items.Add(elem.Name));

            Pub_db.GetAllIngredients().ForEach(elem => newProd_ingreds.Items.Add(elem.Name));


        }

        private void newProd_drop_Click(object sender, EventArgs e)
        {
            newProd_ingreds.Items.Add(newProd_data[0, newProd_data.CurrentCell.RowIndex].Value);

            newProd_data.Rows.Remove(newProd_data.CurrentRow);
        }

        private void newProd_listAdd_Click(object sender, EventArgs e)
        {
            if (newProd_ingreds.Text.ToString() != "")
            {
                newProd_data.Rows.Add();
                int cnt = newProd_data.Rows.Count;
                newProd_data[0, cnt - 1].Value = newProd_ingreds.Text.ToString();
                newProd_data[1, cnt - 1].Value = newProd_ingredCount.Value;

                newProd_ingreds.Items.Remove(newProd_ingreds.SelectedItem);
                newProd_ingreds.Text = "";
                newProd_ingredCount.Value = newProd_ingredCount.Minimum;


            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Unknown product or its recipe", "Fail");
            }
        }

        private void newProd_add_Click(object sender, EventArgs e)
        {

            if (newProd_data.Rows.Count != 0)
            {
                Pub_db.Addproduct( new Product( 0, newProd_name.Text.ToString(), Convert.ToDouble(newProd_price.Value), Pub_db.GetTypeProdByName(newProd_type.Text.ToString()).Id) );

               
                Product thisProd = Pub_db.GetProductByName(newProd_name.Text.ToString());

                for (int i = 0; i < newProd_data.Rows.Count; i++)
                {
                    string temp = newProd_data[0, i].Value.ToString();
                    Pub_db.AddprodIngred(new ProdIngred(0, thisProd.Id, Pub_db.GetIngredientByName(temp).Id, Convert.ToDouble(newProd_data[1, i].Value)));

                }

                newProd_data.Rows.Clear();
                newProd_ingreds.Items.Clear();
                newProd_name.Text = "";
                newProd_type.Text = "";

                Pub_db.GetAllIngredients().ForEach(elem => newProd_ingreds.Items.Add(elem.Name));
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Choose Ingredients!", "Fail");
            }
        }
    }
}
