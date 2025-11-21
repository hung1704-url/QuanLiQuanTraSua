namespace QuanLiQuanTraSua
{
    partial class AdminAddProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminProducts_clearBtn = new System.Windows.Forms.Button();
            this.adminProducts_deleteBtn = new System.Windows.Forms.Button();
            this.adminProducts_updateBtn = new System.Windows.Forms.Button();
            this.adminProducts_addBtn = new System.Windows.Forms.Button();
            this.adminProducts_importBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminAddProducts_imageView = new System.Windows.Forms.PictureBox();
            this.adminAddProducts_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adminAddProducts_stock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adminAddProducts_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adminAddProducts_type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adminAddProducts_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adminAddProducts_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminAddProducts_imageView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(14, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 303);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data of product";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeight = 10;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 254);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.adminProducts_clearBtn);
            this.panel2.Controls.Add(this.adminProducts_deleteBtn);
            this.panel2.Controls.Add(this.adminProducts_updateBtn);
            this.panel2.Controls.Add(this.adminProducts_addBtn);
            this.panel2.Controls.Add(this.adminProducts_importBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.adminAddProducts_status);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.adminAddProducts_stock);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.adminAddProducts_price);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.adminAddProducts_type);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.adminAddProducts_id);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.adminAddProducts_name);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(14, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 270);
            this.panel2.TabIndex = 1;
            // 
            // adminProducts_clearBtn
            // 
            this.adminProducts_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.adminProducts_clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminProducts_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminProducts_clearBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminProducts_clearBtn.ForeColor = System.Drawing.Color.White;
            this.adminProducts_clearBtn.Location = new System.Drawing.Point(708, 205);
            this.adminProducts_clearBtn.Name = "adminProducts_clearBtn";
            this.adminProducts_clearBtn.Size = new System.Drawing.Size(109, 42);
            this.adminProducts_clearBtn.TabIndex = 25;
            this.adminProducts_clearBtn.Text = "CLEAR";
            this.adminProducts_clearBtn.UseVisualStyleBackColor = false;
            this.adminProducts_clearBtn.Click += new System.EventHandler(this.adminProducts_clearBtn_Click);
            // 
            // adminProducts_deleteBtn
            // 
            this.adminProducts_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.adminProducts_deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminProducts_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminProducts_deleteBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminProducts_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.adminProducts_deleteBtn.Location = new System.Drawing.Point(572, 205);
            this.adminProducts_deleteBtn.Name = "adminProducts_deleteBtn";
            this.adminProducts_deleteBtn.Size = new System.Drawing.Size(109, 42);
            this.adminProducts_deleteBtn.TabIndex = 24;
            this.adminProducts_deleteBtn.Text = "DELETE";
            this.adminProducts_deleteBtn.UseVisualStyleBackColor = false;
            this.adminProducts_deleteBtn.Click += new System.EventHandler(this.adminProducts_deleteBtn_Click);
            // 
            // adminProducts_updateBtn
            // 
            this.adminProducts_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.adminProducts_updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminProducts_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminProducts_updateBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminProducts_updateBtn.ForeColor = System.Drawing.Color.White;
            this.adminProducts_updateBtn.Location = new System.Drawing.Point(270, 205);
            this.adminProducts_updateBtn.Name = "adminProducts_updateBtn";
            this.adminProducts_updateBtn.Size = new System.Drawing.Size(109, 42);
            this.adminProducts_updateBtn.TabIndex = 23;
            this.adminProducts_updateBtn.Text = "UPDATE";
            this.adminProducts_updateBtn.UseVisualStyleBackColor = false;
            this.adminProducts_updateBtn.Click += new System.EventHandler(this.adminProducts_updateBtn_Click);
            // 
            // adminProducts_addBtn
            // 
            this.adminProducts_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.adminProducts_addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminProducts_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminProducts_addBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminProducts_addBtn.ForeColor = System.Drawing.Color.White;
            this.adminProducts_addBtn.Location = new System.Drawing.Point(134, 205);
            this.adminProducts_addBtn.Name = "adminProducts_addBtn";
            this.adminProducts_addBtn.Size = new System.Drawing.Size(109, 42);
            this.adminProducts_addBtn.TabIndex = 22;
            this.adminProducts_addBtn.Text = "ADD";
            this.adminProducts_addBtn.UseMnemonic = false;
            this.adminProducts_addBtn.UseVisualStyleBackColor = false;
            this.adminProducts_addBtn.Click += new System.EventHandler(this.adminProducts_addBtn_Click);
            // 
            // adminProducts_importBtn
            // 
            this.adminProducts_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.adminProducts_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminProducts_importBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.adminProducts_importBtn.ForeColor = System.Drawing.Color.White;
            this.adminProducts_importBtn.Location = new System.Drawing.Point(882, 161);
            this.adminProducts_importBtn.Name = "adminProducts_importBtn";
            this.adminProducts_importBtn.Size = new System.Drawing.Size(111, 23);
            this.adminProducts_importBtn.TabIndex = 21;
            this.adminProducts_importBtn.Text = "import";
            this.adminProducts_importBtn.UseVisualStyleBackColor = false;
            this.adminProducts_importBtn.Click += new System.EventHandler(this.adminProducts_importBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.adminAddProducts_imageView);
            this.panel3.Location = new System.Drawing.Point(892, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(88, 100);
            this.panel3.TabIndex = 20;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // adminAddProducts_imageView
            // 
            this.adminAddProducts_imageView.Location = new System.Drawing.Point(0, 1);
            this.adminAddProducts_imageView.Name = "adminAddProducts_imageView";
            this.adminAddProducts_imageView.Size = new System.Drawing.Size(88, 99);
            this.adminAddProducts_imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminAddProducts_imageView.TabIndex = 0;
            this.adminAddProducts_imageView.TabStop = false;
            // 
            // adminAddProducts_status
            // 
            this.adminAddProducts_status.FormattingEnabled = true;
            this.adminAddProducts_status.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.adminAddProducts_status.Location = new System.Drawing.Point(624, 118);
            this.adminAddProducts_status.Name = "adminAddProducts_status";
            this.adminAddProducts_status.Size = new System.Drawing.Size(144, 21);
            this.adminAddProducts_status.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(561, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Status:";
            // 
            // adminAddProducts_stock
            // 
            this.adminAddProducts_stock.Location = new System.Drawing.Point(624, 45);
            this.adminAddProducts_stock.Name = "adminAddProducts_stock";
            this.adminAddProducts_stock.Size = new System.Drawing.Size(144, 20);
            this.adminAddProducts_stock.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(569, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Stock:";
            // 
            // adminAddProducts_price
            // 
            this.adminAddProducts_price.Location = new System.Drawing.Point(624, 82);
            this.adminAddProducts_price.Name = "adminAddProducts_price";
            this.adminAddProducts_price.Size = new System.Drawing.Size(144, 20);
            this.adminAddProducts_price.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(569, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price:";
            // 
            // adminAddProducts_type
            // 
            this.adminAddProducts_type.FormattingEnabled = true;
            this.adminAddProducts_type.Items.AddRange(new object[] {
            "Meal ",
            "Drink"});
            this.adminAddProducts_type.Location = new System.Drawing.Point(134, 116);
            this.adminAddProducts_type.Name = "adminAddProducts_type";
            this.adminAddProducts_type.Size = new System.Drawing.Size(144, 21);
            this.adminAddProducts_type.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Type:";
            // 
            // adminAddProducts_id
            // 
            this.adminAddProducts_id.Location = new System.Drawing.Point(134, 43);
            this.adminAddProducts_id.Name = "adminAddProducts_id";
            this.adminAddProducts_id.Size = new System.Drawing.Size(144, 20);
            this.adminAddProducts_id.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Product ID";
            // 
            // adminAddProducts_name
            // 
            this.adminAddProducts_name.Location = new System.Drawing.Point(134, 80);
            this.adminAddProducts_name.Name = "adminAddProducts_name";
            this.adminAddProducts_name.Size = new System.Drawing.Size(144, 20);
            this.adminAddProducts_name.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AdminAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddProducts";
            this.Size = new System.Drawing.Size(1061, 621);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminAddProducts_imageView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminAddProducts_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminAddProducts_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox adminAddProducts_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adminAddProducts_stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adminAddProducts_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox adminAddProducts_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button adminProducts_importBtn;
        private System.Windows.Forms.Button adminProducts_clearBtn;
        private System.Windows.Forms.Button adminProducts_deleteBtn;
        private System.Windows.Forms.Button adminProducts_updateBtn;
        private System.Windows.Forms.Button adminProducts_addBtn;
        private System.Windows.Forms.PictureBox adminAddProducts_imageView;
    }
}
