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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            btnFirstPage = new Button();
            BtnPreviousPage = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            panel2 = new Panel();
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
            ((System.ComponentModel.ISupportInitialize)categoryRepositoryBindingSource).BeginInit();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // categoryRepositoryBindingSource
            // 
            categoryRepositoryBindingSource.DataSource = typeof(Infrastructure.Repositories.CategoryRepository);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 433);
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
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnFirstPage);
            panel1.Controls.Add(BtnPreviousPage);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 392);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 41);
            panel1.TabIndex = 15;
            // 
            // button5
            // 
            button5.Location = new Point(84, 15);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 16;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(3, 15);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 15;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
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
            // button6
            // 
            button6.Location = new Point(345, 137);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 24;
            button6.Text = "Search";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 37);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 23;
            label3.Text = "Id";
            // 
            // TxtId
            // 
            TxtId.Location = new Point(305, 34);
            TxtId.Name = "TxtId";
            TxtId.ReadOnly = true;
            TxtId.Size = new Size(100, 23);
            TxtId.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(435, 137);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(301, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 23);
            txtName.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 106);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 19;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 66);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 18;
            label1.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(301, 63);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(229, 23);
            cmbCategory.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 200);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 192);
            panel3.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 192);
            dataGridView1.TabIndex = 6;
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
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Name = "frmProduct";
            Text = "frmProduct";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)categoryRepositoryBindingSource).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource categoryRepositoryBindingSource;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button btnFirstPage;
        private Button BtnPreviousPage;
        private Button button2;
        private Button button3;
        private Panel panel1;
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
    }
}