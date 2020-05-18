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
    public partial class Update_or_Delete_Form : Form
    {
        private RentACarEntities2 db;
        public int workerId { get; set; }
        //public Worker_Form worker_Form;
        public Update_or_Delete_Form()
        {
            InitializeComponent();
            this.db = new RentACarEntities2();
        }
        public void Fill_Update_or_Delete_Form(string fname,string lname,string uname
            ,string password,decimal age,string email,string phone,string address )
        {
            txt_workerupd_firstname.Text = fname;
            txt_workerupd_lastname.Text = lname;
            txt_workerupd_username.Text = uname;
            txt_workerupd_password.Text = password;
            num_age_worker_upd.Value = age;
            txt_workerupd_email.Text = email;
            txt_workerupd_phone.Text = phone;
            rtb_upd_worker.Text = address;
        }

        private void btn_update_worker_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_workerupd_firstname.Text) && !string.IsNullOrWhiteSpace(txt_workerupd_username.Text) &&
                !string.IsNullOrWhiteSpace(txt_workerupd_password.Text) && !string.IsNullOrWhiteSpace(txt_workerupd_phone.Text))
            {
                Worker worker = db.Worker.Find(workerId);

                worker.FirstName = txt_workerupd_firstname.Text;
                worker.Lastname = txt_workerupd_lastname.Text;
                worker.Username = txt_workerupd_username.Text;
                worker.Password = txt_workerupd_password.Text;
                worker.Age = Convert.ToInt32(num_age_worker_upd.Value);
                worker.Email = txt_workerupd_email.Text;
                worker.Address = rtb_upd_worker.Text;
                worker.Phone = txt_workerupd_phone.Text;

                db.SaveChanges();
                MessageBox.Show("İşçi məlumatları uğurla yeniləndi!");
              //  worker_Form.FillWorkerGrid();
                this.Close();
                Worker_Form workers = new Worker_Form();
                workers.Show();
            }
            else
            {
                MessageBox.Show("Ulduzla işarələnmiş xanaları boş saxlamayın!");
            }
        }
      
        private void btn_delete_worker_Click(object sender, EventArgs e)
        {
            Worker worker = db.Worker.Find(workerId);
            db.Worker.Remove(worker);
            db.SaveChanges();
            //worker_Form.FillWorkerGrid();
            MessageBox.Show("İşçi uğurla silindi!");
            this.Close();
            Worker_Form workers = new Worker_Form();
            workers.Show();
        }
    }
}
