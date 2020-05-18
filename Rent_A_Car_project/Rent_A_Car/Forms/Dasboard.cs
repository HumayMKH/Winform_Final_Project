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
    public partial class Dasboard : Form
    {
        private bool? isAdmin;

        private RentACarEntities2 db;
        public Dasboard(bool? IsAdmin)
        {
            InitializeComponent();
            this.db = new RentACarEntities2();
            FillOrderGrid();
            this.isAdmin = IsAdmin;

            if (IsAdmin == false)
            {
                menuStrip2.Items[0].Visible = false;
            }
        }

        private void btn_new_order_Click(object sender, EventArgs e)
        {
            New_Order new_Order = new New_Order();
            new_Order.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Worker_Form worker_Form = new Worker_Form();
            worker_Form.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Client_Form client_Form = new Client_Form();
            client_Form.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Cars_Form cars_Form = new Cars_Form();
            cars_Form.Show();
        }

        private void btn_old_order_Click(object sender, EventArgs e)
        {
            All_Order_Form all_Order = new All_Order_Form();
            all_Order.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Reports_Form reports = new Reports_Form();
            reports.Show();
        }
        public void FillOrderGrid()
        {
            dgv_fill_order.Rows.Clear();
            foreach (Orders o in db.Orders.OrderByDescending(b => b.AddedDate).Take(10).ToList())
            {
                dgv_fill_order.Rows.Add(o.Id, o.ClientId, o.ClientInfo != null ? o.ClientInfo.ClientName : "",
                    o.ClientInfo != null ? o.ClientInfo.ClientSurname : "", o.CarInfoId,
                o.CarInfo != null ? o.CarInfo.CarNumber : "",o.AddedDate!=null? o.AddedDate.Value.ToString("dd.MM.yyyy") : "",
                o.Startdate.Value != null ? o.Startdate.Value.ToString("dd.MM.yyyy") : "", o.EndDate.Value != null ? o.EndDate.Value.ToString("dd.MM.yyyy") : "",
               o.OverDate.Value != null ? o.OverDate.Value.ToString("dd.MM.yyyy") : "", o.Days, o.LateTime, o.SumPrice!=null ? o.SumPrice.Value.ToString("0.00"):"",
               o.LatePrice!=null?o.LatePrice.Value.ToString("0.00"):"");
            }
        }
    }
}
