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
  
    public partial class Client_Form : Form
    {
        private RentACarEntities2 db;
        public Client_Form()
        {
            InitializeComponent();
            this.db = new RentACarEntities2();
            FillCientGrid(db.ClientInfo.ToList());
        }

        private void dgv_workerlist_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Update_or_Delete_Client_Form client = new Update_or_Delete_Client_Form();
          //  client.client_Form = this;
            client.Show();
           

            client.clientId = Convert.ToInt32(dgv_clientslist.Rows[e.RowIndex].Cells[0].Value);

            string fname = dgv_clientslist.Rows[e.RowIndex].Cells[1].Value.ToString();
            string lname = dgv_clientslist.Rows[e.RowIndex].Cells[2].Value.ToString();
            decimal age = Convert.ToDecimal(dgv_clientslist.Rows[e.RowIndex].Cells[3].Value);
            string passport = dgv_clientslist.Rows[e.RowIndex].Cells[4].Value.ToString();
            string phone = dgv_clientslist.Rows[e.RowIndex].Cells[5].Value.ToString();
            string email = dgv_clientslist.Rows[e.RowIndex].Cells[6].Value.ToString();
            string address = dgv_clientslist.Rows[e.RowIndex].Cells[7].Value.ToString();
           

            client.Fill_Update_or_Delete_Form(fname, lname, age, passport, phone, email, address);
            this.Close();
        }

        private void btn_add_client_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_client_name.Text) && !string.IsNullOrWhiteSpace(txt_client_passport.Text)
            && !string.IsNullOrWhiteSpace(txt_client__phone.Text) && !string.IsNullOrWhiteSpace(rb_address.Text))
            {
                ClientInfo client = new ClientInfo();
                client.ClientName = txt_client_name.Text;
                client.ClientSurname = txt_client__surname.Text;
                client.ClientAge = Convert.ToInt32(num_client.Value);
                client.ClientPassportNumber = txt_client_passport.Text;
                client.ClientPhone = txt_client__phone.Text;
                client.ClientEmail = txt_client_email.Text;
                client.ClientAddress = rb_address.Text;
                db.ClientInfo.Add(client);
                db.SaveChanges();
                FillCientGrid(db.ClientInfo.ToList());
                MessageBox.Show("Müştəri uğurla əlavə edildi!");
                Reset();
            }
            else
            {
                MessageBox.Show("Ulduzla işarələnmiş xanaları boş saxlamayın!");
            }
        }
        public void Reset()
        {
            txt_client_name.Text = txt_client__surname.Text = txt_client_passport.Text =
                txt_client__phone.Text = txt_client_email.Text = rb_address.Text = string.Empty;
            num_client.Value = 0;
        }
        public void FillCientGrid(List<ClientInfo> clients)
        {
            dgv_clientslist.Rows.Clear();
            foreach (ClientInfo c in clients)
            {
                dgv_clientslist.Rows.Add(c.Id, c.ClientName, c.ClientSurname, c.ClientAge,
                    c.ClientPassportNumber, c.ClientPhone, c.ClientEmail, c.ClientAddress);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            List<ClientInfo> clients = db.ClientInfo.Where(w => (!string.IsNullOrEmpty(txt_search_client.Text) ? w.ClientName.ToLower().Contains(txt_search_client.Text) : true)
                                                   || (!string.IsNullOrEmpty(txt_search_client.Text) ? w.ClientSurname.ToLower().Contains(txt_search_client.Text) : true)
                                                   || (!string.IsNullOrEmpty(txt_search_client.Text) ? w.ClientPassportNumber.ToLower().Contains(txt_search_client.Text) : true)
                                                   || (!string.IsNullOrEmpty(txt_search_client.Text) ? w.ClientPhone.ToLower().Contains(txt_search_client.Text) : true)).ToList();
            FillCientGrid(clients);
        }
    }
}
