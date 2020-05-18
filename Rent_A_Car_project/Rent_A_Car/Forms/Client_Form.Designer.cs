namespace Rent_A_Car
{
    partial class Client_Form
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
            this.btn_add_client = new System.Windows.Forms.Button();
            this.dgv_clientslist = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_client__phone = new System.Windows.Forms.TextBox();
            this.txt_client_email = new System.Windows.Forms.TextBox();
            this.txt_client_passport = new System.Windows.Forms.TextBox();
            this.txt_client__surname = new System.Windows.Forms.TextBox();
            this.txt_client_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_address = new System.Windows.Forms.RichTextBox();
            this.num_client = new System.Windows.Forms.NumericUpDown();
            this.txt_search_client = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientslist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_client)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_client
            // 
            this.btn_add_client.BackColor = System.Drawing.Color.Maroon;
            this.btn_add_client.FlatAppearance.BorderSize = 0;
            this.btn_add_client.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_add_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_client.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_client.ForeColor = System.Drawing.Color.White;
            this.btn_add_client.Location = new System.Drawing.Point(17, 337);
            this.btn_add_client.Name = "btn_add_client";
            this.btn_add_client.Size = new System.Drawing.Size(189, 31);
            this.btn_add_client.TabIndex = 34;
            this.btn_add_client.Text = "ADD CLIENT";
            this.btn_add_client.UseVisualStyleBackColor = false;
            this.btn_add_client.Click += new System.EventHandler(this.btn_add_client_Click);
            // 
            // dgv_clientslist
            // 
            this.dgv_clientslist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clientslist.BackgroundColor = System.Drawing.Color.White;
            this.dgv_clientslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientslist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column4,
            this.Column7,
            this.Column6,
            this.Column8});
            this.dgv_clientslist.Location = new System.Drawing.Point(234, 60);
            this.dgv_clientslist.Name = "dgv_clientslist";
            this.dgv_clientslist.Size = new System.Drawing.Size(786, 308);
            this.dgv_clientslist.TabIndex = 35;
            this.dgv_clientslist.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_workerlist_RowHeaderMouseDoubleClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Id";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Surname";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Age";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Passport";
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Phone";
            this.Column7.Name = "Column7";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Email";
            this.Column6.Name = "Column6";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Address";
            this.Column8.Name = "Column8";
            // 
            // txt_client__phone
            // 
            this.txt_client__phone.Location = new System.Drawing.Point(94, 175);
            this.txt_client__phone.Name = "txt_client__phone";
            this.txt_client__phone.Size = new System.Drawing.Size(112, 20);
            this.txt_client__phone.TabIndex = 31;
            // 
            // txt_client_email
            // 
            this.txt_client_email.Location = new System.Drawing.Point(94, 213);
            this.txt_client_email.Name = "txt_client_email";
            this.txt_client_email.Size = new System.Drawing.Size(112, 20);
            this.txt_client_email.TabIndex = 32;
            // 
            // txt_client_passport
            // 
            this.txt_client_passport.Location = new System.Drawing.Point(94, 136);
            this.txt_client_passport.Name = "txt_client_passport";
            this.txt_client_passport.Size = new System.Drawing.Size(112, 20);
            this.txt_client_passport.TabIndex = 30;
            // 
            // txt_client__surname
            // 
            this.txt_client__surname.Location = new System.Drawing.Point(94, 60);
            this.txt_client__surname.Name = "txt_client__surname";
            this.txt_client__surname.Size = new System.Drawing.Size(112, 20);
            this.txt_client__surname.TabIndex = 28;
            // 
            // txt_client_name
            // 
            this.txt_client_name.Location = new System.Drawing.Point(94, 23);
            this.txt_client_name.Name = "txt_client_name";
            this.txt_client_name.Size = new System.Drawing.Size(112, 20);
            this.txt_client_name.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(14, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(14, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(14, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Phone *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(14, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Adress *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(14, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Passport *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name *";
            // 
            // rb_address
            // 
            this.rb_address.Location = new System.Drawing.Point(94, 249);
            this.rb_address.Name = "rb_address";
            this.rb_address.Size = new System.Drawing.Size(112, 69);
            this.rb_address.TabIndex = 33;
            this.rb_address.Text = "";
            // 
            // num_client
            // 
            this.num_client.Location = new System.Drawing.Point(94, 97);
            this.num_client.Name = "num_client";
            this.num_client.Size = new System.Drawing.Size(112, 20);
            this.num_client.TabIndex = 29;
            // 
            // txt_search_client
            // 
            this.txt_search_client.Location = new System.Drawing.Point(381, 24);
            this.txt_search_client.Name = "txt_search_client";
            this.txt_search_client.Size = new System.Drawing.Size(213, 20);
            this.txt_search_client.TabIndex = 42;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Maroon;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(234, 23);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(102, 21);
            this.btn_search.TabIndex = 41;
            this.btn_search.Text = "Search ";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Client_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 388);
            this.Controls.Add(this.txt_search_client);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.num_client);
            this.Controls.Add(this.rb_address);
            this.Controls.Add(this.btn_add_client);
            this.Controls.Add(this.dgv_clientslist);
            this.Controls.Add(this.txt_client__phone);
            this.Controls.Add(this.txt_client_email);
            this.Controls.Add(this.txt_client_passport);
            this.Controls.Add(this.txt_client__surname);
            this.Controls.Add(this.txt_client_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Client_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientslist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_client;
        private System.Windows.Forms.DataGridView dgv_clientslist;
        private System.Windows.Forms.TextBox txt_client__phone;
        private System.Windows.Forms.TextBox txt_client_email;
        private System.Windows.Forms.TextBox txt_client_passport;
        private System.Windows.Forms.TextBox txt_client__surname;
        private System.Windows.Forms.TextBox txt_client_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rb_address;
        private System.Windows.Forms.NumericUpDown num_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox txt_search_client;
        private System.Windows.Forms.Button btn_search;
    }
}