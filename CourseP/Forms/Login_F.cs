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
    public partial class Login_F : Form
    {
        Db Pub_db = new Db();
        public Login_F()
        {
            InitializeComponent();
        }

        private void login_enter_Click(object sender, EventArgs e)
        {
            Worker worker = Pub_db.checkLogin(login_login.Text.ToString(), login_pass.Text.ToString());
            if ( worker != null && worker.Id_post == 5 ) //Cook
            {
                Cook_F Form = new Cook_F(worker.Id_pub);
                this.Hide();
                Form.ShowDialog();
                
            }
            else if (worker != null && worker.Id_post == 2 ) //Barmen
            {
                Barmen_F Form = new Barmen_F(worker.Id_pub);
                this.Hide();
                Form.ShowDialog();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Username or Password is incorrect", "Login Fail");
            }
        }
    }


}
