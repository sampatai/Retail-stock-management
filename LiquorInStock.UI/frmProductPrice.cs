using Retail.Stock.Application.Common;
using Retail.Stock.Domain.Aggregates.Category;
using Retail.Stock.Domain.Aggregates.Product;
using Retail.Stock.UI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Retail.Stock.UI
{
    public partial class frmProductPrice : Form
    {
        private readonly IProductPriceRepository _productPriceRepository;
        private readonly IProductRepository _productRepository;

        private BindingSource _bindingSource = new BindingSource();
        private DateTime _startDate = DateTime.Today.AddDays(-15);
        private DateTime _endDate = DateTime.Today;
        private int? _productId = null;
        public frmProductPrice(IProductPriceRepository productPriceRepository, IProductRepository productRepository)
        {
            _productPriceRepository = productPriceRepository;
            InitializeComponent();
            _productRepository = productRepository;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = cmbType.SelectedItem?.ToString();
            if (selectedValue == "Carton")
            {
                txtPerQuantity.Visible = true;
                label3.Visible = true;
                txtPerQuantity.Text = string.Empty;
                txtCartonQuantity.Visible = true;
                label4.Visible = true;
                txtCartonQuantity.Text = string.Empty;

                txtCartonPrice.Visible = true;
                label2.Visible = true;
                txtCartonPrice.Text = string.Empty;
            }
            else
            {
                txtPerQuantity.Visible = false;
                label3.Visible = false;
                txtPerQuantity.Text = string.Empty;

                txtCartonQuantity.Visible = false;
                label4.Visible = false;
                txtCartonQuantity.Text = string.Empty;

                txtCartonPrice.Visible = false;
                label2.Visible = false;
                txtCartonPrice.Text = string.Empty;
            }
        }

        private void frmProductPrice_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = _startDate; dateTimePicker2.Value = _endDate;

            cmbType.SelectedIndex = 0;
            _LoadProduct();
            _LoadProductForSearch();

            comboBox1.SelectedIndex = -1;
            cmbProduct.SelectedIndex = -1;
            LoadData();
        }

        private void _LoadProduct(int? priductId = null)
        {
            IEnumerable<Product> products = Enumerable.Empty<Product>();
            // Get the list of categories from the repository
            if (priductId is null)
                products = _productRepository.GetAll();
            else
                products = _productRepository.GetAllById((int)priductId);
            // Insert the "Please select" item at the beginning of the list

            // Bind the list of categories to the ComboBox control
            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "Id";

        }

        private void _LoadProductForSearch()
        {

            // Get the list of categories from the repository
            IEnumerable<Product> products = _productRepository.GetAll();

            // Insert the "Please select" item at the beginning of the list

            // Bind the list of categories to the ComboBox control
            comboBox1.DataSource = products;
            comboBox1.DisplayMember = "ProductName";
            comboBox1.ValueMember = "Id";
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPerQuantity_TextChanged(object sender, EventArgs e)
        {
            var selectedValue = cmbType.SelectedItem?.ToString();
            if (selectedValue == "Carton" && !string.IsNullOrEmpty(txtPerQuantity.Text)
                && !string.IsNullOrEmpty(txtCartonQuantity.Text) && !string.IsNullOrEmpty(txtCartonPrice.Text))
            {
                int totalQuantity = (Convert.ToInt32(txtPerQuantity.Text) * Convert.ToInt32(txtCartonQuantity.Text));
                txtQuantity.Text = totalQuantity.ToString();
                txtPrice.Text = (Convert.ToDecimal(txtCartonPrice.Text) / Convert.ToDecimal(totalQuantity)).ToString("F2");
                txtTotalPrice.Text = txtCartonPrice.Text;
            }

        }

        private void txtCartonQuantity_Click(object sender, EventArgs e)
        {
            var selectedValue = cmbType.SelectedItem?.ToString();
            if (selectedValue == "Carton" && !string.IsNullOrEmpty(txtCartonQuantity.Text)
                && !string.IsNullOrEmpty(txtPerQuantity.Text) && !string.IsNullOrEmpty(txtCartonPrice.Text))
            {
                int totalQuantity = (Convert.ToInt32(txtCartonQuantity.Text) * Convert.ToInt32(txtPerQuantity.Text));
                txtQuantity.Text = totalQuantity.ToString();
                txtPrice.Text = (Convert.ToDecimal(txtCartonPrice.Text) / Convert.ToDecimal(totalQuantity)).ToString("F2");
                txtTotalPrice.Text = txtCartonPrice.Text;
            }
        }

        private void txtCartonPrice_TextChanged(object sender, EventArgs e)
        {
            var selectedValue = cmbType.SelectedItem?.ToString();
            if (selectedValue == "Carton" && !string.IsNullOrEmpty(txtCartonPrice.Text)
                && !string.IsNullOrEmpty(txtPerQuantity.Text) && !string.IsNullOrEmpty(txtCartonQuantity.Text))
            {
                int totalQuantity = (Convert.ToInt32(txtCartonQuantity.Text) * Convert.ToInt32(txtPerQuantity.Text));
                txtQuantity.Text = totalQuantity.ToString();
                txtPrice.Text = (Convert.ToDecimal(txtCartonPrice.Text) / Convert.ToDecimal(totalQuantity)).ToString("F2");
                txtTotalPrice.Text = txtCartonPrice.Text;
            }
        }
        private void LoadData()
        {
            _startDate = dateTimePicker1.Value;
            _endDate = dateTimePicker2.Value;
            _productId = string.IsNullOrEmpty(comboBox1.SelectedValue?.ToString()) ? null : Convert.ToInt32(comboBox1.SelectedValue);
            var products = _productPriceRepository
                .GetPage(_productId, _startDate, _endDate);
            List<Product> productsList = _productRepository.GetAll().ToList();
            var data = products.Select(x => new ProductPriceModel()
            {

                ProductPriceId = x.Id,
                ProductName = productsList.Where(s => s.Id.Equals(x.ProductId)).FirstOrDefault()?.ProductName,
                Quantity = x.Quantity,
                PurchasedPrice = x.Price,
                TotaPurchasedPrice = x.TotalPrice,
                SellingPrice = x.SellingPrice,
                TotalSellingPrice = x.SellingPrice * x.Quantity,
                Date = x.AddedOn
            }).ToList();

            // Set the data source of the binding source
            _bindingSource.DataSource = data;
            dataGridView1.ReadOnly = true;
            // Bind the binding source to the data grid view
            dataGridView1.DataSource = _bindingSource;
            // dataGridView1.AutoGenerateColumns = false;
            // Show the row numbers

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            int totalQuantity = 0;
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                totalQuantity += Convert.ToInt32(row.Cells["Quantity"].Value);
                totalAmount += Convert.ToDecimal(row.Cells["TotaPurchasedPrice"].Value);
            }
            var displayInfo = string.Format("Total Quantity: {0} || Total Amount: {1}",
                   totalQuantity, totalAmount.ToString("F"));
            lblTotalDisplay.Text = displayInfo;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Product selected = (Product)cmbProduct.SelectedItem;
                if (selected is null)
                {
                    throw new Exception("Please enter a Product.");
                }
                // validate the form inputs
                else if (string.IsNullOrWhiteSpace(txtQuantity.Text))
                {
                    throw new Exception("Please enter a  quantity.");
                }
                else if (string.IsNullOrWhiteSpace(txtSellingPrice.Text))
                {
                    throw new Exception("Please enter a  selling price.");
                }
                else if (string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    throw new Exception("Please enter a  price.");

                }
                else if (string.IsNullOrWhiteSpace(txtTotalPrice.Text))
                {
                    throw new Exception("Please enter a  price.");

                }
                var productsingle = _productRepository.GetById(selected.Id);
                if (string.IsNullOrEmpty(txId.Text))
                {
                    ProductPrice _productPrice = new(selected.Id, Convert.ToInt32(txtQuantity.Text),
                        Convert.ToDecimal(txtPrice.Text), Convert.ToDecimal(txtSellingPrice.Text), Convert.ToDecimal(txtTotalPrice.Text), todayDate.Value);

                    productsingle.SetPurchasedPrice(Convert.ToDecimal(txtPrice.Text));
                    productsingle.SetRetailPrice(Convert.ToDecimal(txtSellingPrice.Text));
                    productsingle.SetStockIn(Convert.ToInt32(txtQuantity.Text));

                    _productPrice.AddProduct(productsingle);

                    _productPriceRepository.Add(_productPrice);
                    _productRepository.Update(productsingle);
                }
                else
                {
                    ProductPrice productPrice = _productPriceRepository.GetById(int.Parse(txId.Text));
                    int remainingQuentity = (productsingle.StockIn + int.Parse(txtQuantity.Text)) - productPrice.Quantity;
                    if (remainingQuentity < 0)
                    {
                        throw new Exception($"When you're editing, the remaining item may appear as a negative value. Please review the quantity");
                    }

                    productPrice.SetDetail(
                   productsingle.Id,
                   int.Parse(txtQuantity.Text),
                   decimal.Parse(txtPrice.Text),
                   decimal.Parse(txtSellingPrice.Text), Convert.ToDecimal(txtTotalPrice.Text), todayDate.Value);



                    productsingle.SetPurchasedPrice(Convert.ToDecimal(txtPrice.Text));
                    productsingle.SetRetailPrice(Convert.ToDecimal(txtSellingPrice.Text));

                    productsingle.SetRemainingQuantity(remainingQuentity);
                    _productRepository.Update(productsingle);
                    _productPriceRepository.Update(productPrice);

                }


                MessageBox.Show("Product price saved successfully.");

                _Refresh();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }




        private void button4_Click(object sender, EventArgs e)
        {
            Refresh();
        }
        void _Refresh()
        {
            dateTimePicker1.Value = _startDate; dateTimePicker2.Value = _endDate;
            comboBox1.SelectedIndex = -1;
            _LoadProduct();
            comboBox1.Refresh();
            cmbProduct.Refresh();
            txId.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtSellingPrice.Clear();
            txtCartonPrice.Clear();
            txtCartonQuantity.Clear();
            txtPerQuantity.Clear();
            txtTotalPrice.Clear();
            todayDate.Value = DateTime.Today;
            cmbProduct.SelectedIndex = -1;
            LoadData();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row's data
                var product = (ProductPriceModel)_bindingSource[e.RowIndex];
                var productPrice = _productPriceRepository.GetById(product.ProductPriceId);
                _LoadProduct(productPrice.ProductId);
                // Fill the win form with the selected row's data
                txtQuantity.Text = product.Quantity.ToString();
                txId.Text = product.ProductPriceId.ToString();
                cmbProduct.SelectedValue = productPrice.ProductId;
                cmbProduct.SelectedItem = product.ProductName;
                txtPrice.Text = product.PurchasedPrice.ToString();
                txtSellingPrice.Text = product.SellingPrice.ToString();
                cmbProduct.SelectedItem = "Non-Carton";
                txtTotalPrice.Text = productPrice.TotalPrice.ToString("F");
                todayDate.Value = product.Date;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var selectedProduct = dataGridView1.CurrentRow?.DataBoundItem as ProductPriceModel;

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

                        ProductPrice productPrice = _productPriceRepository.GetById(selectedProduct.ProductPriceId);
                        var productsingle = _productRepository.GetById(productPrice.ProductId);
                        if (productsingle is not null)
                        {
                            int remainingQuentity = productsingle.StockIn - productPrice.Quantity;
                            productsingle.SetRemainingQuantity(remainingQuentity);
                            _productRepository.Update(productsingle);
                        }

                        _productPriceRepository.Remove(selectedProduct.ProductPriceId);
                        // Refresh the data

                        _Refresh();
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTotalPrice.Text) && !string.IsNullOrEmpty(txtQuantity.Text))
            {
                txtPrice.Text = (Convert.ToDecimal(txtTotalPrice.Text) / Convert.ToDecimal(txtQuantity.Text)).ToString("F");
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTotalPrice.Text))
            {
                if (!string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(txtQuantity.Text))
                {
                    txtTotalPrice.Text = (Convert.ToDecimal(txtPrice.Text) / Convert.ToDecimal(txtQuantity.Text)).ToString("F");
                }
            }

        }

        private void txtQuantity_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                if (!string.IsNullOrEmpty(txtTotalPrice.Text) && !string.IsNullOrEmpty(txtQuantity.Text))
                {
                    txtPrice.Text = (Convert.ToDecimal(txtTotalPrice.Text) / Convert.ToDecimal(txtQuantity.Text)).ToString("F");
                }
            }

        }
    }
}
