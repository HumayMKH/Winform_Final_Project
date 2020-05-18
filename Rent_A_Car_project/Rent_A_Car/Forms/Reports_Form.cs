using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using Rent_A_Car.Models;

namespace Rent_A_Car
{
    public partial class Reports_Form : Form
    {
        private RentACarEntities2 db;
        List<Orders> orders;
        public Reports_Form()
        {
            InitializeComponent();
            this.db = new RentACarEntities2();
            FillReports(db.Orders.ToList());
            FillClientR();
            FillNumberR();
        }
        public void FillReports(List<Orders> orders)
        {
            dgv_reports.Rows.Clear();
            foreach (Orders o in orders)
            {
                dgv_reports.Rows.Add(o.Id, o.ClientId, o.ClientInfo != null ? o.ClientInfo.ClientName : "",
                    o.ClientInfo != null ? o.ClientInfo.ClientSurname : "", o.CarInfoId,
                o.CarInfo != null ? o.CarInfo.CarNumber : "", o.AddedDate!=null ? o.AddedDate.Value.ToString("dd.MM.yyyy") : "",
                o.Startdate.Value != null ? o.Startdate.Value.ToString("dd.MM.yyyy") : "", o.EndDate.Value != null ? o.EndDate.Value.ToString("dd.MM.yyyy") : "",
               o.OverDate.Value != null ? o.OverDate.Value.ToString("dd.MM.yyyy") : "", o.Days, o.LateTime, o.SumPrice!=null?o.SumPrice.Value.ToString("0.00"):"",
               o.LatePrice!=null?o.LatePrice.Value.ToString("0.00"):"");
            }
        }
        private void FillClientR()
        {
            cb_rep_client.Items.Clear();
            cb_rep_client.Items.Add("All");
            cb_rep_client.SelectedItem = "All";
            foreach (ClientInfo item in db.ClientInfo.ToList())
            {
                cb_rep_client.Items.Add(item.ClientName);
            }
        }
        private void FillNumberR()
        {
            cb_rep_number.Items.Clear();
            cb_rep_number.Items.Add("All");
            cb_rep_number.SelectedItem = "All";
            foreach (CarInfo item in db.CarInfo.ToList())
            {
                cb_rep_number.Items.Add(item.CarNumber);
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            int? clientId = null;
            if (db.ClientInfo.FirstOrDefault(c => c.ClientName == cb_rep_client.Text) != null) 
            {
               clientId= db.ClientInfo.FirstOrDefault(c => c.ClientName == cb_rep_client.Text).Id;
            }
            int? carId = null;
            if (db.CarInfo.FirstOrDefault(c => c.CarNumber == cb_rep_number.Text) != null)
            {
                carId = db.CarInfo.FirstOrDefault(c => c.CarNumber == cb_rep_number.Text).Id;
            }
          

            List<Orders> orders = db.Orders.Where(n => (clientId!=null ? n.ClientId==clientId: true)
                                                  && (carId != null?n.CarInfoId==carId:true)
                                                  &&( n.Startdate.Value>=dtp_start_rep.Value )
                                                  &&( n.EndDate.Value<=dtp_end_rep.Value)).ToList();
            FillReports(orders);
        }
        private void DownloadToEXcel(List<Orders> orders)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Orders");
            ws.Row(1).Height = 5;
            ws.Column("A").Width = 0.5;
            ws.Range("B2:K2").Merge();
            ws.Row(2).Height = 30;
            ws.Column("B").Width = 20;
            ws.Column("C").Width = 20;
            ws.Column("D").Width = 20;
            ws.Column("E").Width = 14;
            ws.Column("F").Width = 14;
            ws.Column("G").Width = 14;
            ws.Column("H").Width = 14;
            ws.Column("I").Width = 14;
            ws.Column("J").Width = 10;
            ws.Column("K").Width = 10;

            ws.Range("B2:K2").Value = "Orders infomation";
            ws.Range("B2:K2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Range("B2:K2").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Range("B2:K2").Style.Border.BottomBorder = XLBorderStyleValues.DashDot;
            ws.Range("B2:K2").Style.Border.LeftBorder = XLBorderStyleValues.Dashed;
            ws.Range("B2:K2").Style.Border.RightBorder = XLBorderStyleValues.Dashed;
            ws.Range("B2:K2").Style.Border.TopBorder = XLBorderStyleValues.DashDot;
            ws.Range("B2:K2").Style.Fill.BackgroundColor = XLColor.Blue;
            ws.Range("B2:K2").Style.Font.FontColor = XLColor.White;
            ws.Range("B2:K2").Style.Font.Bold = true;

            ws.Cell("B3").Value = "Name";
            ws.Range("B3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Range("B3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Range("B3").Style.Fill.BackgroundColor = XLColor.Maroon;
            ws.Cell("B3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("B3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Range("B3").Style.Font.FontColor = XLColor.White;
            ws.Range("B3").Style.Font.Bold = true;

            ws.Cell("C3").Value = "Surname";
            ws.Range("C3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Range("C3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Range("C3").Style.Fill.BackgroundColor = XLColor.Maroon;
            ws.Cell("C3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("C3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Range("C3").Style.Font.FontColor = XLColor.White;
            ws.Range("C3").Style.Font.Bold = true;

            ws.Cell("D3").Value = "Number";
            ws.Range("D3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Range("D3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Range("D3").Style.Fill.BackgroundColor = XLColor.Maroon;
            ws.Cell("D3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("D3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Range("D3").Style.Font.FontColor = XLColor.White;
            ws.Range("D3").Style.Font.Bold = true;

            ws.Cell("E3").Value = "Start date";
            ws.Range("E3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Range("E3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Range("E3").Style.Fill.BackgroundColor = XLColor.Maroon;
            ws.Cell("E3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("E3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Range("E3").Style.Font.FontColor = XLColor.White;
            ws.Range("E3").Style.Font.Bold = true;

            ws.Cell("F3").Value = "End Date";
            ws.Range("F3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Range("F3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Range("F3").Style.Fill.BackgroundColor = XLColor.Maroon;
            ws.Cell("F3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("F3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Range("F3").Style.Font.FontColor = XLColor.White;
            ws.Range("F3").Style.Font.Bold = true;

            ws.Cell("G3").Value = "Over Date";
            ws.Range("G3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Range("G3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Range("G3").Style.Fill.BackgroundColor = XLColor.Maroon;
            ws.Cell("G3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("G3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Range("G3").Style.Font.FontColor = XLColor.White;
            ws.Range("G3").Style.Font.Bold = true;

            ws.Cell("H3").Value = "Days";
            ws.Range("H3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Range("H3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Range("H3").Style.Fill.BackgroundColor = XLColor.Maroon;
            ws.Cell("H3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("H3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Range("H3").Style.Font.FontColor = XLColor.White;
            ws.Range("H3").Style.Font.Bold = true;

            ws.Cell("I3").Value = "Late Days";
            ws.Range("I3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Range("I3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Range("I3").Style.Fill.BackgroundColor = XLColor.Maroon;
            ws.Cell("I3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("I3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Range("I3").Style.Font.FontColor = XLColor.White;
            ws.Range("I3").Style.Font.Bold = true;

            ws.Cell("J3").Value = "Price";
            ws.Range("J3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Range("J3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Range("J3").Style.Fill.BackgroundColor = XLColor.Maroon;
            ws.Cell("J3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("J3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("J3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("J3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Range("J3").Style.Font.FontColor = XLColor.White;
            ws.Range("J3").Style.Font.Bold = true;

            ws.Cell("K3").Value = "Late Price";
            ws.Range("K3").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            ws.Range("K3").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            ws.Range("K3").Style.Fill.BackgroundColor = XLColor.Maroon;
            ws.Cell("K3").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
            ws.Cell("K3").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
            ws.Cell("K3").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("K3").Style.Border.TopBorder = XLBorderStyleValues.Thin;
            ws.Range("K3").Style.Font.FontColor = XLColor.White;
            ws.Range("K3").Style.Font.Bold = true;
            int i = 4;
            foreach (Orders o in orders)
            {
                ws.Cell("B" + i + " ").Value =o. ClientInfo != null ? o.ClientInfo.ClientName : "";

                ws.Cell("B" + i + " ").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("B" + i + " ").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("B" + i + " ").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("B" + i + " ").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                //ws.Cell("B" + i + " ").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("B" + i + " ").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);


                ws.Cell("C" + i + " ").Value =o.ClientInfo != null ? o.ClientInfo.ClientSurname : "";
                ws.Cell("C" + i + " ").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("C" + i + " ").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("C" + i + " ").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("C" + i + " ").Style.Border.TopBorder = XLBorderStyleValues.Thin;
              //ws.Cell("C" + i + " ").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("C" + i + " ").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);


                ws.Cell("D" + i + " ").Value = o.CarInfo != null ? o.CarInfo.CarNumber : "";
                ws.Cell("D" + i + " ").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("D" + i + " ").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("D" + i + " ").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("D" + i + " ").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("D" + i + " ").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("D" + i + " ").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);


                ws.Cell("E" + i + " ").Value = o.Startdate.Value != null ? o.Startdate.Value.ToString("dd.MM.yyyy") : "";
                ws.Cell("E" + i + " ").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("E" + i + " ").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("E" + i + " ").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("E" + i + " ").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("E" + i + " ").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("E" + i + " ").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                ws.Cell("F" + i + " ").Value = o.EndDate.Value != null ? o.EndDate.Value.ToString("dd.MM.yyyy") : "";
                ws.Cell("F" + i + " ").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("F" + i + " ").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("F" + i + " ").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("F" + i + " ").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("F" + i + " ").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("F" + i + " ").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                ws.Cell("G" + i + " ").Value = o.OverDate.Value != null ? o.OverDate.Value.ToString("dd.MM.yyyy") : "";
                ws.Cell("G" + i + " ").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("G" + i + " ").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("G" + i + " ").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("G" + i + " ").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("G" + i + " ").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("G" + i + " ").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                ws.Cell("H" + i + " ").Value = o.Days ;
                ws.Cell("H" + i + " ").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("H" + i + " ").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("H" + i + " ").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("H" + i + " ").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("H" + i + " ").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("H" + i + " ").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                ws.Cell("I" + i + " ").Value = o.LateTime;
                ws.Cell("I" + i + " ").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("I" + i + " ").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("I" + i + " ").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("I" + i + " ").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("I" + i + " ").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("I" + i + " ").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                ws.Cell("J" + i + " ").Value = o.SumPrice != null ? o.SumPrice.Value.ToString("0.00") : "";
                ws.Cell("J" + i + " ").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("J" + i + " ").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("J" + i + " ").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("J" + i + " ").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("J" + i + " ").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("J" + i + " ").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                ws.Cell("K" + i + " ").Value = o.LatePrice != null ? o.LatePrice.Value.ToString("0.00") : "";
                ws.Cell("K" + i + " ").Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cell("K" + i + " ").Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                ws.Cell("K" + i + " ").Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cell("K" + i + " ").Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cell("K" + i + " ").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                ws.Cell("K" + i + " ").Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                i++;
            }
                wb.SaveAs(@"C:\Users\code\Desktop\Order Info.xlsx");
            MessageBox.Show("Məlumat excelə uğurla  yükləndi! ~C:Users\\code\\Desktop\\Order Info.xlsx");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.orders != null)
            {
                DownloadToEXcel(orders);
            }
            else
            {
                DownloadToEXcel(db.Orders.ToList());
            }
        }
    }
}
