namespace Retail.Stock.UI
{
    partial class frmProduct
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
            components = new System.ComponentModel.Container();
            categoryRepositoryBindingSource = new BindingSource(components);
            btnFirstPage = new Button();
            BtnPreviousPage = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            chkRemoveReadonly = new CheckBox();
            txtpurchased = new TextBox();
            txtSelling = new TextBox();
            txtStockIn = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button6 = new Button();
            label3 = new Label();
            TxtId = new TextBox();
            button1 = new Button();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbCategory = new ComboBox();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)categoryRepositoryBindingSource).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // categoryRepositoryBindingSource
            // 
            categoryRepositoryBindingSource.DataSource = typeof(Infrastructure.Repositories.CategoryRepository);
            // 
            // btnFirstPage
            // 
            btnFirstPage.Location = new Point(455, 6);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(75, 23);
            btnFirstPage.TabIndex = 9;
            btnFirstPage.Text = "First Page";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // BtnPreviousPage
            // 
            BtnPreviousPage.Location = new Point(539, 6);
            BtnPreviousPage.Name = "BtnPreviousPage";
            BtnPreviousPage.Size = new Size(75, 23);
            BtnPreviousPage.TabIndex = 10;
            BtnPreviousPage.Text = "Previous Page";
            BtnPreviousPage.UseVisualStyleBackColor = true;
            BtnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // button2
            // 
            button2.Location = new Point(624, 6);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Next Page";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnNextPage_Click;
            // 
            // button3
            // 
            button3.Location = new Point(707, 6);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Last Page";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnLastPage_Click;
            // 
            // button5
            // 
            button5.Location = new Point(104, 6);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 7;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(23, 6);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(chkRemoveReadonly);
            panel2.Controls.Add(txtpurchased);
            panel2.Controls.Add(txtSelling);
            panel2.Controls.Add(txtStockIn);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(TxtId);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cmbCategory);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 200);
            panel2.TabIndex = 16;
            // 
            // chkRemoveReadonly
            // 
            chkRemoveReadonly.AutoSize = true;
            chkRemoveReadonly.Location = new Point(668, 17);
            chkRemoveReadonly.Name = "chkRemoveReadonly";
            chkRemoveReadonly.Size = new Size(121, 19);
            chkRemoveReadonly.TabIndex = 30;
            chkRemoveReadonly.Text = "Remove Readonly";
            chkRemoveReadonly.UseVisualStyleBackColor = true;
            chkRemoveReadonly.CheckedChanged += chkRemoveReadonly_CheckedChanged;
            // 
            // txtpurchased
            // 
            txtpurchased.Location = new Point(468, 88);
            txtpurchased.Name = "txtpurchased";
            txtpurchased.ReadOnly = true;
            txtpurchased.Size = new Size(100, 23);
            txtpurchased.TabIndex = 29;
            // 
            // txtSelling
            // 
            txtSelling.Location = new Point(468, 56);
            txtSelling.Name = "txtSelling";
            txtSelling.ReadOnly = true;
            txtSelling.Size = new Size(100, 23);
            txtSelling.TabIndex = 28;
            // 
            // txtStockIn
            // 
            txtStockIn.Location = new Point(468, 21);
            txtStockIn.Name = "txtStockIn";
            txtStockIn.ReadOnly = true;
            txtStockIn.Size = new Size(100, 23);
            txtStockIn.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(352, 88);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 26;
            label6.Text = "Purchased Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(372, 53);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 25;
            label5.Text = "Selling Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(394, 24);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 24;
            label4.Text = "Stock In";
            // 
            // button6
            // 
            button6.Location = new Point(254, 118);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 4;
            button6.Text = "Search";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 27);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 23;
            label3.Text = "Id";
            // 
            // TxtId
            // 
            TxtId.Location = new Point(104, 24);
            TxtId.Name = "TxtId";
            TxtId.ReadOnly = true;
            TxtId.Size = new Size(100, 23);
            TxtId.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(566, 135);
            button1.Name = "button1";
            button1.Size = new Size(105, 41);
            button1.TabIndex = 5;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 23);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 96);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 19;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 56);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 18;
            label1.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(100, 53);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(229, 23);
            cmbCategory.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 200);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 255);
            panel3.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 203);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(statusStrip1);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(BtnPreviousPage);
            panel4.Controls.Add(btnFirstPage);
            panel4.Controls.Add(button2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 52);
            panel4.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 30);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 17;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(800, 455);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "frmProduct";
            Text = "frmProduct";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)categoryRepositoryBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource categoryRepositoryBindingSource;
        private Button btnFirstPage;
        private Button BtnPreviousPage;
        private Button button2;
        private Button button3;
        private Panel panel2;
        private Label label3;
        private TextBox TxtId;
        private Button button1;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private ComboBox cmbCategory;
        private Button button6;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button4;
        private Panel panel4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtpurchased;
        private TextBox txtSelling;
        private TextBox txtStockIn;
        private CheckBox chkRemoveReadonly;
    }
}