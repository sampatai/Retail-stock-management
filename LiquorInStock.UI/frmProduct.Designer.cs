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
            cmbCategory = new ComboBox();
            label1 = new Label();
            categoryRepositoryBindingSource = new BindingSource(components);
            label2 = new Label();
            txtName = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            TxtId = new TextBox();
            label3 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            btnFirstPage = new Button();
            BtnPreviousPage = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)categoryRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(276, 45);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(229, 23);
            cmbCategory.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 48);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Category";
            // 
            // categoryRepositoryBindingSource
            // 
            categoryRepositoryBindingSource.DataSource = typeof(Infrastructure.Repositories.CategoryRepository);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 88);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(276, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 23);
            txtName.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(430, 138);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 308);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 147);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // TxtId
            // 
            TxtId.Location = new Point(280, 16);
            TxtId.Name = "TxtId";
            TxtId.ReadOnly = true;
            TxtId.Size = new Size(100, 23);
            TxtId.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 19);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 7;
            label3.Text = "Id";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 286);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // btnFirstPage
            // 
            btnFirstPage.Location = new Point(435, 15);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(75, 23);
            btnFirstPage.TabIndex = 9;
            btnFirstPage.Text = "First Page";
            btnFirstPage.UseVisualStyleBackColor = true;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // BtnPreviousPage
            // 
            BtnPreviousPage.Location = new Point(519, 15);
            BtnPreviousPage.Name = "BtnPreviousPage";
            BtnPreviousPage.Size = new Size(75, 23);
            BtnPreviousPage.TabIndex = 10;
            BtnPreviousPage.Text = "Previous Page";
            BtnPreviousPage.UseVisualStyleBackColor = true;
            BtnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // button2
            // 
            button2.Location = new Point(604, 15);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Next Page";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnNextPage_Click;
            // 
            // button3
            // 
            button3.Location = new Point(676, 15);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Last Page";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnLastPage_Click;
            // 
            // button4
            // 
            button4.Location = new Point(8, 15);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 13;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(89, 15);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 14;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnFirstPage);
            panel1.Controls.Add(BtnPreviousPage);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 245);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 41);
            panel1.TabIndex = 15;
            // 
            // button6
            // 
            button6.Location = new Point(339, 138);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 16;
            button6.Text = "Search";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 455);
            Controls.Add(button6);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(label3);
            Controls.Add(TxtId);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCategory);
            Name = "frmProduct";
            Text = "frmProduct";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)categoryRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCategory;
        private Label label1;
        private BindingSource categoryRepositoryBindingSource;
        private Label label2;
        private TextBox txtName;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox TxtId;
        private Label label3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button btnFirstPage;
        private Button BtnPreviousPage;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel1;
        private Button button6;
    }
}