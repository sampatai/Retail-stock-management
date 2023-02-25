using Retail.Stock.Application.Common;
using Retail.Stock.Domain.Aggregates.Category;
using Retail.Stock.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail.Stock.UI
{
    public partial class frmCategory : Form
    {
        private readonly ICategoryRepository _categoryRepository;
        public frmCategory(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // validate the form inputs
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    throw new Exception("Please enter a category name.");
                }
                var category = new Category(txtName.Text);
                _categoryRepository.Add(category);
                MessageBox.Show("Category inserted successfully.");
                LoadData();
                // clear the form inputs
                txtName.Clear();
            }
            catch (Exception ex)
            {
                // show an error message if something goes wrong
                MessageBox.Show($"An error occurred: {ex.Message}");

            }

        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            //DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            //column1.DataPropertyName = "Id";
            //column1.HeaderText = "ID";
            //column1.Name = "IdColumn";
            //dataGridView1.Columns.Add(column1);

            //DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            //column2.DataPropertyName = "Name";
            //column2.HeaderText = "Name";
            //column2.Name = "NameColumn";
            //dataGridView1.Columns.Add(column2);
            dataGridView1.AutoGenerateColumns = false;
            var category = _categoryRepository.GetAll();
            dataGridView1.DataSource = category;
        }
    }
}
