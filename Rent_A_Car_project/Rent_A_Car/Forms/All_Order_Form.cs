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
    public partial class All_Order_Form : Form
    {
        private RentACarEntities2 db;
        public All_Order_Form()
        {
            InitializeComponent();
            this.db = new RentACarEntities2();
            FillOrderGrid();
        }
      

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Update_or_Delete_All_Orders up_Or_De = new Update_or_Delete_All_Orders();
           // up_Or_De.All_Order = this;
            up_Or_De.Show();

            up_Or_De.orderId = Convert.ToInt32(dgv_fill_order.Rows[e.RowIndex].Cells[0].Value);

            string client = dgv_fill_order.Rows[e.RowIndex].Cells[2].Value.ToString();
            string number = dgv_fill_order.Rows[e.RowIndex].Cells[5].Value.ToString();
            DateTime start =Convert.ToDateTime( dgv_fill_order.Rows[e.RowIndex].Cells[7].Value);
            DateTime end = Convert.ToDateTime(dgv_fill_order.Rows[e.RowIndex].Cells[8].Value);

            DateTime over = DateTime.Now;
           decimal days= Convert.ToDecimal( dgv_fill_order.Rows[e.RowIndex].Cells[10].Value);
            up_Or_De.Fill_Update_or_Delete_All_Orders(client,number, start, end, over, days);
            this.Close();
        }
        public void FillOrderGrid()
        {
            dgv_fill_order.Rows.Clear();
            foreach (Orders o in db.Orders.ToList())
            {
                dgv_fill_order.Rows.Add(o.Id, o.ClientId, o.ClientInfo != null ? o.ClientInfo.ClientName : "",
                    o.ClientInfo != null ? o.ClientInfo.ClientSurname : "", o.CarInfoId,
                o.CarInfo != null ? o.CarInfo.CarNumber:"",o.AddedDate.Value!=null? o.AddedDate.Value.ToString("dd.MM.yyyy"):"",
                o.Startdate.Value != null ? o.Startdate.Value.ToString("dd.MM.yyyy") : "", o.EndDate.Value != null ? o.EndDate.Value.ToString("dd.MM.yyyy") : "",
               o.OverDate.Value != null ? o.OverDate.Value.ToString("dd.MM.yyyy") : "",o.Days, o.LateTime, o.SumPrice!=null?o.SumPrice.Value.ToString("0.00"):"", o.LatePrice!=null?o.LatePrice.Value.ToString("0.00"):"");
            }
        }
    }
}
