namespace QlyQuanAn
{
    partial class KitchenForm
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
            this.buttonDone = new System.Windows.Forms.Button();
            this.dataGridViewKitchen = new System.Windows.Forms.DataGridView();
            this.buttonLoadFood = new System.Windows.Forms.Button();
            this.bt_x = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitchen)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.buttonDone.Location = new System.Drawing.Point(592, 377);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(73, 23);
            this.buttonDone.TabIndex = 1;
            this.buttonDone.Text = "Xong món";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // dataGridViewKitchen
            // 
            this.dataGridViewKitchen.AllowUserToAddRows = false;
            this.dataGridViewKitchen.AllowUserToDeleteRows = false;
            this.dataGridViewKitchen.AllowUserToOrderColumns = true;
            this.dataGridViewKitchen.AllowUserToResizeColumns = false;
            this.dataGridViewKitchen.AllowUserToResizeRows = false;
            this.dataGridViewKitchen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitchen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewKitchen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitchen.Location = new System.Drawing.Point(27, 62);
            this.dataGridViewKitchen.Name = "dataGridViewKitchen";
            this.dataGridViewKitchen.ReadOnly = true;
            this.dataGridViewKitchen.RowHeadersVisible = false;
            this.dataGridViewKitchen.Size = new System.Drawing.Size(638, 295);
            this.dataGridViewKitchen.TabIndex = 2;
            this.dataGridViewKitchen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKitchen_CellClick);
            // 
            // buttonLoadFood
            // 
            this.buttonLoadFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(12)))), ((int)(((byte)(109)))));
            this.buttonLoadFood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLoadFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(207)))));
            this.buttonLoadFood.Location = new System.Drawing.Point(490, 377);
            this.buttonLoadFood.Name = "buttonLoadFood";
            this.buttonLoadFood.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadFood.TabIndex = 3;
            this.buttonLoadFood.Text = "Tải lại đơn";
            this.buttonLoadFood.UseVisualStyleBackColor = false;
            this.buttonLoadFood.Click += new System.EventHandler(this.button1_Click);
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
            this.bt_x.Location = new System.Drawing.Point(640, 12);
            this.bt_x.Name = "bt_x";
            this.bt_x.Size = new System.Drawing.Size(36, 36);
            this.bt_x.TabIndex = 41;
            this.bt_x.Text = "X";
            this.bt_x.UseVisualStyleBackColor = false;
            this.bt_x.Click += new System.EventHandler(this.bt_x_Click);
            // 
            // KitchenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(692, 422);
            this.Controls.Add(this.bt_x);
            this.Controls.Add(this.buttonLoadFood);
            this.Controls.Add(this.dataGridViewKitchen);
            this.Controls.Add(this.buttonDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitchenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitchenForm";
            this.Load += new System.EventHandler(this.KitchenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitchen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.DataGridView dataGridViewKitchen;
        private System.Windows.Forms.Button buttonLoadFood;
        private System.Windows.Forms.Button bt_x;
    }
}