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
    public partial class New_Order : Form
    {
        private RentACarEntities2 db;
        public New_Order()
        {
            InitializeComponent();
            this.db = new RentACarEntities2();
            FillClient();
            FillNumber1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client_Form client_Form = new Client_Form();
            client_Form.Show();
            this.Close();
        }
        private void FillClient()
        {
            cb_order_client.Items.Clear();
            cb_order_client.Items.Add("All");
            cb_order_client.SelectedItem = "All";
            foreach (ClientInfo item in db.ClientInfo.ToList())
            {
                cb_order_client.Items.Add(item.ClientName);
            }
        }
        private void FillNumber1()
        {
            cb_number.Items.Clear();
            cb_number.Items.Add("All");
            cb_number.SelectedItem = "All";
            foreach (CarInfo item in db.CarInfo.ToList())
            {
                cb_number.Items.Add(item.CarModel.CarBrand.BrandName + " "
                    + item.CarModel.ModelName + " " + item.CarNumber);
            }
        }
       
        private void btn_order_add_client_Click(object sender, EventArgs e)
        {
          
            int? clientId = null;
            int? carInfoId = null;
            decimal? carInfoPrice = null;
            if (db.ClientInfo.FirstOrDefault(c => c.ClientName == cb_order_client.Text) != null
                && db.CarInfo.ToList().FirstOrDefault(c => c.CarNumber == cb_number.Text.Split(' ').LastOrDefault()) != null
                && dtp_end.Value>dtp_start.Value && !string.IsNullOrWhiteSpace(num_days.Value.ToString())
                && num_days.Value!=0 /*&&*/ /*(dtp_end.Value - dtp_start.Value).Days==num_days.Value*/)
            {
                Orders orders = new Orders();
                clientId = db.ClientInfo.FirstOrDefault(c => c.ClientName == cb_order_client.Text).Id;
                orders.ClientId = clientId;
                carInfoId = db.CarInfo.ToList().FirstOrDefault(c => c.CarNumber == cb_number.Text.Split(' ').LastOrDefault()).Id;
                orders.CarInfoId = carInfoId;

                orders.AddedDate = DateTime.Now;
                orders.Startdate = dtp_start.Value.Date;
                orders.EndDate = dtp_end.Value.Date;

                orders.Days = Convert.ToInt32(num_days.Value);

                carInfoPrice = db.CarInfo.ToList().FirstOrDefault(c => c.CarNumber == cb_number.Text.Split(' ').LastOrDefault()).DailyPrice;
                orders.SumPrice = carInfoPrice * Convert.ToDecimal(orders.Days);

                db.Orders.Add(orders);
                db.SaveChanges();
                MessageBox.Show("Sifariş uğurla qebul edildi!");
                this.Close();
                Reports_Form reports = new Reports_Form();
                reports.Show();
            }
            else
            {
                MessageBox.Show("Məlumatları düzgün qeyd edin!");
            }
        }

       
    }
}
