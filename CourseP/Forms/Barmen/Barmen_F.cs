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
    public partial class Barmen_F : Form
    {
        Db Pub_db = new Db();
        int Pub_id;
        List<Order> orders = new List<Order>();
        Timer myTimer = new Timer();

        public Barmen_F(int pub_id)
        {
            InitializeComponent();

            Pub_id = pub_id;

            orders = Pub_db.GetAllNonIssuedOrders(Pub_id);

            List<Product> products = Pub_db.GetAllproducts();
            foreach(Product prod in products)
            {
                barmen_product.Items.Add(prod.Name);
            }
            List<string> names = new List<string>();
            List<string> surnames = new List<string>();

            if( Pub_db.GetAllWaitersAndBarmens(Pub_id, names, surnames))
            {
                for (int i = 0; i < names.Count; i++)
                {
                    barmen_workers.Items.Add(names[i] + " " + surnames[i]);
                }
            }

            
            myTimer.Tick += (o, i) => CheckDb();
            myTimer.Tick += (o, i) => Console.WriteLine("Barmen Tick!!!!!!!");
            myTimer.Interval = 1000;
            myTimer.Start();

            Closed += (sender, args) => myTimer.Stop();
        }

        private void CheckDb()
        {
            List<Order> new_orders = Pub_db.GetAllNonIssuedOrders(Pub_id);

            bool isChanged = false;
            int id_changed;
            foreach(Order elem in orders)
            {
                if( !new_orders.Contains(elem))
                {
                    myTimer.Stop();
                    System.Windows.Forms.MessageBox.Show("Order №" + elem.Id.ToString() + " is ready!", "Order is ready!");
                    
                }
            }

            orders.Clear();
            orders = new_orders;
            myTimer.Start();
        }

        private void Barmen_F_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barmen_add_Click(object sender, EventArgs e)
        {
            if (barmen_product.Text.ToString() != "")
            {
                Product prod = Pub_db.GetProductByName(barmen_product.Text.ToString());

                List<double> cnt_need = new List<double>();
                List<double> cnt_left = new List<double>();


                if (Pub_db.GetIngredientsOfProduct(prod.Id, Pub_id, cnt_need, cnt_left))
                {
                    cnt_need.ForEach(value => value *= Convert.ToDouble(barmen_count.Value));
                    int len = cnt_need.Count;
                    bool res = true;
                    for (int i = 0; i < len; i++)
                    {
                        if (cnt_need[i] > cnt_left[i])
                        {
                            res = false;
                        }
                    }
                    if (res)
                    {
                        barmen_compos.Rows.Add();
                        int cnt = barmen_compos.Rows.Count;
                        barmen_compos[0, cnt - 1].Value = prod.Name;
                        barmen_compos[1, cnt - 1].Value = barmen_count.Value;
                        barmen_compos[2, cnt - 1].Value = prod.Price * Convert.ToDouble(barmen_count.Value);

                        barmen_product.Items.Remove(barmen_product.SelectedItem);
                        barmen_product.Text = "";
                        barmen_count.Value = barmen_count.Minimum;

                    }
                    else
                    {
                        barmen_product.Text = "";
                        barmen_count.Value = barmen_count.Minimum;
                        System.Windows.Forms.MessageBox.Show("Not enough ingredients for this product!", "Fail");

                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Unknown product or its recipe", "Fail");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Unknown product or its recipe", "Fail");
            }
        }

        private void barmen_create_Click(object sender, EventArgs e)
        {
            if (barmen_workers.Text.ToString() != "") {
                string[] work = barmen_workers.Text.ToString().Split(' ');

                DateTime ord_time = DateTime.Now;

                int ord_work = Pub_db.GetWorkerByName(work[0], work[1]).Id;

                Pub_db.Addorder(new Order(0, ord_time, false, ord_work));

                Order thisOrder = Pub_db.GetOrderByTimeWork(ord_time, false, ord_work);

                for (int i = 0; i < barmen_compos.Rows.Count; i++)
                {
                    string temp = barmen_compos[0, i].Value.ToString();
                    Pub_db.AddprodOrd(new ProdOrd(0, Pub_db.GetProductByName(temp).Id, thisOrder.Id, Convert.ToDouble(barmen_compos[1, i].Value)));

                    //из бд убрать ингридиенты
                }

                barmen_compos.Rows.Clear();
                barmen_product.Items.Clear();
                barmen_workers.Text = "";

                List<Product> products = Pub_db.GetAllproducts();
                foreach (Product prod in products)
                {
                    barmen_product.Items.Add(prod.Name);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Choose Worker!", "Fail");
            }
        }

        private void barmen_drop_Click(object sender, EventArgs e)
        {
            barmen_product.Items.Add(barmen_compos[0, barmen_compos.CurrentCell.RowIndex].Value);

            barmen_compos.Rows.Remove(barmen_compos.CurrentRow);
        }
    }
}
