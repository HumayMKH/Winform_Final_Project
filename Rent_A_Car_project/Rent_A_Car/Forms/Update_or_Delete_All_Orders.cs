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
    public partial class Update_or_Delete_All_Orders : Form
    {
        private RentACarEntities2 db;
        public int orderId { get; set; }
        //public All_Order_Form All_Order;

        public Update_or_Delete_All_Orders()
        {
            InitializeComponent();
            this.db = new RentACarEntities2();
            FillClient1();
            FillNumber();
           
        }

        private void FillClient1()
        {
            cb_order_client1.Items.Clear();
            cb_order_client1.Items.Add("All");
            cb_order_client1.SelectedItem = "All";
            foreach (ClientInfo item in db.ClientInfo.ToList())
            {
                cb_order_client1.Items.Add(item.ClientName);
            }
        }
        private void FillNumber()
        {
            cb_upd_number.Items.Clear();
            cb_upd_number.Items.Add("All");
            cb_upd_number.SelectedItem = "All";
            foreach (CarInfo item in db.CarInfo.ToList())
            {
                cb_upd_number.Items.Add(item.CarModel.CarBrand.BrandName+" "
                    +item.CarModel.ModelName+" "+item.CarNumber);
            }
        }

        public void Fill_Update_or_Delete_All_Orders(string client,
            string number,DateTime start,DateTime end,DateTime over,decimal days)
        {
            cb_order_client1.Text = client;           
            cb_upd_number.Text= number;
            dtp_start1.Value = start;
            dtp_end1.Value = end;
            dtp_over1.Value = over;
            num_upt_days.Value = days;
        }

        private void btn_order_upd_client_Click(object sender, EventArgs e)
        {
            Orders orders = db.Orders.Find(orderId);

            decimal? carpricedaily = null;
            decimal? carInfoPrice = null;

            if (db.ClientInfo.FirstOrDefault(c => c.ClientName == cb_order_client1.Text) != null
              && db.CarInfo.ToList().FirstOrDefault(c => c.CarNumber == cb_upd_number.Text.Split(' ').LastOrDefault()) != null
              && dtp_end1.Value > dtp_start1.Value && !string.IsNullOrWhiteSpace(num_upt_days.Value.ToString())
              && num_upt_days.Value != 0 /*&&*/ /*(dtp_end.Value - dtp_start.Value).Days==num_days.Value*/
              && dtp_over1.Value>=dtp_end1.Value)
            {
                    orders.ClientId = db.ClientInfo.FirstOrDefault(c => c.ClientName == cb_order_client1.Text).Id;
                    orders.CarInfoId = db.CarInfo.ToList().FirstOrDefault(c => c.CarNumber == cb_upd_number.Text.Split(' ').LastOrDefault()).Id;

                    carpricedaily = db.CarInfo.ToList().FirstOrDefault(c => c.CarNumber == cb_upd_number.Text.Split(' ').LastOrDefault()).DailyPrice;

                    orders.LatePrice = (((dtp_over1.Value - dtp_end1.Value).Days * carpricedaily) * 20 / 100) + ((dtp_over1.Value - dtp_end1.Value).Days * carpricedaily);
                    orders.Startdate = dtp_start1.Value.Date;
                    orders.EndDate = dtp_end1.Value.Date;
                    orders.LateTime = (dtp_over1.Value - dtp_end1.Value).Days;

                    orders.Days = Convert.ToInt32(num_upt_days.Value);
                    orders.OverDate = dtp_over1.Value.Date;
                    carInfoPrice = db.CarInfo.ToList().FirstOrDefault(c => c.CarNumber == cb_upd_number.Text.Split(' ').LastOrDefault()).DailyPrice;
                    orders.SumPrice = carInfoPrice * Convert.ToDecimal(orders.Days);

                    db.SaveChanges();
                    //All_Order.FillOrderGrid();
                    MessageBox.Show("Sifariş uğurla yeniləndi!");
                    this.Close();
                All_Order_Form all_order = new All_Order_Form();
                all_order.Show();
            }
            else
            {
                MessageBox.Show("Məlumatları düzgün qeyd edin!");
            }
        }

        private void btn_order_del_client_Click(object sender, EventArgs e)
        {
            Orders orders = db.Orders.Find(orderId);
            db.Orders.Remove(orders);
            db.SaveChanges();
           // All_Order.FillOrderGrid();
            MessageBox.Show("Sifariş uğurla silindi!");
            this.Close();
            All_Order_Form all_order = new All_Order_Form();
            all_order.Show();
        }
    }
}
