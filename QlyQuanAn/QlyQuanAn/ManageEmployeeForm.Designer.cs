namespace QlyQuanAn
{
    partial class ManageEmployeeForm
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
            this.lb_total = new System.Windows.Forms.Label();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.dGv_employee = new System.Windows.Forms.DataGridView();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_author = new System.Windows.Forms.Label();
            this.cb_author = new System.Windows.Forms.ComboBox();
            this.lb_pic = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.bt_x = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lb_total.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_total.Location = new System.Drawing.Point(893, 418);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(74, 27);
            this.lb_total.TabIndex = 39;
            this.lb_total.Text = "Total :";
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.bt_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_search.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.bt_search.Location = new System.Drawing.Point(260, 379);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(40, 36);
            this.bt_search.TabIndex = 38;
            this.bt_search.Text = "...";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_delete.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.bt_delete.Location = new System.Drawing.Point(18, 465);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(112, 50);
            this.bt_delete.TabIndex = 37;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = false;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.bt_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_edit.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.bt_edit.Location = new System.Drawing.Point(145, 465);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(112, 50);
            this.bt_edit.TabIndex = 36;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = false;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_add.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.bt_add.Location = new System.Drawing.Point(273, 465);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(112, 50);
            this.bt_add.TabIndex = 35;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // dGv_employee
            // 
            this.dGv_employee.AllowUserToAddRows = false;
            this.dGv_employee.AllowUserToDeleteRows = false;
            this.dGv_employee.AllowUserToResizeColumns = false;
            this.dGv_employee.AllowUserToResizeRows = false;
            this.dGv_employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGv_employee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGv_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_employee.Location = new System.Drawing.Point(311, 86);
            this.dGv_employee.Name = "dGv_employee";
            this.dGv_employee.ReadOnly = true;
            this.dGv_employee.RowHeadersVisible = false;
            this.dGv_employee.RowTemplate.Height = 50;
            this.dGv_employee.RowTemplate.ReadOnly = true;
            this.dGv_employee.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dGv_employee.Size = new System.Drawing.Size(688, 329);
            this.dGv_employee.TabIndex = 34;
            this.dGv_employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGv_employee_CellContentClick);
            // 
            // pb_image
            // 
            this.pb_image.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pb_image.Location = new System.Drawing.Point(136, 297);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(118, 118);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_image.TabIndex = 33;
            this.pb_image.TabStop = false;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(136, 209);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(137, 20);
            this.tb_pass.TabIndex = 32;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(136, 166);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(137, 20);
            this.tb_phone.TabIndex = 31;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(136, 125);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(137, 20);
            this.tb_address.TabIndex = 30;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(136, 86);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(137, 20);
            this.tb_name.TabIndex = 29;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(136, 47);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(137, 20);
            this.tb_id.TabIndex = 28;
            // 
            // lb_author
            // 
            this.lb_author.AutoSize = true;
            this.lb_author.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_author.Location = new System.Drawing.Point(46, 249);
            this.lb_author.Name = "lb_author";
            this.lb_author.Size = new System.Drawing.Size(59, 19);
            this.lb_author.TabIndex = 27;
            this.lb_author.Text = "Author";
            // 
            // cb_author
            // 
            this.cb_author.FormattingEnabled = true;
            this.cb_author.Items.AddRange(new object[] {
            "Admin",
            "Member"});
            this.cb_author.Location = new System.Drawing.Point(136, 249);
            this.cb_author.Name = "cb_author";
            this.cb_author.Size = new System.Drawing.Size(121, 21);
            this.cb_author.TabIndex = 26;
            // 
            // lb_pic
            // 
            this.lb_pic.AutoSize = true;
            this.lb_pic.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_pic.Location = new System.Drawing.Point(46, 297);
            this.lb_pic.Name = "lb_pic";
            this.lb_pic.Size = new System.Drawing.Size(58, 19);
            this.lb_pic.TabIndex = 25;
            this.lb_pic.Text = "Picture";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_pass.Location = new System.Drawing.Point(46, 209);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(76, 19);
            this.lb_pass.TabIndex = 24;
            this.lb_pass.Text = "Password";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_phone.Location = new System.Drawing.Point(46, 166);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(53, 19);
            this.lb_phone.TabIndex = 23;
            this.lb_phone.Text = "Phone";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_address.Location = new System.Drawing.Point(46, 125);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(66, 19);
            this.lb_address.TabIndex = 22;
            this.lb_address.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.label1.Location = new System.Drawing.Point(46, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.lb_id.Location = new System.Drawing.Point(46, 47);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(25, 19);
            this.lb_id.TabIndex = 20;
            this.lb_id.Text = "ID";
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
            this.bt_x.Location = new System.Drawing.Point(964, 12);
            this.bt_x.Name = "bt_x";
            this.bt_x.Size = new System.Drawing.Size(36, 36);
            this.bt_x.TabIndex = 40;
            this.bt_x.Text = "X";
            this.bt_x.UseVisualStyleBackColor = false;
            this.bt_x.Click += new System.EventHandler(this.bt_x_Click);
            // 
            // ManageEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1016, 563);
            this.Controls.Add(this.bt_x);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.dGv_employee);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_author);
            this.Controls.Add(this.cb_author);
            this.Controls.Add(this.lb_pic);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageEmployeeForm";
            this.Load += new System.EventHandler(this.ManageEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGv_employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.DataGridView dGv_employee;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lb_author;
        private System.Windows.Forms.ComboBox cb_author;
        private System.Windows.Forms.Label lb_pic;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Button bt_x;
    }
}