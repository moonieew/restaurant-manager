namespace QlyQuanAn
{
    partial class AddScheduleForm
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
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.dGv_lich = new System.Windows.Forms.DataGridView();
            this.lb_thu = new System.Windows.Forms.Label();
            this.lb_ca2 = new System.Windows.Forms.Label();
            this.lb_ca1 = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.cb_thu = new System.Windows.Forms.ComboBox();
            this.cb_ca2 = new System.Windows.Forms.ComboBox();
            this.cb_ca1 = new System.Windows.Forms.ComboBox();
            this.cb_id = new System.Windows.Forms.ComboBox();
            this.bt_x = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_lich)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_thongbao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_thongbao.Location = new System.Drawing.Point(483, 405);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(186, 22);
            this.lb_thongbao.TabIndex = 28;
            this.lb_thongbao.Text = "Nhấp đôi để xoá hàng";
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.bt_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_update.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.bt_update.Location = new System.Drawing.Point(197, 342);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(106, 42);
            this.bt_update.TabIndex = 27;
            this.bt_update.Text = "Cập Nhật";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.bt_add.Location = new System.Drawing.Point(60, 342);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(106, 42);
            this.bt_add.TabIndex = 26;
            this.bt_add.Text = "Thêm";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // dGv_lich
            // 
            this.dGv_lich.AllowUserToAddRows = false;
            this.dGv_lich.AllowUserToDeleteRows = false;
            this.dGv_lich.AllowUserToResizeColumns = false;
            this.dGv_lich.AllowUserToResizeRows = false;
            this.dGv_lich.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGv_lich.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGv_lich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_lich.Location = new System.Drawing.Point(329, 81);
            this.dGv_lich.Name = "dGv_lich";
            this.dGv_lich.ReadOnly = true;
            this.dGv_lich.RowHeadersVisible = false;
            this.dGv_lich.Size = new System.Drawing.Size(437, 303);
            this.dGv_lich.TabIndex = 25;
            this.dGv_lich.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGv_lich_CellClick);
            this.dGv_lich.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGv_lich_CellDoubleClick);
            // 
            // lb_thu
            // 
            this.lb_thu.AutoSize = true;
            this.lb_thu.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_thu.Location = new System.Drawing.Point(35, 268);
            this.lb_thu.Name = "lb_thu";
            this.lb_thu.Size = new System.Drawing.Size(36, 19);
            this.lb_thu.TabIndex = 24;
            this.lb_thu.Text = "Day";
            // 
            // lb_ca2
            // 
            this.lb_ca2.AutoSize = true;
            this.lb_ca2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ca2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_ca2.Location = new System.Drawing.Point(35, 212);
            this.lb_ca2.Name = "lb_ca2";
            this.lb_ca2.Size = new System.Drawing.Size(39, 19);
            this.lb_ca2.TabIndex = 23;
            this.lb_ca2.Text = "Ca 2";
            // 
            // lb_ca1
            // 
            this.lb_ca1.AutoSize = true;
            this.lb_ca1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ca1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_ca1.Location = new System.Drawing.Point(35, 151);
            this.lb_ca1.Name = "lb_ca1";
            this.lb_ca1.Size = new System.Drawing.Size(39, 19);
            this.lb_ca1.TabIndex = 22;
            this.lb_ca1.Text = "Ca 1";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_id.Location = new System.Drawing.Point(35, 102);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(25, 19);
            this.lb_id.TabIndex = 21;
            this.lb_id.Text = "ID";
            // 
            // cb_thu
            // 
            this.cb_thu.FormattingEnabled = true;
            this.cb_thu.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cb_thu.Location = new System.Drawing.Point(117, 268);
            this.cb_thu.Name = "cb_thu";
            this.cb_thu.Size = new System.Drawing.Size(104, 21);
            this.cb_thu.TabIndex = 20;
            // 
            // cb_ca2
            // 
            this.cb_ca2.FormattingEnabled = true;
            this.cb_ca2.Items.AddRange(new object[] {
            "2",
            "3"});
            this.cb_ca2.Location = new System.Drawing.Point(117, 210);
            this.cb_ca2.Name = "cb_ca2";
            this.cb_ca2.Size = new System.Drawing.Size(78, 21);
            this.cb_ca2.TabIndex = 19;
            // 
            // cb_ca1
            // 
            this.cb_ca1.FormattingEnabled = true;
            this.cb_ca1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb_ca1.Location = new System.Drawing.Point(117, 151);
            this.cb_ca1.Name = "cb_ca1";
            this.cb_ca1.Size = new System.Drawing.Size(78, 21);
            this.cb_ca1.TabIndex = 18;
            // 
            // cb_id
            // 
            this.cb_id.FormattingEnabled = true;
            this.cb_id.Location = new System.Drawing.Point(117, 99);
            this.cb_id.Name = "cb_id";
            this.cb_id.Size = new System.Drawing.Size(172, 21);
            this.cb_id.TabIndex = 17;
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
            this.bt_x.Location = new System.Drawing.Point(752, 12);
            this.bt_x.Name = "bt_x";
            this.bt_x.Size = new System.Drawing.Size(36, 36);
            this.bt_x.TabIndex = 45;
            this.bt_x.Text = "X";
            this.bt_x.UseVisualStyleBackColor = false;
            this.bt_x.Click += new System.EventHandler(this.bt_x_Click);
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.bt_x);
            this.Controls.Add(this.lb_thongbao);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.dGv_lich);
            this.Controls.Add(this.lb_thu);
            this.Controls.Add(this.lb_ca2);
            this.Controls.Add(this.lb_ca1);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.cb_thu);
            this.Controls.Add(this.cb_ca2);
            this.Controls.Add(this.cb_ca1);
            this.Controls.Add(this.cb_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddScheduleForm";
            this.Text = "AddScheduleForm";
            this.Load += new System.EventHandler(this.AddScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGv_lich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_thongbao;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.DataGridView dGv_lich;
        private System.Windows.Forms.Label lb_thu;
        private System.Windows.Forms.Label lb_ca2;
        private System.Windows.Forms.Label lb_ca1;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.ComboBox cb_thu;
        private System.Windows.Forms.ComboBox cb_ca2;
        private System.Windows.Forms.ComboBox cb_ca1;
        private System.Windows.Forms.ComboBox cb_id;
        private System.Windows.Forms.Button bt_x;
    }
}