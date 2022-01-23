namespace QlyQuanAn
{
    partial class ManageRecordForm
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
            this.rBt_absent = new System.Windows.Forms.RadioButton();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.dTpfromdate = new System.Windows.Forms.DateTimePicker();
            this.rBt_none = new System.Windows.Forms.RadioButton();
            this.dTptodate = new System.Windows.Forms.DateTimePicker();
            this.lb_from = new System.Windows.Forms.Label();
            this.rBt_late = new System.Windows.Forms.RadioButton();
            this.lb_to = new System.Windows.Forms.Label();
            this.bt_check = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.lb_search = new System.Windows.Forms.Label();
            this.lb_count = new System.Windows.Forms.Label();
            this.bt_x = new System.Windows.Forms.Button();
            this.lb_sort = new System.Windows.Forms.Label();
            this.bt_sortTuan = new System.Windows.Forms.Button();
            this.bt_sortThang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_diemdanh)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGv_diemdanh
            // 
            this.dGv_diemdanh.AllowUserToAddRows = false;
            this.dGv_diemdanh.AllowUserToDeleteRows = false;
            this.dGv_diemdanh.AllowUserToResizeColumns = false;
            this.dGv_diemdanh.AllowUserToResizeRows = false;
            this.dGv_diemdanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGv_diemdanh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGv_diemdanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_diemdanh.Location = new System.Drawing.Point(35, 185);
            this.dGv_diemdanh.Name = "dGv_diemdanh";
            this.dGv_diemdanh.ReadOnly = true;
            this.dGv_diemdanh.RowHeadersVisible = false;
            this.dGv_diemdanh.Size = new System.Drawing.Size(710, 312);
            this.dGv_diemdanh.TabIndex = 12;
            // 
            // rBt_absent
            // 
            this.rBt_absent.AutoSize = true;
            this.rBt_absent.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBt_absent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.rBt_absent.Location = new System.Drawing.Point(211, 71);
            this.rBt_absent.Name = "rBt_absent";
            this.rBt_absent.Size = new System.Drawing.Size(77, 23);
            this.rBt_absent.TabIndex = 7;
            this.rBt_absent.TabStop = true;
            this.rBt_absent.Text = "Absent";
            this.rBt_absent.UseVisualStyleBackColor = true;
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.tb_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(165)))), ((int)(((byte)(204)))));
            this.tb_search.Location = new System.Drawing.Point(294, 114);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(149, 20);
            this.tb_search.TabIndex = 9;
            // 
            // dTpfromdate
            // 
            this.dTpfromdate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dTpfromdate.CustomFormat = "ddMMyyyy";
            this.dTpfromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTpfromdate.Location = new System.Drawing.Point(110, 24);
            this.dTpfromdate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dTpfromdate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dTpfromdate.Name = "dTpfromdate";
            this.dTpfromdate.Size = new System.Drawing.Size(119, 20);
            this.dTpfromdate.TabIndex = 1;
            this.dTpfromdate.Value = new System.DateTime(2021, 5, 1, 21, 6, 0, 0);
            // 
            // rBt_none
            // 
            this.rBt_none.AutoSize = true;
            this.rBt_none.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBt_none.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.rBt_none.Location = new System.Drawing.Point(322, 71);
            this.rBt_none.Name = "rBt_none";
            this.rBt_none.Size = new System.Drawing.Size(65, 23);
            this.rBt_none.TabIndex = 8;
            this.rBt_none.TabStop = true;
            this.rBt_none.Text = "None";
            this.rBt_none.UseVisualStyleBackColor = true;
            // 
            // dTptodate
            // 
            this.dTptodate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dTptodate.CustomFormat = "ddMMyyyy";
            this.dTptodate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTptodate.Location = new System.Drawing.Point(268, 24);
            this.dTptodate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dTptodate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dTptodate.Name = "dTptodate";
            this.dTptodate.Size = new System.Drawing.Size(119, 20);
            this.dTptodate.TabIndex = 2;
            // 
            // lb_from
            // 
            this.lb_from.AutoSize = true;
            this.lb_from.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_from.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_from.Location = new System.Drawing.Point(58, 24);
            this.lb_from.Name = "lb_from";
            this.lb_from.Size = new System.Drawing.Size(46, 19);
            this.lb_from.TabIndex = 3;
            this.lb_from.Text = "From";
            // 
            // rBt_late
            // 
            this.rBt_late.AutoSize = true;
            this.rBt_late.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBt_late.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.rBt_late.Location = new System.Drawing.Point(110, 71);
            this.rBt_late.Name = "rBt_late";
            this.rBt_late.Size = new System.Drawing.Size(57, 23);
            this.rBt_late.TabIndex = 6;
            this.rBt_late.TabStop = true;
            this.rBt_late.Text = "Late";
            this.rBt_late.UseVisualStyleBackColor = true;
            // 
            // lb_to
            // 
            this.lb_to.AutoSize = true;
            this.lb_to.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_to.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_to.Location = new System.Drawing.Point(235, 24);
            this.lb_to.Name = "lb_to";
            this.lb_to.Size = new System.Drawing.Size(27, 19);
            this.lb_to.TabIndex = 4;
            this.lb_to.Text = "To";
            // 
            // bt_check
            // 
            this.bt_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.bt_check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_check.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.bt_check.Location = new System.Drawing.Point(405, 16);
            this.bt_check.Name = "bt_check";
            this.bt_check.Size = new System.Drawing.Size(85, 35);
            this.bt_check.TabIndex = 5;
            this.bt_check.Text = "Check";
            this.bt_check.UseVisualStyleBackColor = false;
            this.bt_check.Click += new System.EventHandler(this.bt_check_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.panel.Controls.Add(this.lb_search);
            this.panel.Controls.Add(this.rBt_absent);
            this.panel.Controls.Add(this.tb_search);
            this.panel.Controls.Add(this.dTpfromdate);
            this.panel.Controls.Add(this.rBt_none);
            this.panel.Controls.Add(this.dTptodate);
            this.panel.Controls.Add(this.lb_from);
            this.panel.Controls.Add(this.rBt_late);
            this.panel.Controls.Add(this.lb_to);
            this.panel.Controls.Add(this.bt_check);
            this.panel.Location = new System.Drawing.Point(161, 23);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(526, 156);
            this.panel.TabIndex = 13;
            // 
            // lb_search
            // 
            this.lb_search.AutoSize = true;
            this.lb_search.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_search.Location = new System.Drawing.Point(112, 114);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(176, 19);
            this.lb_search.TabIndex = 10;
            this.lb_search.Text = "Search with (ID,Name) :";
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_count.Location = new System.Drawing.Point(616, 500);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(94, 19);
            this.lb_count.TabIndex = 14;
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
            this.bt_x.Location = new System.Drawing.Point(713, 12);
            this.bt_x.Name = "bt_x";
            this.bt_x.Size = new System.Drawing.Size(36, 36);
            this.bt_x.TabIndex = 41;
            this.bt_x.Text = "X";
            this.bt_x.UseVisualStyleBackColor = false;
            this.bt_x.Click += new System.EventHandler(this.bt_x_Click);
            // 
            // lb_sort
            // 
            this.lb_sort.AutoSize = true;
            this.lb_sort.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_sort.Location = new System.Drawing.Point(26, 87);
            this.lb_sort.Name = "lb_sort";
            this.lb_sort.Size = new System.Drawing.Size(38, 19);
            this.lb_sort.TabIndex = 48;
            this.lb_sort.Text = "Sort";
            // 
            // bt_sortTuan
            // 
            this.bt_sortTuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.bt_sortTuan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_sortTuan.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sortTuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.bt_sortTuan.Location = new System.Drawing.Point(70, 106);
            this.bt_sortTuan.Name = "bt_sortTuan";
            this.bt_sortTuan.Size = new System.Drawing.Size(85, 35);
            this.bt_sortTuan.TabIndex = 47;
            this.bt_sortTuan.Text = "Tuần";
            this.bt_sortTuan.UseVisualStyleBackColor = false;
            this.bt_sortTuan.Click += new System.EventHandler(this.bt_sortTuan_Click);
            // 
            // bt_sortThang
            // 
            this.bt_sortThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.bt_sortThang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_sortThang.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sortThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.bt_sortThang.Location = new System.Drawing.Point(70, 57);
            this.bt_sortThang.Name = "bt_sortThang";
            this.bt_sortThang.Size = new System.Drawing.Size(85, 35);
            this.bt_sortThang.TabIndex = 46;
            this.bt_sortThang.Text = "Tháng";
            this.bt_sortThang.UseVisualStyleBackColor = false;
            this.bt_sortThang.Click += new System.EventHandler(this.bt_sortThang_Click);
            // 
            // ManageRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(765, 537);
            this.Controls.Add(this.lb_sort);
            this.Controls.Add(this.bt_sortTuan);
            this.Controls.Add(this.bt_sortThang);
            this.Controls.Add(this.bt_x);
            this.Controls.Add(this.dGv_diemdanh);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lb_count);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageRecordForm";
            this.Load += new System.EventHandler(this.ManageRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGv_diemdanh)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGv_diemdanh;
        private System.Windows.Forms.RadioButton rBt_absent;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.DateTimePicker dTpfromdate;
        private System.Windows.Forms.RadioButton rBt_none;
        private System.Windows.Forms.DateTimePicker dTptodate;
        private System.Windows.Forms.Label lb_from;
        private System.Windows.Forms.RadioButton rBt_late;
        private System.Windows.Forms.Label lb_to;
        private System.Windows.Forms.Button bt_check;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lb_search;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Button bt_x;
        private System.Windows.Forms.Label lb_sort;
        private System.Windows.Forms.Button bt_sortTuan;
        private System.Windows.Forms.Button bt_sortThang;
    }
}