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
    public partial class NewIngred : Form
    {
        Db Pub_db = new Db();
        int Pub_id;
        public NewIngred(int pub_id)
        {
            Pub_id = pub_id;
            InitializeComponent();

            Pub_db.GetAlltypeIngreds().ForEach(elem => newIngred_measure.Items.Add(elem.MeasureUnits));

            Pub_db.GetAllproviders().ForEach(elem => newIngred_provider.Items.Add(elem.Company));
        }

        private void newIngred_add_Click(object sender, EventArgs e)
        {
            Pub_db.AddIngredient( new Ingredient( 0, newIngred_name.Text.ToString(), 
                Pub_db.GetProviderByName( newIngred_provider.Text.ToString() ).Id, 
                Pub_db.GetTypeIngredByName( newIngred_measure.Text.ToString() ).Id ) );

            newIngred_measure.Text = "";
            newIngred_name.Text = "";
            newIngred_provider.Text = "";

            System.Windows.Forms.MessageBox.Show("Ingredient adding is successful", "Add Ingredient");
        }
    }
}
