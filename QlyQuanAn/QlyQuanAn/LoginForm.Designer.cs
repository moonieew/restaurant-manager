namespace QlyQuanAn
{
    partial class LoginForm
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
            this.bt_diemdanh = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.lb_pass = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.rBt_nhanvien = new System.Windows.Forms.RadioButton();
            this.rBt_quanly = new System.Windows.Forms.RadioButton();
            this.panel = new System.Windows.Forms.Panel();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.radioButtonCustom = new System.Windows.Forms.RadioButton();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_diemdanh
            // 
            this.bt_diemdanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(2)))), ((int)(((byte)(77)))));
            this.bt_diemdanh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_diemdanh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_diemdanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.bt_diemdanh.Location = new System.Drawing.Point(127, 300);
            this.bt_diemdanh.Name = "bt_diemdanh";
            this.bt_diemdanh.Size = new System.Drawing.Size(100, 44);
            this.bt_diemdanh.TabIndex = 11;
            this.bt_diemdanh.Text = "Điểm danh";
            this.bt_diemdanh.UseVisualStyleBackColor = false;
            this.bt_diemdanh.Click += new System.EventHandler(this.bt_diemdanh_Click);
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(2)))), ((int)(((byte)(77)))));
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_login.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.bt_login.Location = new System.Drawing.Point(175, 170);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(100, 44);
            this.bt_login.TabIndex = 9;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_pass.Location = new System.Drawing.Point(31, 84);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(76, 19);
            this.lb_pass.TabIndex = 10;
            this.lb_pass.Text = "Password";
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.tb_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(165)))), ((int)(((byte)(204)))));
            this.tb_pass.Location = new System.Drawing.Point(145, 84);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(147, 20);
            this.tb_pass.TabIndex = 8;
            this.tb_pass.Text = "123";
            this.tb_pass.UseSystemPasswordChar = true;
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.tb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(165)))), ((int)(((byte)(204)))));
            this.tb_id.Location = new System.Drawing.Point(145, 34);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(147, 20);
            this.tb_id.TabIndex = 6;
            this.tb_id.Text = "ql02";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_id.Location = new System.Drawing.Point(10, 34);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(108, 19);
            this.lb_id.TabIndex = 7;
            this.lb_id.Text = "Username(ID)";
            // 
            // rBt_nhanvien
            // 
            this.rBt_nhanvien.AutoSize = true;
            this.rBt_nhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.rBt_nhanvien.Location = new System.Drawing.Point(73, 119);
            this.rBt_nhanvien.Name = "rBt_nhanvien";
            this.rBt_nhanvien.Size = new System.Drawing.Size(75, 17);
            this.rBt_nhanvien.TabIndex = 12;
            this.rBt_nhanvien.TabStop = true;
            this.rBt_nhanvien.Text = "Nhân Viên";
            this.rBt_nhanvien.UseVisualStyleBackColor = true;
            // 
            // rBt_quanly
            // 
            this.rBt_quanly.AutoSize = true;
            this.rBt_quanly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.rBt_quanly.Location = new System.Drawing.Point(185, 119);
            this.rBt_quanly.Name = "rBt_quanly";
            this.rBt_quanly.Size = new System.Drawing.Size(65, 17);
            this.rBt_quanly.TabIndex = 13;
            this.rBt_quanly.TabStop = true;
            this.rBt_quanly.Text = "Quản Lý";
            this.rBt_quanly.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.panel.Controls.Add(this.radioButtonCustom);
            this.panel.Controls.Add(this.bt_cancel);
            this.panel.Controls.Add(this.lb_pass);
            this.panel.Controls.Add(this.rBt_quanly);
            this.panel.Controls.Add(this.bt_login);
            this.panel.Controls.Add(this.lb_id);
            this.panel.Controls.Add(this.rBt_nhanvien);
            this.panel.Controls.Add(this.tb_id);
            this.panel.Controls.Add(this.tb_pass);
            this.panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel.Location = new System.Drawing.Point(25, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(303, 236);
            this.panel.TabIndex = 14;
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(2)))), ((int)(((byte)(77)))));
            this.bt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cancel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.bt_cancel.Location = new System.Drawing.Point(35, 170);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(100, 44);
            this.bt_cancel.TabIndex = 14;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // radioButtonCustom
            // 
            this.radioButtonCustom.AutoSize = true;
            this.radioButtonCustom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.radioButtonCustom.Location = new System.Drawing.Point(117, 147);
            this.radioButtonCustom.Name = "radioButtonCustom";
            this.radioButtonCustom.Size = new System.Drawing.Size(83, 17);
            this.radioButtonCustom.TabIndex = 15;
            this.radioButtonCustom.TabStop = true;
            this.radioButtonCustom.Text = "Khách hàng";
            this.radioButtonCustom.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(358, 383);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.bt_diemdanh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_diemdanh;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.RadioButton rBt_nhanvien;
        private System.Windows.Forms.RadioButton rBt_quanly;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.RadioButton radioButtonCustom;
    }
}