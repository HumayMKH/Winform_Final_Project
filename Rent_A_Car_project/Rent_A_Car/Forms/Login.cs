using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rent_A_Car.Models;

namespace Rent_A_Car
{
    public partial class Login_form : Form
    {
        private RentACarEntities2 db;
       
        public Login_form()
        {
            InitializeComponent();
            this.db = new RentACarEntities2();
           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username_login.Text.ToLower(). Trim();
            string password = txt_password_login.Text.ToLower().Trim();
            Worker worker = db.Worker.FirstOrDefault(w => w.Username == username && w.Password == password);
            if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lbl_error.Text = "Zəhmət olmasa xanaları doldurun!";
            }
            else
            {
                if (worker != null)
                {
                    Dasboard dasboard=new Dasboard(worker.IsAdmin);
                    dasboard.Show();
                }
                else
                {
                    lbl_error.Text = "Şifrə və ya İstifadəçi adı səhvdir!";
                }
                txt_username_login.Text = "";
                txt_password_login.Text = "";
            }
        }

        private void txt_username_login_KeyUp(object sender, KeyEventArgs e)
        {
            lbl_error.Text = "";
        }

        private void txt_password_login_KeyUp(object sender, KeyEventArgs e)
        {
            lbl_error.Text = "";
        }

    }
}
