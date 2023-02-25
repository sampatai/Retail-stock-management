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
            panel2 = new Panel();
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
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Size = new Size(800, 699);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 354);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 345);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 100);
            panel5.Name = "panel5";
            panel5.Size = new Size(800, 245);
            panel5.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 245);
            dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 100);
            panel4.TabIndex = 0;
            // 
            // panel2
            // 
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
            panel2.Size = new Size(800, 354);
            panel2.TabIndex = 0;
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
            txtQuantity.Click += txtQuantity_TextChanged;
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
            button1.Location = new Point(368, 325);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 24;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Location = new Point(290, 278);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(100, 23);
            txtSellingPrice.TabIndex = 23;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(189, 281);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 21;
            label6.Text = "Selling Price";
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
            cmbType.TabIndex = 18;
            cmbType.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 84);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 17;
            label5.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 122);
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
            label2.Location = new Point(188, 154);
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
            // frmProductPrice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 699);
            Controls.Add(panel1);
            Name = "frmProductPrice";
            Text = "ProductPrice";
            Load += frmProductPrice_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}