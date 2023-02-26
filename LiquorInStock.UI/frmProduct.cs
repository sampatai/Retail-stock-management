using Retail.Stock.Application.Common;
using Retail.Stock.Domain.Aggregates.Category;
using Retail.Stock.Domain.Aggregates.Product;
using Retail.Stock.Infrastructure.Repositories;
using Retail.Stock.UI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Retail.Stock.UI
{
    public partial class frmProduct : Form
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private int _pageSize = 25;
        private int _pageIndex = 1;
        private int _totalPages = 1;
        private int _totalRecords = 0;
        private int? _CategoryId = null;
        public string _productName = "";

        private BindingSource _bindingSource = new BindingSource();
        public frmProduct(ICategoryRepository categoryRepository,
            IProductRepository productRepository)
        {
            InitializeComponent();

            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            _LoadCategory();
            cmbCategory.SelectedIndex = -1;
            LoadData();
        }

        private void _LoadCategory()
        {
            // Create a new item with the "Please select" text
            var pleaseSelectItem = new { Id = 0, Name = "Please select" };

            // Get the list of categories from the repository
            List<Category> categories = _Category();

            // Insert the "Please select" item at the beginning of the list

            // Bind the list of categories to the ComboBox control
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "Id";


        }

        private List<Category> _Category()
        {
            return _categoryRepository.GetAll().ToList();
        }


        private void LoadData()
        {
            var category = _Category();
            // Get the data from your repository, filtered and sorted as needed
            var products = _productRepository.GetPage(_pageIndex, _pageSize, _productName, _CategoryId);
            var data = products.Result.Select(x => new ProductModel()
            {

                ProductId = x.Id,
                CategoryName = category.Where(s => s.Id.Equals(x.CategoryId)).FirstOrDefault()?.CategoryName,
                ProductName = x.ProductName,
                PurchasedPrice = x.PurchasedPrice,
                RetailPrice = x.RetailPrice,
                StockIn = x.StockIn,
            }).ToList();

            // Get the total number of records
            _totalRecords = products.TotalPage;

            // Calculate the total number of pages
            _totalPages = (int)Math.Ceiling((double)_totalRecords / _pageSize);
            dataGridView1.ReadOnly = true;
            // Set the data source of the binding source
            _bindingSource.DataSource = data;

            // Bind the binding source to the data grid view
            dataGridView1.DataSource = _bindingSource;
            // dataGridView1.AutoGenerateColumns = false;
            // Show the row numbers

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                {
                    e.Value = (e.RowIndex + 1) + ((_pageIndex - 1) * _pageSize);
                    e.FormattingApplied = false;
                }
            };

            dataGridView1.CurrentCellChanged += (sender, e) =>
            {
                var currentPage = _pageIndex;
                var totalPages = _totalPages;
                var totalRecords = _totalRecords;
                var pageSize = _pageSize;

                var displayInfo = string.Format("Page {0} of {1} ({2} records per page, {3} total records)",
                    currentPage, totalPages, pageSize, totalRecords);
                toolStripStatusLabel1.Text = displayInfo;
            };
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            if (_pageIndex != 1)
            {
                _pageIndex = 1;
                Category selectedCategory = (Category)cmbCategory.SelectedItem;
                if (selectedCategory is not null)
                {
                    _CategoryId = selectedCategory.Id;

                }
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    _productName = txtName.Text;
                }
                LoadData();
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (_pageIndex > 1)
            {
                _pageIndex--;
                Category selectedCategory = (Category)cmbCategory.SelectedItem;
                if (selectedCategory is not null)
                {
                    _CategoryId = selectedCategory.Id;

                }
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    _productName = txtName.Text;
                }
                LoadData();
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_pageIndex < _totalPages)
            {
                _pageIndex++;
                Category selectedCategory = (Category)cmbCategory.SelectedItem;
                if (selectedCategory is not null)
                {
                    _CategoryId = selectedCategory.Id;

                }
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    _productName = txtName.Text;
                }
                LoadData();
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            if (_pageIndex != _totalPages)
            {
                _pageIndex = _totalPages;
                Category selectedCategory = (Category)cmbCategory.SelectedItem;
                if (selectedCategory is not null)
                {
                    _CategoryId = selectedCategory.Id;

                }
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    _productName = txtName.Text;
                }
                LoadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Category selectedCategory = (Category)cmbCategory.SelectedItem;
                if (selectedCategory is null)
                {
                    throw new Exception("Please enter a category.");
                }
                // validate the form inputs
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    throw new Exception("Please enter a  name.");
                }
                if (!string.IsNullOrEmpty(TxtId.Text))
                {
                    var product = _productRepository.GetById(Convert.ToInt32(TxtId.Text));
                    product.SetProduct(selectedCategory.Id, txtName.Text);
                    _productRepository.Update(product);
                }
                else
                {
                    // Create a new product with the selected category and name
                    Product newProduct = new Product(selectedCategory.Id, txtName.Text);

                    // Save the new product to the repository
                    _productRepository.Add(newProduct);


                }

                // Display a message box to indicate that the product was saved
                MessageBox.Show("Product saved successfully.");

                // clear the form inputs

                _Refresh();
            }
            catch (Exception ex)
            {
                // show an error message if something goes wrong
                MessageBox.Show($"An error occurred: {ex.Message}");

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void _Refresh()
        {
            cmbCategory.Refresh();
            Category selectedCategory = (Category)cmbCategory.SelectedItem;
            _CategoryId = null;
            _productName = "";
            txtName.Clear();
            TxtId.Clear();
            cmbCategory.SelectedIndex = -1;
            LoadData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row's data
                var product = (ProductModel)_bindingSource[e.RowIndex];
                var productOne = _productRepository.GetById(product.ProductId);
                // Fill the win form with the selected row's data
                txtName.Text = product.ProductName;
                TxtId.Text = product.ProductId.ToString();
                cmbCategory.SelectedItem = product.CategoryName;
                cmbCategory.SelectedValue = productOne.CategoryId;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Category selectedCategory = (Category)cmbCategory.SelectedItem;
            if (selectedCategory is not null)
            {
                _CategoryId = selectedCategory.Id;

            }
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                _productName = txtName.Text;
            }
            LoadData();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var selectedProduct = dataGridView1.CurrentRow?.DataBoundItem as ProductModel;

            if (selectedProduct != null)
            {
                // Ask the user for confirmation
                var result = MessageBox.Show($"Are you sure you want to delete {selectedProduct.ProductName}?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Delete the product from the database
                        _productRepository.Remove(selectedProduct.ProductId);

                        // Refresh the data
                        _pageIndex = 1;
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the product: {ex.Message}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
