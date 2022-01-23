namespace QlyQuanAn
{
    partial class ManageSalaryForm
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
            this.dGv_diemdanh = new System.Windows.Forms.DataGridView();
            this.lb_search = new System.Windows.Forms.Label();
            this.dTpfromdate = new System.Windows.Forms.DateTimePicker();
            this.dTptodate = new System.Windows.Forms.DateTimePicker();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lb_from = new System.Windows.Forms.Label();
            this.bt_check = new System.Windows.Forms.Button();
            this.lb_to = new System.Windows.Forms.Label();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_count = new System.Windows.Forms.Label();
            this.bt_x = new System.Windows.Forms.Button();
            this.bt_sortThang = new System.Windows.Forms.Button();
            this.bt_sortTuan = new System.Windows.Forms.Button();
            this.lb_sort = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_diemdanh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGv_diemdanh
            // 
            this.dGv_diemdanh.AllowUserToAddRows = false;
            this.dGv_diemdanh.AllowUserToDeleteRows = false;
            this.dGv_diemdanh.AllowUserToOrderColumns = true;
            this.dGv_diemdanh.AllowUserToResizeColumns = false;
            this.dGv_diemdanh.AllowUserToResizeRows = false;
            this.dGv_diemdanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGv_diemdanh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGv_diemdanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_diemdanh.Location = new System.Drawing.Point(24, 198);
            this.dGv_diemdanh.Name = "dGv_diemdanh";
            this.dGv_diemdanh.ReadOnly = true;
            this.dGv_diemdanh.RowHeadersVisible = false;
            this.dGv_diemdanh.Size = new System.Drawing.Size(859, 290);
            this.dGv_diemdanh.TabIndex = 16;
            this.dGv_diemdanh.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGv_diemdanh_CellDoubleClick);
            // 
            // lb_search
            // 
            this.lb_search.AutoSize = true;
            this.lb_search.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_search.Location = new System.Drawing.Point(73, 79);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(176, 19);
            this.lb_search.TabIndex = 12;
            this.lb_search.Text = "Search with (ID,Name) :";
            // 
            // dTpfromdate
            // 
            this.dTpfromdate.CustomFormat = "ddMMyyyy";
            this.dTpfromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTpfromdate.Location = new System.Drawing.Point(83, 30);
            this.dTpfromdate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dTpfromdate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dTpfromdate.Name = "dTpfromdate";
            this.dTpfromdate.Size = new System.Drawing.Size(119, 20);
            this.dTpfromdate.TabIndex = 6;
            this.dTpfromdate.Value = new System.DateTime(2021, 5, 1, 20, 25, 0, 0);
            // 
            // dTptodate
            // 
            this.dTptodate.CustomFormat = "ddMMyyyy";
            this.dTptodate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTptodate.Location = new System.Drawing.Point(241, 30);
            this.dTptodate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dTptodate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dTptodate.Name = "dTptodate";
            this.dTptodate.Size = new System.Drawing.Size(119, 20);
            this.dTptodate.TabIndex = 7;
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.tb_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(165)))), ((int)(((byte)(204)))));
            this.tb_search.Location = new System.Drawing.Point(255, 79);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(149, 20);
            this.tb_search.TabIndex = 11;
            // 
            // lb_from
            // 
            this.lb_from.AutoSize = true;
            this.lb_from.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_from.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_from.Location = new System.Drawing.Point(31, 30);
            this.lb_from.Name = "lb_from";
            this.lb_from.Size = new System.Drawing.Size(46, 19);
            this.lb_from.TabIndex = 8;
            this.lb_from.Text = "From";
            // 
            // bt_check
            // 
            this.bt_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.bt_check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_check.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.bt_check.Location = new System.Drawing.Point(378, 22);
            this.bt_check.Name = "bt_check";
            this.bt_check.Size = new System.Drawing.Size(85, 35);
            this.bt_check.TabIndex = 10;
            this.bt_check.Text = "Check";
            this.bt_check.UseVisualStyleBackColor = false;
            this.bt_check.Click += new System.EventHandler(this.bt_check_Click);
            // 
            // lb_to
            // 
            this.lb_to.AutoSize = true;
            this.lb_to.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_to.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_to.Location = new System.Drawing.Point(208, 30);
            this.lb_to.Name = "lb_to";
            this.lb_to.Size = new System.Drawing.Size(27, 19);
            this.lb_to.TabIndex = 9;
            this.lb_to.Text = "To";
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_thongbao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_thongbao.Location = new System.Drawing.Point(284, 160);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(325, 22);
            this.lb_thongbao.TabIndex = 19;
            this.lb_thongbao.Text = "Nhấp đôi vào nhân viên cần tính lương";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.lb_search);
            this.panel1.Controls.Add(this.dTpfromdate);
            this.panel1.Controls.Add(this.dTptodate);
            this.panel1.Controls.Add(this.tb_search);
            this.panel1.Controls.Add(this.lb_from);
            this.panel1.Controls.Add(this.bt_check);
            this.panel1.Controls.Add(this.lb_to);
            this.panel1.Location = new System.Drawing.Point(211, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 127);
            this.panel1.TabIndex = 18;
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_count.Location = new System.Drawing.Point(764, 501);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(94, 19);
            this.lb_count.TabIndex = 17;
            this.lb_count.Text = "Count Row :";
            // 
            // bt_x
            // 
            this.bt_x.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.bt_x.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_x.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_x.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.bt_x.Location = new System.Drawing.Point(858, 12);
            this.bt_x.Name = "bt_x";
            this.bt_x.Size = new System.Drawing.Size(36, 36);
            this.bt_x.TabIndex = 42;
            this.bt_x.Text = "X";
            this.bt_x.UseVisualStyleBackColor = false;
            this.bt_x.Click += new System.EventHandler(this.bt_x_Click);
            // 
            // bt_sortThang
            // 
            this.bt_sortThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.bt_sortThang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_sortThang.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sortThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.bt_sortThang.Location = new System.Drawing.Point(120, 43);
            this.bt_sortThang.Name = "bt_sortThang";
            this.bt_sortThang.Size = new System.Drawing.Size(85, 35);
            this.bt_sortThang.TabIndex = 43;
            this.bt_sortThang.Text = "Tháng";
            this.bt_sortThang.UseVisualStyleBackColor = false;
            this.bt_sortThang.Click += new System.EventHandler(this.bt_sortThang_Click);
            // 
            // bt_sortTuan
            // 
            this.bt_sortTuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.bt_sortTuan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_sortTuan.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sortTuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.bt_sortTuan.Location = new System.Drawing.Point(120, 92);
            this.bt_sortTuan.Name = "bt_sortTuan";
            this.bt_sortTuan.Size = new System.Drawing.Size(85, 35);
            this.bt_sortTuan.TabIndex = 44;
            this.bt_sortTuan.Text = "Tuần";
            this.bt_sortTuan.UseVisualStyleBackColor = false;
            this.bt_sortTuan.Click += new System.EventHandler(this.bt_sortTuan_Click);
            // 
            // lb_sort
            // 
            this.lb_sort.AutoSize = true;
            this.lb_sort.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_sort.Location = new System.Drawing.Point(76, 73);
            this.lb_sort.Name = "lb_sort";
            this.lb_sort.Size = new System.Drawing.Size(38, 19);
            this.lb_sort.TabIndex = 45;
            this.lb_sort.Text = "Sort";
            // 
            // ManageSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(910, 545);
            this.Controls.Add(this.lb_sort);
            this.Controls.Add(this.bt_sortTuan);
            this.Controls.Add(this.bt_sortThang);
            this.Controls.Add(this.bt_x);
            this.Controls.Add(this.dGv_diemdanh);
            this.Controls.Add(this.lb_thongbao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_count);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageSalaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageSalaryForm";
            this.Load += new System.EventHandler(this.ManageSalaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGv_diemdanh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGv_diemdanh;
        private System.Windows.Forms.Label lb_search;
        private System.Windows.Forms.DateTimePicker dTpfromdate;
        private System.Windows.Forms.DateTimePicker dTptodate;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lb_from;
        private System.Windows.Forms.Button bt_check;
        private System.Windows.Forms.Label lb_to;
        private System.Windows.Forms.Label lb_thongbao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Button bt_x;
        private System.Windows.Forms.Button bt_sortThang;
        private System.Windows.Forms.Button bt_sortTuan;
        private System.Windows.Forms.Label lb_sort;
    }
}