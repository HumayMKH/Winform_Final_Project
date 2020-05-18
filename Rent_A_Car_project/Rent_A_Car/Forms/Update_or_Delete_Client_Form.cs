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
    
    public partial class Update_or_Delete_Client_Form : Form
    {
        private RentACarEntities2 db;
        public int clientId { get; set; }
       // public Client_Form client_Form;
        public Update_or_Delete_Client_Form()
        {
            InitializeComponent();
            this.db = new RentACarEntities2();
        }
        public void Fill_Update_or_Delete_Form(string fname, string lname, decimal age,
            string passport, string phone, string email, string address)
        {
            txt_client_upd_name.Text = fname;
            txt_client_upd_surname.Text = lname;
            txt_client_upd_passport.Text = passport;
            num_upd_age.Value = age;
            txt_client_upd_email.Text = email;
            txt_client_upd_phone.Text = phone;
            rtb_upd_client.Text = address;
        }

        private void btn_update_client_Click(object sender, EventArgs e)
        {
            ClientInfo client = db.ClientInfo.Find(clientId);
            if (!string.IsNullOrWhiteSpace(txt_client_upd_name.Text) && !string.IsNullOrWhiteSpace(txt_client_upd_passport.Text)
            && !string.IsNullOrWhiteSpace(txt_client_upd_phone.Text) && !string.IsNullOrWhiteSpace(rtb_upd_client.Text))
            {
                client.ClientName = txt_client_upd_name.Text;
                client.ClientSurname = txt_client_upd_surname.Text;
                client.ClientAge = Convert.ToInt32(num_upd_age.Value);
                client.ClientPassportNumber = txt_client_upd_passport.Text;
                client.ClientPhone = txt_client_upd_phone.Text;
                client.ClientEmail = txt_client_upd_email.Text;
                client.ClientAddress = rtb_upd_client.Text;

                db.SaveChanges();
                MessageBox.Show("Müştəri məlumatları uğurla yeniləndi!");
               // client_Form.FillCientGrid();
                this.Close();
                Client_Form clients = new Client_Form();
                clients.Show();
            }
            else
            {
                MessageBox.Show("Ulduzla işarələnmiş xanaları boş saxlamayın!");
            }
        }

        private void btn_delete_client_Click(object sender, EventArgs e)
        {
            ClientInfo client = db.ClientInfo.Find(clientId);
            db.ClientInfo.Remove(client);
            db.SaveChanges();
           // client_Form.FillCientGrid();
            MessageBox.Show("Müştəri uğurla silindi!");
            this.Close();
            Client_Form clients = new Client_Form();
            clients.Show();
        }
    }
}
