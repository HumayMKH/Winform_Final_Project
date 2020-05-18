namespace Rent_A_Car
{
    partial class Cars_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_car_brand = new System.Windows.Forms.ComboBox();
            this.cb_car_model = new System.Windows.Forms.ComboBox();
            this.cb_car_color = new System.Windows.Forms.ComboBox();
            this.txt_car_number = new System.Windows.Forms.TextBox();
            this.txt_car_tex = new System.Windows.Forms.TextBox();
            this.btn_add_car = new System.Windows.Forms.Button();
            this.dgv_Cars = new System.Windows.Forms.DataGridView();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_year = new System.Windows.Forms.NumericUpDown();
            this.num_daily_price = new System.Windows.Forms.NumericUpDown();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_daily_price)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brand:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(20, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(20, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(20, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(20, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Year:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(20, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "TEXpassport:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(20, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Daily Price:";
            // 
            // cb_car_brand
            // 
            this.cb_car_brand.FormattingEnabled = true;
            this.cb_car_brand.Location = new System.Drawing.Point(106, 25);
            this.cb_car_brand.Name = "cb_car_brand";
            this.cb_car_brand.Size = new System.Drawing.Size(132, 21);
            this.cb_car_brand.TabIndex = 9;
            this.cb_car_brand.SelectedIndexChanged += new System.EventHandler(this.cb_car_brand_SelectedIndexChanged);
            // 
            // cb_car_model
            // 
            this.cb_car_model.FormattingEnabled = true;
            this.cb_car_model.Location = new System.Drawing.Point(106, 58);
            this.cb_car_model.Name = "cb_car_model";
            this.cb_car_model.Size = new System.Drawing.Size(132, 21);
            this.cb_car_model.TabIndex = 10;
            // 
            // cb_car_color
            // 
            this.cb_car_color.FormattingEnabled = true;
            this.cb_car_color.Location = new System.Drawing.Point(106, 89);
            this.cb_car_color.Name = "cb_car_color";
            this.cb_car_color.Size = new System.Drawing.Size(132, 21);
            this.cb_car_color.TabIndex = 11;
            // 
            // txt_car_number
            // 
            this.txt_car_number.Location = new System.Drawing.Point(106, 121);
            this.txt_car_number.Name = "txt_car_number";
            this.txt_car_number.Size = new System.Drawing.Size(132, 20);
            this.txt_car_number.TabIndex = 12;
            // 
            // txt_car_tex
            // 
            this.txt_car_tex.Location = new System.Drawing.Point(106, 185);
            this.txt_car_tex.Name = "txt_car_tex";
            this.txt_car_tex.Size = new System.Drawing.Size(132, 20);
            this.txt_car_tex.TabIndex = 14;
            // 
            // btn_add_car
            // 
            this.btn_add_car.BackColor = System.Drawing.Color.Maroon;
            this.btn_add_car.FlatAppearance.BorderSize = 0;
            this.btn_add_car.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_add_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_car.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_car.ForeColor = System.Drawing.Color.White;
            this.btn_add_car.Location = new System.Drawing.Point(23, 296);
            this.btn_add_car.Name = "btn_add_car";
            this.btn_add_car.Size = new System.Drawing.Size(215, 25);
            this.btn_add_car.TabIndex = 16;
            this.btn_add_car.Text = "ADD CAR";
            this.btn_add_car.UseVisualStyleBackColor = false;
            this.btn_add_car.Click += new System.EventHandler(this.btn_add_car_Click);
            // 
            // dgv_Cars
            // 
            this.dgv_Cars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Cars.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgv_Cars.GridColor = System.Drawing.Color.LightGray;
            this.dgv_Cars.Location = new System.Drawing.Point(256, 58);
            this.dgv_Cars.Name = "dgv_Cars";
            this.dgv_Cars.Size = new System.Drawing.Size(866, 263);
            this.dgv_Cars.TabIndex = 38;
            this.dgv_Cars.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Cars_RowHeaderMouseDoubleClick);
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Id";
            this.Column13.Name = "Column13";
            this.Column13.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "BrandId";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Brand";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ModelId";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Model";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ColorId";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Color";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Number";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Year";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "TEXpassport";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Daily Price";
            this.Column12.Name = "Column12";
            // 
            // num_year
            // 
            this.num_year.Location = new System.Drawing.Point(106, 155);
            this.num_year.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.num_year.Name = "num_year";
            this.num_year.Size = new System.Drawing.Size(132, 20);
            this.num_year.TabIndex = 13;
            // 
            // num_daily_price
            // 
            this.num_daily_price.Location = new System.Drawing.Point(106, 219);
            this.num_daily_price.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_daily_price.Name = "num_daily_price";
            this.num_daily_price.Size = new System.Drawing.Size(132, 20);
            this.num_daily_price.TabIndex = 15;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Maroon;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(256, 25);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(163, 21);
            this.btn_search.TabIndex = 39;
            this.btn_search.Text = "Search With Number";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(460, 26);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(196, 20);
            this.txt_search.TabIndex = 40;
            // 
            // Cars_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 342);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.num_daily_price);
            this.Controls.Add(this.num_year);
            this.Controls.Add(this.dgv_Cars);
            this.Controls.Add(this.btn_add_car);
            this.Controls.Add(this.txt_car_tex);
            this.Controls.Add(this.txt_car_number);
            this.Controls.Add(this.cb_car_color);
            this.Controls.Add(this.cb_car_model);
            this.Controls.Add(this.cb_car_brand);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Cars_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cars_Form";
         
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_daily_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_car_brand;
        private System.Windows.Forms.ComboBox cb_car_model;
        private System.Windows.Forms.ComboBox cb_car_color;
        private System.Windows.Forms.TextBox txt_car_number;
        private System.Windows.Forms.TextBox txt_car_tex;
        private System.Windows.Forms.Button btn_add_car;
        private System.Windows.Forms.DataGridView dgv_Cars;
        private System.Windows.Forms.NumericUpDown num_year;
        private System.Windows.Forms.NumericUpDown num_daily_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
    }
}