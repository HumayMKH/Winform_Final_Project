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
    public partial class Worker_Form : Form
    {
        private RentACarEntities2 db;
        public Worker_Form()
        {
            InitializeComponent();
            this.db = new RentACarEntities2();
            FillWorkerGrid(db.Worker.ToList());
        }

        private void dgv_workerlist_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Update_or_Delete_Form worker = new Update_or_Delete_Form();
         //   worker.worker_Form = this;
            worker.Show();

            worker.workerId= Convert.ToInt32(dgv_workerlist.Rows[e.RowIndex].Cells[0].Value);

            string fname= dgv_workerlist.Rows[e.RowIndex].Cells[1].Value.ToString();
            string lname= dgv_workerlist.Rows[e.RowIndex].Cells[2].Value.ToString();
            string uname= dgv_workerlist.Rows[e.RowIndex].Cells[3].Value.ToString();
            string password= dgv_workerlist.Rows[e.RowIndex].Cells[4].Value.ToString();
            decimal age = Convert.ToDecimal(dgv_workerlist.Rows[e.RowIndex].Cells[5].Value);
            string email= dgv_workerlist.Rows[e.RowIndex].Cells[6].Value.ToString();
            string address= dgv_workerlist.Rows[e.RowIndex].Cells[7].Value.ToString();
            string phone= dgv_workerlist.Rows[e.RowIndex].Cells[8].Value.ToString();

            worker.Fill_Update_or_Delete_Form(fname, lname, uname, password, age, email, address, phone);
        }

        private void btn_add_worker_Click(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrWhiteSpace(txt_firstname.Text) && !string.IsNullOrWhiteSpace(txt_username.Text) && 
                !string.IsNullOrWhiteSpace(txt_password.Text) && !string.IsNullOrWhiteSpace(txt_phone.Text))
            {
                if (db.Worker.FirstOrDefault(w => w.Username.Trim().ToLower() == txt_username.Text.Trim().ToLower()) == null)
                {
                    Worker worker = new Worker();
                    worker.FirstName = txt_firstname.Text;
                    worker.Lastname = txt_lastname.Text;
                    worker.Username = txt_username.Text;
                    worker.Password = txt_password.Text;
                    worker.Age = Convert.ToInt32(num_worker.Value);
                    worker.Email = txt_email.Text;
                    worker.Address = rb_worker.Text;
                    worker.Phone = txt_phone.Text;
                    worker.IsAdmin = false;
                    db.Worker.Add(worker);
                    db.SaveChanges();
                    FillWorkerGrid(db.Worker.ToList());
                    MessageBox.Show("İşçi uğurla əlavə edildi!");
                    Reset();
                }
                else
                {
                    MessageBox.Show("Username artıq mövcuddur!");
                }
            }
            else
            {
                MessageBox.Show("Ulduzla işarələnmiş xanaları boş saxlamayın!");
            }
        }
        public void Reset()
        {
            txt_firstname.Text = txt_lastname.Text = txt_username.Text = txt_password.Text=
                txt_email.Text = txt_phone.Text = rb_worker.Text = string.Empty;
            num_worker.Value = 0;
        }
        public void FillWorkerGrid(List<Worker> workers)
        {
            dgv_workerlist.Rows.Clear();
            foreach (Worker w in workers)
            {
                dgv_workerlist.Rows.Add(w.Id,w.FirstName,w.Lastname,w.Username,w.Password,
                w.Age,w.Email,w.Phone,w.Address,w.IsAdmin);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            List<Worker> workers = db.Worker.Where(w => (!string.IsNullOrEmpty(txt_search_worker.Text) ? w.FirstName.ToLower().Contains(txt_search_worker.Text) : true)
                                                   || (!string.IsNullOrEmpty(txt_search_worker.Text) ? w.Lastname.ToLower().Contains(txt_search_worker.Text) : true)
                                                   || (!string.IsNullOrEmpty(txt_search_worker.Text) ? w.Username.ToLower().Contains(txt_search_worker.Text) : true)
                                                   || (!string.IsNullOrEmpty(txt_search_worker.Text) ? w.Phone.ToLower().Contains(txt_search_worker.Text) : true)).ToList();
            FillWorkerGrid(workers);
        }
    }
}
