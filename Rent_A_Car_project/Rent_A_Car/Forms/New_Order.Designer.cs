namespace Rent_A_Car
{
    partial class New_Order
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.cb_order_client = new System.Windows.Forms.ComboBox();
            this.btn_order_add_client = new System.Windows.Forms.Button();
            this.btn_order_addclient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.num_days = new System.Windows.Forms.NumericUpDown();
            this.cb_number = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_days)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(28, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(28, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(28, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "End Date:";
            // 
            // dtp_end
            // 
            this.dtp_end.CalendarForeColor = System.Drawing.Color.Black;
            this.dtp_end.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtp_end.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dtp_end.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtp_end.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(147, 134);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(233, 21);
            this.dtp_end.TabIndex = 23;
            // 
            // dtp_start
            // 
            this.dtp_start.CalendarForeColor = System.Drawing.Color.Black;
            this.dtp_start.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtp_start.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dtp_start.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtp_start.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(147, 96);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(233, 21);
            this.dtp_start.TabIndex = 22;
            // 
            // cb_order_client
            // 
            this.cb_order_client.ForeColor = System.Drawing.Color.Black;
            this.cb_order_client.FormattingEnabled = true;
            this.cb_order_client.Location = new System.Drawing.Point(147, 15);
            this.cb_order_client.Name = "cb_order_client";
            this.cb_order_client.Size = new System.Drawing.Size(233, 23);
            this.cb_order_client.TabIndex = 20;
            // 
            // btn_order_add_client
            // 
            this.btn_order_add_client.BackColor = System.Drawing.Color.Maroon;
            this.btn_order_add_client.FlatAppearance.BorderSize = 0;
            this.btn_order_add_client.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_order_add_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order_add_client.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order_add_client.ForeColor = System.Drawing.Color.White;
            this.btn_order_add_client.Location = new System.Drawing.Point(31, 210);
            this.btn_order_add_client.Name = "btn_order_add_client";
            this.btn_order_add_client.Size = new System.Drawing.Size(349, 27);
            this.btn_order_add_client.TabIndex = 25;
            this.btn_order_add_client.Text = "ADD ORDER";
            this.btn_order_add_client.UseVisualStyleBackColor = false;
            this.btn_order_add_client.Click += new System.EventHandler(this.btn_order_add_client_Click);
            // 
            // btn_order_addclient
            // 
            this.btn_order_addclient.BackColor = System.Drawing.Color.White;
            this.btn_order_addclient.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_order_addclient.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_order_addclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order_addclient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order_addclient.ForeColor = System.Drawing.Color.Black;
            this.btn_order_addclient.Location = new System.Drawing.Point(386, 15);
            this.btn_order_addclient.Name = "btn_order_addclient";
            this.btn_order_addclient.Size = new System.Drawing.Size(23, 23);
            this.btn_order_addclient.TabIndex = 26;
            this.btn_order_addclient.Text = "+";
            this.btn_order_addclient.UseVisualStyleBackColor = false;
            this.btn_order_addclient.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(28, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Days:";
            // 
            // num_days
            // 
            this.num_days.Location = new System.Drawing.Point(147, 172);
            this.num_days.Name = "num_days";
            this.num_days.Size = new System.Drawing.Size(233, 21);
            this.num_days.TabIndex = 24;
            // 
            // cb_number
            // 
            this.cb_number.ForeColor = System.Drawing.Color.Black;
            this.cb_number.FormattingEnabled = true;
            this.cb_number.Location = new System.Drawing.Point(147, 55);
            this.cb_number.Name = "cb_number";
            this.cb_number.Size = new System.Drawing.Size(233, 23);
            this.cb_number.TabIndex = 21;
            // 
            // New_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 254);
            this.Controls.Add(this.cb_number);
            this.Controls.Add(this.num_days);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_order_addclient);
            this.Controls.Add(this.btn_order_add_client);
            this.Controls.Add(this.dtp_end);
            this.Controls.Add(this.dtp_start);
            this.Controls.Add(this.cb_order_client);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "New_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Order";
            ((System.ComponentModel.ISupportInitialize)(this.num_days)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.ComboBox cb_order_client;
        private System.Windows.Forms.Button btn_order_add_client;
        private System.Windows.Forms.Button btn_order_addclient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_days;
        private System.Windows.Forms.ComboBox cb_number;
    }
}