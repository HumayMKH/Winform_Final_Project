namespace Rent_A_Car
{
    partial class Update_or_Delete_Client_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_or_Delete_Client_Form));
            this.picture_clients = new System.Windows.Forms.PictureBox();
            this.btn_delete_client = new System.Windows.Forms.Button();
            this.btn_update_client = new System.Windows.Forms.Button();
            this.txt_client_upd_phone = new System.Windows.Forms.TextBox();
            this.txt_client_upd_email = new System.Windows.Forms.TextBox();
            this.txt_client_upd_passport = new System.Windows.Forms.TextBox();
            this.txt_client_upd_surname = new System.Windows.Forms.TextBox();
            this.txt_client_upd_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_upd_client = new System.Windows.Forms.RichTextBox();
            this.num_upd_age = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picture_clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_upd_age)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_clients
            // 
            this.picture_clients.Image = ((System.Drawing.Image)(resources.GetObject("picture_clients.Image")));
            this.picture_clients.Location = new System.Drawing.Point(46, -1);
            this.picture_clients.Name = "picture_clients";
            this.picture_clients.Size = new System.Drawing.Size(202, 154);
            this.picture_clients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_clients.TabIndex = 54;
            this.picture_clients.TabStop = false;
            // 
            // btn_delete_client
            // 
            this.btn_delete_client.BackColor = System.Drawing.Color.Maroon;
            this.btn_delete_client.FlatAppearance.BorderSize = 0;
            this.btn_delete_client.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_delete_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_client.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_client.ForeColor = System.Drawing.Color.White;
            this.btn_delete_client.Location = new System.Drawing.Point(162, 483);
            this.btn_delete_client.Name = "btn_delete_client";
            this.btn_delete_client.Size = new System.Drawing.Size(104, 38);
            this.btn_delete_client.TabIndex = 70;
            this.btn_delete_client.Text = "DELETE";
            this.btn_delete_client.UseVisualStyleBackColor = false;
            this.btn_delete_client.Click += new System.EventHandler(this.btn_delete_client_Click);
            // 
            // btn_update_client
            // 
            this.btn_update_client.BackColor = System.Drawing.Color.Maroon;
            this.btn_update_client.FlatAppearance.BorderSize = 0;
            this.btn_update_client.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_update_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_client.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_client.ForeColor = System.Drawing.Color.White;
            this.btn_update_client.Location = new System.Drawing.Point(23, 483);
            this.btn_update_client.Name = "btn_update_client";
            this.btn_update_client.Size = new System.Drawing.Size(104, 38);
            this.btn_update_client.TabIndex = 69;
            this.btn_update_client.Text = "UPDATE";
            this.btn_update_client.UseVisualStyleBackColor = false;
            this.btn_update_client.Click += new System.EventHandler(this.btn_update_client_Click);
            // 
            // txt_client_upd_phone
            // 
            this.txt_client_upd_phone.Location = new System.Drawing.Point(107, 323);
            this.txt_client_upd_phone.Name = "txt_client_upd_phone";
            this.txt_client_upd_phone.Size = new System.Drawing.Size(159, 20);
            this.txt_client_upd_phone.TabIndex = 66;
            // 
            // txt_client_upd_email
            // 
            this.txt_client_upd_email.Location = new System.Drawing.Point(107, 361);
            this.txt_client_upd_email.Name = "txt_client_upd_email";
            this.txt_client_upd_email.Size = new System.Drawing.Size(159, 20);
            this.txt_client_upd_email.TabIndex = 67;
            // 
            // txt_client_upd_passport
            // 
            this.txt_client_upd_passport.Location = new System.Drawing.Point(107, 284);
            this.txt_client_upd_passport.Name = "txt_client_upd_passport";
            this.txt_client_upd_passport.Size = new System.Drawing.Size(159, 20);
            this.txt_client_upd_passport.TabIndex = 65;
            // 
            // txt_client_upd_surname
            // 
            this.txt_client_upd_surname.Location = new System.Drawing.Point(107, 208);
            this.txt_client_upd_surname.Name = "txt_client_upd_surname";
            this.txt_client_upd_surname.Size = new System.Drawing.Size(159, 20);
            this.txt_client_upd_surname.TabIndex = 63;
            // 
            // txt_client_upd_name
            // 
            this.txt_client_upd_name.Location = new System.Drawing.Point(107, 171);
            this.txt_client_upd_name.Name = "txt_client_upd_name";
            this.txt_client_upd_name.Size = new System.Drawing.Size(159, 20);
            this.txt_client_upd_name.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(27, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 61;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(27, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 60;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(27, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 59;
            this.label7.Text = "Phone *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(27, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 58;
            this.label8.Text = "Adress *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(27, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 57;
            this.label4.Text = "Passport *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(27, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 56;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(27, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 55;
            this.label1.Text = "Name *";
            // 
            // rtb_upd_client
            // 
            this.rtb_upd_client.Location = new System.Drawing.Point(107, 397);
            this.rtb_upd_client.Name = "rtb_upd_client";
            this.rtb_upd_client.Size = new System.Drawing.Size(159, 61);
            this.rtb_upd_client.TabIndex = 68;
            this.rtb_upd_client.Text = "";
            // 
            // num_upd_age
            // 
            this.num_upd_age.Location = new System.Drawing.Point(107, 245);
            this.num_upd_age.Name = "num_upd_age";
            this.num_upd_age.Size = new System.Drawing.Size(159, 20);
            this.num_upd_age.TabIndex = 64;
            // 
            // Update_or_Delete_Client_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(293, 533);
            this.Controls.Add(this.num_upd_age);
            this.Controls.Add(this.rtb_upd_client);
            this.Controls.Add(this.txt_client_upd_phone);
            this.Controls.Add(this.txt_client_upd_email);
            this.Controls.Add(this.txt_client_upd_passport);
            this.Controls.Add(this.txt_client_upd_surname);
            this.Controls.Add(this.txt_client_upd_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture_clients);
            this.Controls.Add(this.btn_delete_client);
            this.Controls.Add(this.btn_update_client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Update_or_Delete_Client_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_or_Delete_Client_Form";
            ((System.ComponentModel.ISupportInitialize)(this.picture_clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_upd_age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_clients;
        private System.Windows.Forms.Button btn_delete_client;
        private System.Windows.Forms.Button btn_update_client;
        private System.Windows.Forms.TextBox txt_client_upd_phone;
        private System.Windows.Forms.TextBox txt_client_upd_email;
        private System.Windows.Forms.TextBox txt_client_upd_passport;
        private System.Windows.Forms.TextBox txt_client_upd_surname;
        private System.Windows.Forms.TextBox txt_client_upd_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_upd_client;
        private System.Windows.Forms.NumericUpDown num_upd_age;
    }
}