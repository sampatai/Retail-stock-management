namespace Retail.Stock.UI
{
    partial class frmProductSales
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
            panel2 = new Panel();
            label6 = new Label();
            todayDate = new DateTimePicker();
            label9 = new Label();
            txId = new TextBox();
            txtPrice = new TextBox();
            label8 = new Label();
            txtQuantity = new TextBox();
            label7 = new Label();
            button1 = new Button();
            txtCartonPrice = new TextBox();
            txtPerQuantity = new TextBox();
            txtCartonQuantity = new TextBox();
            cmbType = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmbProduct = new ComboBox();
            label1 = new Label();
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
            miniToolStrip = new StatusStrip();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(todayDate);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txId);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtCartonPrice);
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
            panel2.Size = new Size(1211, 392);
            panel2.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(207, 286);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 31;
            label6.Text = "Date";
            // 
            // todayDate
            // 
            todayDate.Location = new Point(290, 278);
            todayDate.Name = "todayDate";
            todayDate.Size = new Size(200, 23);
            todayDate.TabIndex = 24;
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
            txId.TabIndex = 29;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(290, 249);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(207, 252);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 27;
            label8.Text = "Price Per";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(290, 218);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(207, 221);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 25;
            label7.Text = "Quantity";
            // 
            // button1
            // 
            button1.Location = new Point(284, 320);
            button1.Name = "button1";
            button1.Size = new Size(106, 41);
            button1.TabIndex = 24;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtCartonPrice
            // 
            txtCartonPrice.Location = new Point(290, 151);
            txtCartonPrice.Name = "txtCartonPrice";
            txtCartonPrice.Size = new Size(100, 23);
            txtCartonPrice.TabIndex = 22;
            txtCartonPrice.Visible = false;
            txtCartonPrice.TextChanged += txtCartonPrice_TextChanged;
            // 
            // txtPerQuantity
            // 
            txtPerQuantity.Location = new Point(290, 188);
            txtPerQuantity.Name = "txtPerQuantity";
            txtPerQuantity.Size = new Size(100, 23);
            txtPerQuantity.TabIndex = 20;
            txtPerQuantity.Visible = false;
            txtPerQuantity.TextChanged += txtPerQuantity_TextChanged;
            // 
            // txtCartonQuantity
            // 
            txtCartonQuantity.Location = new Point(290, 114);
            txtCartonQuantity.Name = "txtCartonQuantity";
            txtCartonQuantity.Size = new Size(100, 23);
            txtCartonQuantity.TabIndex = 19;
            txtCartonQuantity.Visible = false;
            txtCartonQuantity.TextChanged += txtCartonQuantity_TextChanged;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Non-Carton", "Carton" });
            cmbType.Location = new Point(290, 76);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(106, 23);
            cmbType.TabIndex = 18;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
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
            label3.Location = new Point(191, 191);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 15;
            label3.Text = "Quantity Per";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 154);
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
            cmbProduct.TabIndex = 13;
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
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 392);
            panel3.Name = "panel3";
            panel3.Size = new Size(1211, 307);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 108);
            panel5.Name = "panel5";
            panel5.Size = new Size(1211, 199);
            panel5.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1211, 199);
            dataGridView1.TabIndex = 0;
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
            panel4.Size = new Size(1211, 108);
            panel4.TabIndex = 0;
            // 
            // lblTotalDisplay
            // 
            lblTotalDisplay.AutoSize = true;
            lblTotalDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lblTotalDisplay.Location = new Point(765, 97);
            lblTotalDisplay.Name = "lblTotalDisplay";
            lblTotalDisplay.Size = new Size(0, 21);
            lblTotalDisplay.TabIndex = 23;
            // 
            // button5
            // 
            button5.Location = new Point(151, 50);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 16;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(857, 15);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 21;
            button6.Text = "Search";
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(70, 50);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 15;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(625, 15);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(407, 15);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(96, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(278, 23);
            comboBox1.TabIndex = 18;
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
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "New item selection";
            miniToolStrip.AccessibleRole = AccessibleRole.ButtonDropDown;
            miniToolStrip.AutoSize = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.Location = new Point(1, 1);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Size = new Size(800, 22);
            miniToolStrip.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1211, 699);
            panel1.TabIndex = 1;
            // 
            // frmProductSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 699);
            Controls.Add(panel1);
            Name = "frmProductSales";
            Text = "frmProductSales";
            Load += frmProductSales_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label9;
        private TextBox txId;
        private TextBox txtPrice;
        private Label label8;
        private TextBox txtQuantity;
        private Label label7;
        private Button button1;
        private TextBox txtCartonPrice;
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
        private Panel panel5;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Label lblTotalDisplay;
        private Button button5;
        private Button button6;
        private Button button4;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label10;
        private StatusStrip miniToolStrip;
        private Panel panel1;
        private Label label6;
        private DateTimePicker todayDate;
    }
}