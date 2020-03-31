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
    public partial class Cook_F : Form
    {
        int Pub_id;
        Db Pub_db = new Db();

        public Cook_F(int pub_id)
        {
            InitializeComponent();
            Pub_id = pub_id;

            var myTimer = new Timer();
            myTimer.Tick += (o, i) => FillCookList(false);
            myTimer.Tick += (o, i) => Console.WriteLine("Ticked!!!!!!!!!!!");
            myTimer.Interval = 1000;
            myTimer.Start();

            Closed += (sender, args) => myTimer.Stop();

        }

        private void FillCookList(bool afterDelete)
        {
            List<Order> orders = Pub_db.GetAllNonIssuedOrders(Pub_id);
            List<string> names = new List<string>();
            List<int> counts = new List<int>();

            int selected = 0;

            if (cook_list.Rows.Count != 0)
            {
                selected = cook_list.CurrentCell.RowIndex;
            }
                

            cook_list.Rows.Clear();


            for ( int i = 0; i < orders.Count; i++)
            {
                cook_list.Rows.Add();
                cook_list[0, i].Value = orders[i].Id;

                Pub_db.GetProductOfOrder(orders[i].Id, names, counts);

                string temp = "";
                for (int j = 0; j < names.Count; j++)
                {
                    temp += names[j] + "     " + counts[j].ToString() + "; \n";
                }

                cook_list[1, i].Value = temp;

                cook_list[2, i].Value = orders[i].Time.ToString();
            }

            if (cook_list.Rows.Count != 0 && !afterDelete)
            {
                DataGridViewCell cell = cook_list.Rows[selected].Cells[0];
                cook_list.CurrentCell = cell;
                cook_list.CurrentCell.Selected = true;
            }
        }


        private void Cook_F_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void cook_exIngred_Click(object sender, EventArgs e)
        {
            ExIngred_F Form = new ExIngred_F(Pub_id);
            Form.ShowDialog();
        }

        private void cook_newIngred_Click(object sender, EventArgs e)
        {
            NewIngred Form = new NewIngred(Pub_id);
            Form.ShowDialog();
        }

        private void cook_newProduct_Click(object sender, EventArgs e)
        {
            NewProduct_F Form = new NewProduct_F(Pub_id);
            Form.ShowDialog();
        }

        private void cook_ready_Click(object sender, EventArgs e)
        {
            if(cook_list.SelectedRows.Count == 1)
            {
                Order ord = Pub_db.GetorderById( Convert.ToInt32(cook_list[0, cook_list.CurrentCell.RowIndex].Value) );
                ord.Issued = true;
                Pub_db.Updateorder(ord);

                FillCookList(true);
            }
        }
    }
}
