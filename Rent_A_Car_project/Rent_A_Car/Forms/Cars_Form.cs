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
    public partial class Cars_Form : Form
    {
        private RentACarEntities2 db;
        public Cars_Form()
        {
            InitializeComponent();
            this.db = new RentACarEntities2();
            FillCarBrand();
            FillCarColor();
            FillCarGrid(db.CarInfo.ToList());

        }

        private void dgv_Cars_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Update_or_Delete_Cars_Info cars = new Update_or_Delete_Cars_Info();
          //  cars.cars_form = this;
            cars.Show();

            cars.carId = Convert.ToInt32(dgv_Cars.Rows[e.RowIndex].Cells[0].Value);

            string brand = dgv_Cars.Rows[e.RowIndex].Cells[2].Value.ToString();
            string model = dgv_Cars.Rows[e.RowIndex].Cells[4].Value.ToString();
            string color = dgv_Cars.Rows[e.RowIndex].Cells[6].Value.ToString();
            string number = dgv_Cars.Rows[e.RowIndex].Cells[7].Value.ToString();
            decimal year =Convert.ToDecimal( dgv_Cars.Rows[e.RowIndex].Cells[8].Value);
            string tex = dgv_Cars.Rows[e.RowIndex].Cells[9].Value.ToString();
            decimal dailyprice =Convert.ToDecimal( dgv_Cars.Rows[e.RowIndex].Cells[10].Value);

            cars.Fill_Update_or_Delete_Cars_Info(brand, model, color, number, year, tex, dailyprice);
            this.Close();
        }
     
        private void FillCarColor()
        {
            cb_car_color.Items.Clear();
            cb_car_color.Items.Add("All");
            cb_car_color.SelectedItem = "All";
            foreach (CarColor item in db.CarColor.ToList())
            {
               cb_car_color.Items.Add(item.Color);
            }
        }
        private void FillCarBrand()
        {
            cb_car_brand.Items.Clear();
            cb_car_brand.Items.Add("All");
            cb_car_brand.SelectedItem = "All";
            foreach (CarBrand item in db.CarBrand.ToList())
            {
                cb_car_brand.Items.Add(item.BrandName);
            }
        }
        //private void cbMake_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cbModel.Items.Clear();
        //    Makes makes = new Makes();
        //    int makeId = makes.GetMakeIdByName(cbMake.Text);

        //    CarModels carModels = new CarModels();

        //    foreach (CarModelsModel carModel in carModels.ReadAllCarModels(makeId))
        //    {
        //        cbModel.Items.Add(carModel.Name);
        //    }
        //}
        private void FillCarModel()
        {
            cb_car_model.Items.Clear();
            cb_car_model.Items.Add("All");
            cb_car_model.SelectedItem = "All";
             int brandId;
            if (db.CarBrand.FirstOrDefault(m => m.BrandName == cb_car_brand.Text) != null)
            {
                brandId = db.CarBrand.FirstOrDefault(m => m.BrandName == cb_car_brand.Text).Id;

                foreach (CarModel item in db.CarModel.Where(m => m.CarBrandId == brandId).ToList())
                {
                    cb_car_model.Items.Add(item.ModelName);
                }
            }
           
        }
             private void cb_car_brand_SelectedIndexChanged(object sender, EventArgs e)
             {
            FillCarModel();
             }

        private void btn_add_car_Click(object sender, EventArgs e)
        {
            

            if (db.CarModel.FirstOrDefault(c => c.ModelName == cb_car_model.Text) != null
                && db.CarColor.FirstOrDefault(c => c.Color == cb_car_color.Text) != null
                && !string.IsNullOrWhiteSpace(txt_car_number.Text) &&
                !string.IsNullOrWhiteSpace(num_year.Value.ToString()) && num_year.Value!=0 &&
                !string.IsNullOrWhiteSpace(txt_car_tex.Text) &&
                !string.IsNullOrWhiteSpace(num_daily_price.Value.ToString()) && num_daily_price.Value != 0)
            {
                CarInfo car = new CarInfo();
                car.CarNumber = txt_car_number.Text;
                car.Year = Convert.ToInt32(num_year.Value);
                car.TexPassport = txt_car_tex.Text;
                car.DailyPrice = num_daily_price.Value;

                car.CarModelId = db.CarModel.FirstOrDefault(c => c.ModelName == cb_car_model.Text).Id;

                car.ColorId = db.CarColor.FirstOrDefault(c => c.Color == cb_car_color.Text).Id;
                

                db.CarInfo.Add(car);
                db.SaveChanges();
                FillCarGrid(db.CarInfo.ToList());
                MessageBox.Show("Maşın uğurla əlavə edildi!");
                ResetCAr();
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun!");
            }
        }
        public void FillCarGrid(List<CarInfo> carInfo)
        {
            dgv_Cars.Rows.Clear();
            foreach (CarInfo car in carInfo)
            {
                dgv_Cars.Rows.Add(car.Id, car.CarModel != null ? car.CarModel.CarBrandId.ToString() : "",
                    car. CarModel != null ? car.CarModel.CarBrand.BrandName:"",car.CarModelId,
                    car.CarModel!=null?car.CarModel.ModelName:"",car.ColorId,
                    car.CarColor!=null?car.CarColor.Color:"",car.CarNumber,car.Year,car.TexPassport,
                    car.DailyPrice!=null?car.DailyPrice.Value.ToString("0.00"):"");
            }
        }
        private void ResetCAr()
        {
            cb_car_brand.Text = cb_car_model.Text = cb_car_color.Text =
                txt_car_number.Text = txt_car_tex.Text = string.Empty;
            num_year.Value = num_daily_price.Value = 0;
        }
        
       
private void btn_search_Click(object sender, EventArgs e)
        {
            List<CarInfo> carInfo = db.CarInfo.Where(s => !string.IsNullOrEmpty(txt_search.Text) ? 
                                                     s.CarNumber.ToLower().Contains(txt_search.Text) : true).ToList();
            FillCarGrid(carInfo);
        }

    }
}
