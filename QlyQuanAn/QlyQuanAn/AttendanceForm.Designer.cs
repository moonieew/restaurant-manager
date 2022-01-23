namespace QlyQuanAn
{
    partial class AttendanceForm
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
            this.bt_timein = new System.Windows.Forms.Button();
            this.bt_timeout = new System.Windows.Forms.Button();
            this.dGv_atten = new System.Windows.Forms.DataGridView();
            this.lb_pass = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.bt_x = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_atten)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_timein
            // 
            this.bt_timein.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.bt_timein.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_timein.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timein.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.bt_timein.Location = new System.Drawing.Point(261, 124);
            this.bt_timein.Name = "bt_timein";
            this.bt_timein.Size = new System.Drawing.Size(100, 44);
            this.bt_timein.TabIndex = 18;
            this.bt_timein.Text = "TimeIN";
            this.bt_timein.UseVisualStyleBackColor = false;
            this.bt_timein.Click += new System.EventHandler(this.bt_timein_Click);
            // 
            // bt_timeout
            // 
            this.bt_timeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.bt_timeout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_timeout.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timeout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.bt_timeout.Location = new System.Drawing.Point(418, 124);
            this.bt_timeout.Name = "bt_timeout";
            this.bt_timeout.Size = new System.Drawing.Size(100, 44);
            this.bt_timeout.TabIndex = 17;
            this.bt_timeout.Text = "TimeOUT";
            this.bt_timeout.UseVisualStyleBackColor = false;
            this.bt_timeout.Click += new System.EventHandler(this.bt_timeout_Click);
            // 
            // dGv_atten
            // 
            this.dGv_atten.AllowUserToAddRows = false;
            this.dGv_atten.AllowUserToDeleteRows = false;
            this.dGv_atten.AllowUserToOrderColumns = true;
            this.dGv_atten.AllowUserToResizeColumns = false;
            this.dGv_atten.AllowUserToResizeRows = false;
            this.dGv_atten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGv_atten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_atten.Location = new System.Drawing.Point(27, 187);
            this.dGv_atten.Name = "dGv_atten";
            this.dGv_atten.Size = new System.Drawing.Size(743, 282);
            this.dGv_atten.TabIndex = 16;
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_pass.Location = new System.Drawing.Point(257, 79);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(76, 19);
            this.lb_pass.TabIndex = 15;
            this.lb_pass.Text = "Password";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(371, 79);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(147, 20);
            this.tb_pass.TabIndex = 14;
            this.tb_pass.UseSystemPasswordChar = true;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(371, 29);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(147, 20);
            this.tb_id.TabIndex = 12;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_id.Location = new System.Drawing.Point(236, 29);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(108, 19);
            this.lb_id.TabIndex = 13;
            this.lb_id.Text = "Username(ID)";
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
            this.bt_x.Location = new System.Drawing.Point(749, 12);
            this.bt_x.Name = "bt_x";
            this.bt_x.Size = new System.Drawing.Size(36, 36);
            this.bt_x.TabIndex = 43;
            this.bt_x.Text = "X";
            this.bt_x.UseVisualStyleBackColor = false;
            this.bt_x.Click += new System.EventHandler(this.bt_x_Click);
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(801, 498);
            this.Controls.Add(this.bt_x);
            this.Controls.Add(this.bt_timein);
            this.Controls.Add(this.bt_timeout);
            this.Controls.Add(this.dGv_atten);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceForm";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGv_atten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_timein;
        private System.Windows.Forms.Button bt_timeout;
        private System.Windows.Forms.DataGridView dGv_atten;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Button bt_x;
    }
}