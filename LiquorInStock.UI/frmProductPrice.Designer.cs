namespace Retail.Stock.UI
{
    partial class frmProductPrice
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
            panel1 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            lblTotalDisplay = new Label();
            button5 = new Button();
            button6 = new Button();
            button4 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label10 = new Label();
            panel2 = new Panel();
            txtTotalPrice = new TextBox();
            label11 = new Label();
            label9 = new Label();
            txId = new TextBox();
            txtPrice = new TextBox();
            label8 = new Label();
            txtQuantity = new TextBox();
            label7 = new Label();
            button1 = new Button();
            txtSellingPrice = new TextBox();
            txtCartonPrice = new TextBox();
            label6 = new Label();
            txtPerQuantity = new TextBox();
            txtCartonQuantity = new TextBox();
            cmbType = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbProduct = new ComboBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            todayDate = new DateTimePicker();
            label12 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1015, 699);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 368);
            panel3.Name = "panel3";
            panel3.Size = new Size(1015, 331);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 95);
            panel5.Name = "panel5";
            panel5.Size = new Size(1015, 236);
            panel5.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1015, 236);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblTotalDisplay);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(dateTimePicker2);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(label10);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1015, 95);
            panel4.TabIndex = 0;
            // 
            // lblTotalDisplay
            // 
            lblTotalDisplay.AutoSize = true;
            lblTotalDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lblTotalDisplay.Location = new Point(761, 50);
            lblTotalDisplay.Name = "lblTotalDisplay";
            lblTotalDisplay.Size = new Size(0, 21);
            lblTotalDisplay.TabIndex = 23;
            // 
            // button5
            // 
            button5.Location = new Point(151, 50);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 17;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(857, 15);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 15;
            button6.Text = "Search";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(70, 50);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 16;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(625, 15);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(407, 15);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(96, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(278, 23);
            comboBox1.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 23);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 17;
            label10.Text = "Product";
            // 
            // panel2
            // 
            panel2.Controls.Add(label12);
            panel2.Controls.Add(todayDate);
            panel2.Controls.Add(txtTotalPrice);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txId);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtSellingPrice);
            panel2.Controls.Add(txtCartonPrice);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtPerQuantity);
            panel2.Controls.Add(txtCartonQuantity);
            panel2.Controls.Add(cmbType);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cmbProduct);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1015, 368);
            panel2.TabIndex = 0;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(290, 218);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(100, 23);
            txtTotalPrice.TabIndex = 8;
            txtTotalPrice.TextChanged += textBox1_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(205, 222);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 31;
            label11.Text = "Price Total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(215, 12);
            label9.Name = "label9";
            label9.Size = new Size(17, 15);
            label9.TabIndex = 30;
            label9.Text = "Id";
            // 
            // txId
            // 
            txId.Location = new Point(290, 4);
            txId.Name = "txId";
            txId.ReadOnly = true;
            txId.Size = new Size(100, 23);
            txId.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(490, 215);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 9;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(425, 220);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 27;
            label8.Text = "Price Per";
            label8.Click += label8_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(290, 179);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 7;
            txtQuantity.Click += txtQuantity_TextChanged;
            txtQuantity.TextChanged += txtQuantity_TextChanged_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(213, 184);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 25;
            label7.Text = "Quantity";
            // 
            // button1
            // 
            button1.Location = new Point(284, 312);
            button1.Name = "button1";
            button1.Size = new Size(106, 41);
            button1.TabIndex = 11;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Location = new Point(290, 257);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(100, 23);
            txtSellingPrice.TabIndex = 10;
            // 
            // txtCartonPrice
            // 
            txtCartonPrice.Location = new Point(490, 120);
            txtCartonPrice.Name = "txtCartonPrice";
            txtCartonPrice.Size = new Size(100, 23);
            txtCartonPrice.TabIndex = 5;
            txtCartonPrice.Visible = false;
            txtCartonPrice.TextChanged += txtCartonPrice_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(189, 262);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 21;
            label6.Text = "Selling Price";
            // 
            // txtPerQuantity
            // 
            txtPerQuantity.Location = new Point(290, 143);
            txtPerQuantity.Name = "txtPerQuantity";
            txtPerQuantity.Size = new Size(100, 23);
            txtPerQuantity.TabIndex = 6;
            txtPerQuantity.Visible = false;
            txtPerQuantity.TextChanged += txtPerQuantity_TextChanged;
            // 
            // txtCartonQuantity
            // 
            txtCartonQuantity.Location = new Point(290, 114);
            txtCartonQuantity.Name = "txtCartonQuantity";
            txtCartonQuantity.Size = new Size(100, 23);
            txtCartonQuantity.TabIndex = 4;
            txtCartonQuantity.Visible = false;
            txtCartonQuantity.Click += txtCartonQuantity_Click;
            txtCartonQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Non-Carton", "Carton" });
            cmbType.Location = new Point(290, 76);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(106, 23);
            cmbType.TabIndex = 3;
            cmbType.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 76);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 17;
            label5.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 117);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 16;
            label4.Text = "Carton Quantity";
            label4.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 146);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 15;
            label3.Text = "Quantity Per";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 122);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 14;
            label2.Text = "Carton Price";
            label2.Visible = false;
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(290, 33);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(300, 23);
            cmbProduct.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 41);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 12;
            label1.Text = "Product";
            // 
            // todayDate
            // 
            todayDate.Location = new Point(490, 249);
            todayDate.Name = "todayDate";
            todayDate.Size = new Size(200, 23);
            todayDate.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(447, 253);
            label12.Name = "label12";
            label12.Size = new Size(31, 15);
            label12.TabIndex = 33;
            label12.Text = "Date";
            // 
            // frmProductPrice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 699);
            Controls.Add(panel1);
            Name = "frmProductPrice";
            Text = "ProductPrice";
            Load += frmProductPrice_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtSellingPrice;
        private TextBox txtCartonPrice;
        private Label label6;
        private TextBox txtPerQuantity;
        private TextBox txtCartonQuantity;
        private ComboBox cmbType;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbProduct;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private TextBox txtQuantity;
        private Label label7;
        private TextBox txtPrice;
        private Label label8;
        private TextBox txId;
        private Label label9;
        private Button button5;
        private Button button4;
        private ComboBox comboBox1;
        private Label label10;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button button6;
        private Label lblTotalDisplay;
        private TextBox txtTotalPrice;
        private Label label11;
        private Label label12;
        private DateTimePicker todayDate;
    }
}