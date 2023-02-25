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
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    var category = _categoryRepository.GetById(Convert.ToInt32(txtId.Text));
                    category.SetDetails(txtName.Text);
                    _categoryRepository.Update(category);
                }
                else
                {
                    var category = new Category(txtName.Text);
                    _categoryRepository.Add(category);
                }

                MessageBox.Show("Category inserted successfully.");
                LoadData();
                // clear the form inputs
                txtName.Clear();
                txtId.Clear();
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
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ReadOnly = true;
            var category = _categoryRepository.GetAll();
            dataGridView1.DataSource = category;


        }




        private void button2_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // Display confirmation message with selected row(s) details
            string message = "";
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                // Get the row data
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                string name = row.Cells["CategoryName"].Value.ToString();

                // Append the row data to the confirmation message
                message += $"Id: {id}, Name: {name}\n";
            }

            // Display the confirmation message
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the following row(s)?\n\n{message}", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            // Delete the selected row(s) from the DataGridView and the database
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells["Id"].Value);

                // Delete the row from the database
                _categoryRepository.Delete(id);


            }

            MessageBox.Show("Selected row(s) have been deleted successfully.");
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                // Fill the text boxes with the values from the selected row
                txtId.Text = row.Cells["Id"].Value.ToString();
                txtName.Text = row.Cells["CategoryName"].Value.ToString();
            }
        }
    }
}
