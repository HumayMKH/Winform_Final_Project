namespace Rent_A_Car
{
    partial class Dasboard
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ms_workers = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_clients = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_cars = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_reports = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_new_order = new System.Windows.Forms.Button();
            this.btn_old_order = new System.Windows.Forms.Button();
            this.dgv_fill_order = new System.Windows.Forms.DataGridView();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fill_order)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_workers,
            this.ms_clients,
            this.ms_cars,
            this.ms_reports});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 25);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ms_workers
            // 
            this.ms_workers.ForeColor = System.Drawing.Color.Maroon;
            this.ms_workers.Name = "ms_workers";
            this.ms_workers.Size = new System.Drawing.Size(71, 21);
            this.ms_workers.Text = "Workers";
            this.ms_workers.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ms_clients
            // 
            this.ms_clients.ForeColor = System.Drawing.Color.Maroon;
            this.ms_clients.Name = "ms_clients";
            this.ms_clients.Size = new System.Drawing.Size(62, 21);
            this.ms_clients.Text = "Clients";
            this.ms_clients.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // ms_cars
            // 
            this.ms_cars.ForeColor = System.Drawing.Color.Maroon;
            this.ms_cars.Name = "ms_cars";
            this.ms_cars.Size = new System.Drawing.Size(46, 21);
            this.ms_cars.Text = "Cars";
            this.ms_cars.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // ms_reports
            // 
            this.ms_reports.ForeColor = System.Drawing.Color.Maroon;
            this.ms_reports.Name = "ms_reports";
            this.ms_reports.Size = new System.Drawing.Size(67, 21);
            this.ms_reports.Text = "Reports";
            this.ms_reports.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // btn_new_order
            // 
            this.btn_new_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_new_order.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_new_order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btn_new_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_order.ForeColor = System.Drawing.Color.Maroon;
            this.btn_new_order.Location = new System.Drawing.Point(504, 11);
            this.btn_new_order.Name = "btn_new_order";
            this.btn_new_order.Size = new System.Drawing.Size(131, 35);
            this.btn_new_order.TabIndex = 3;
            this.btn_new_order.Text = "New Order";
            this.btn_new_order.UseVisualStyleBackColor = false;
            this.btn_new_order.Click += new System.EventHandler(this.btn_new_order_Click);
            // 
            // btn_old_order
            // 
            this.btn_old_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_old_order.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_old_order.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btn_old_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_old_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_old_order.ForeColor = System.Drawing.Color.Maroon;
            this.btn_old_order.Location = new System.Drawing.Point(657, 11);
            this.btn_old_order.Name = "btn_old_order";
            this.btn_old_order.Size = new System.Drawing.Size(131, 35);
            this.btn_old_order.TabIndex = 4;
            this.btn_old_order.Text = "Old Order";
            this.btn_old_order.UseVisualStyleBackColor = false;
            this.btn_old_order.Click += new System.EventHandler(this.btn_old_order_Click);
            // 
            // dgv_fill_order
            // 
            this.dgv_fill_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_fill_order.BackgroundColor = System.Drawing.Color.White;
            this.dgv_fill_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fill_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column14,
            this.Column15,
            this.Column1,
            this.Column2,
            this.Column16,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column3,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dgv_fill_order.Location = new System.Drawing.Point(12, 63);
            this.dgv_fill_order.Name = "dgv_fill_order";
            this.dgv_fill_order.Size = new System.Drawing.Size(776, 375);
            this.dgv_fill_order.TabIndex = 5;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Id";
            this.Column14.Name = "Column14";
            this.Column14.Visible = false;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "ClientId";
            this.Column15.Name = "Column15";
            this.Column15.Visible = false;
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
            // Column16
            // 
            this.Column16.HeaderText = "CarInfoId";
            this.Column16.Name = "Column16";
            this.Column16.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Number";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Added Date";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Start Date";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "End Date";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Over Date";
            this.Column10.Name = "Column10";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Days";
            this.Column3.Name = "Column3";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Late Days";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Total Price";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Late Price";
            this.Column13.Name = "Column13";
            // 
            // Dasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_fill_order);
            this.Controls.Add(this.btn_old_order);
            this.Controls.Add(this.btn_new_order);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Dasboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dasboard";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fill_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ms_workers;
        private System.Windows.Forms.ToolStripMenuItem ms_clients;
        private System.Windows.Forms.ToolStripMenuItem ms_cars;
        private System.Windows.Forms.Button btn_new_order;
        private System.Windows.Forms.Button btn_old_order;
        private System.Windows.Forms.ToolStripMenuItem ms_reports;
        private System.Windows.Forms.DataGridView dgv_fill_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}