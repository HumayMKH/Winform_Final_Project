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
    public partial class Update_or_Delete_Cars_Info : Form
    {
        private RentACarEntities2 db;
        public int carId { get; set; }
       // public Cars_Form cars_form;

        public Update_or_Delete_Cars_Info()
        {
            InitializeComponent();
            this.db = new RentACarEntities2();
            FillCarBrand1();
            FillCarColor1();
        }
      
        private void FillCarColor1()
        {
            cb_car_upd_color.Items.Clear();
            cb_car_upd_color.Items.Add("All");
            cb_car_upd_color.SelectedItem = "All";
            foreach (CarColor item in db.CarColor.ToList())
            {
                cb_car_upd_color.Items.Add(item.Color);
            }
        }
        private void FillCarBrand1()
        {
            cb_car_upd_brand.Items.Clear();
            cb_car_upd_brand.Items.Add("All");
            cb_car_upd_brand.SelectedItem = "All";
            foreach (CarBrand item in db.CarBrand.ToList())
            {
                cb_car_upd_brand.Items.Add(item.BrandName);
            }
        }
        private void FillCarModel1()
        {
            cb_car_upd_model.Items.Clear();
            cb_car_upd_model.Items.Add("All");
            cb_car_upd_model.SelectedItem = "All";
            int brandId;
            if (db.CarBrand.FirstOrDefault(m => m.BrandName == cb_car_upd_brand.Text) != null)
            {
                brandId = db.CarBrand.FirstOrDefault(m => m.BrandName == cb_car_upd_brand.Text).Id;

                foreach (CarModel item in db.CarModel.Where(m => m.CarBrandId == brandId).ToList())
                {
                    cb_car_upd_model.Items.Add(item.ModelName);
                }
            }
        }
            private void cb_car_upd_brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCarModel1();
        }
        public void Fill_Update_or_Delete_Cars_Info(string brand,string model,string color,string number,decimal year,string tex,decimal dailyprice)
        {
            cb_car_upd_brand.Text = brand;
            cb_car_upd_model.Text = model;
            cb_car_upd_color.Text = color;
            txt_car_upd_number.Text = number;
            num_upd_year.Value = year;
            txt_car_upd_tex.Text = tex;
            num_upd_dailyprice.Value = dailyprice;
        }

     
        private void btn_update_car_Click(object sender, EventArgs e)
        {
            CarInfo car = db.CarInfo.Find(carId);

            if (db.CarModel.FirstOrDefault(c => c.ModelName == cb_car_upd_model.Text) != null
               && db.CarColor.FirstOrDefault(c => c.Color == cb_car_upd_color.Text) != null
               && !string.IsNullOrWhiteSpace(txt_car_upd_number.Text) &&
               !string.IsNullOrWhiteSpace(num_upd_year.Value.ToString()) && num_upd_year.Value != 0 &&
               !string.IsNullOrWhiteSpace(txt_car_upd_tex.Text) &&
               !string.IsNullOrWhiteSpace(num_upd_dailyprice.Value.ToString()) && num_upd_dailyprice.Value != 0)
            {
                car.CarModelId = db.CarModel.FirstOrDefault(c => c.ModelName == cb_car_upd_model.Text).Id;

                car.ColorId = db.CarColor.FirstOrDefault(c => c.Color == cb_car_upd_color.Text).Id;


                car.CarNumber = txt_car_upd_number.Text;
                car.Year = Convert.ToInt32(num_upd_year.Value);
                car.TexPassport = txt_car_upd_tex.Text;
                car.DailyPrice = num_upd_dailyprice.Value;

                db.SaveChanges();
                MessageBox.Show("Maşın məlumatları uğurla yeniləndi!");
                //cars_form.FillCarGrid();
                this.Close();
                Cars_Form cars = new Cars_Form();
                cars.Show();
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa bütün xanaları doldurun!");
            }
        }

        private void btn_delete_car_Click(object sender, EventArgs e)
        {
            CarInfo car = db.CarInfo.Find(carId);
            db.CarInfo.Remove(car);
            db.SaveChanges();
            //cars_form.FillCarGrid();
            MessageBox.Show("Maşın uğurla silindi!");
            this.Close();
            Cars_Form cars = new Cars_Form();
            cars.Show();
        }
    }
   
}
