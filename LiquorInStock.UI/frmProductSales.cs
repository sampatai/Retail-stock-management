using Retail.Stock.Application.Common;
using Retail.Stock.Domain.Aggregates.Product;
using Retail.Stock.Infrastructure.Repositories;
using Retail.Stock.UI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail.Stock.UI
{
    public partial class frmProductSales : Form
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductSalesRepository _productSalesRepository;
        private BindingSource _bindingSource = new BindingSource();
        private DateTime _startDate = DateTime.Today;
        private DateTime _endDate = DateTime.Today;
        private int? _productId = null;
        public frmProductSales(IProductRepository productRepository,
            IProductSalesRepository productSalesRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
            _productSalesRepository = productSalesRepository;
        }

        private void frmProductSales_Load(object sender, EventArgs e)
        {
            todayDate.Value = DateTime.Today;
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
        private decimal _profitPer(List<Product> productsList, int ProductId, decimal price)
        {
            var productPurchasedPrice = productsList.Where(s => s.Id.Equals(ProductId)).FirstOrDefault();
            return price - Convert.ToDecimal(productPurchasedPrice?.PurchasedPrice);

        }
        private decimal _profitTotal(List<Product> productsList, int ProductId, decimal price, int quantity)
        {
            var productPurchasedPrice = productsList.Where(s => s.Id.Equals(ProductId)).FirstOrDefault();
            return price - (Convert.ToDecimal(productPurchasedPrice?.PurchasedPrice) * Convert.ToDecimal(quantity));

        }
        private void LoadData()
        {
            _startDate = dateTimePicker1.Value;
            _endDate = dateTimePicker2.Value;
            _productId = string.IsNullOrEmpty(comboBox1.SelectedValue?.ToString()) ? null : Convert.ToInt32(comboBox1.SelectedValue);
            var products = _productSalesRepository
                .GetPage(_productId, _startDate, _endDate);
            List<Product> productsList = _productRepository.GetAll().ToList();
            var data = products.Select(x => new ProductSalesModel()
            {

                ProductSalesId = x.Id,
                Date = x.AddedOn,
                ProductName = productsList.Where(s => s.Id.Equals(x.ProductId))
                .FirstOrDefault()?.ProductName,
                Quantity = x.Quantity,
                PricePer = x.Price,
                PurchasedPrice = productsList.Where(s => s.Id.Equals(x.ProductId))
                .FirstOrDefault()?.PurchasedPrice,
                ProfitPer = _profitPer(productsList, x.ProductId, x.Price),
                TotalPrice = x.TotalPrice,
                TotalProfit = _profitTotal(productsList, x.ProductId, x.TotalPrice, x.Quantity)

            }).ToList();

            // Set the data source of the binding source
            _bindingSource.DataSource = data;
            dataGridView1.ReadOnly = true;
            // Bind the binding source to the data grid view
            dataGridView1.DataSource = _bindingSource;
            // dataGridView1.AutoGenerateColumns = false;
            // Show the row numbers

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            decimal totalProfit = 0;
            decimal totalSalesAmount = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                totalProfit += Convert.ToInt32(row.Cells["TotalProfit"].Value);
                totalSalesAmount += Convert.ToDecimal(row.Cells["TotalPrice"].Value);
            }
            var displayInfo = string.Format("Total Sales: {0} || Total Profit: {1}",
                   totalSalesAmount.ToString("F"), totalProfit.ToString("F"));
            lblTotalDisplay.Text = displayInfo;

        }
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
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

        private void txtCartonQuantity_TextChanged(object sender, EventArgs e)
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

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTotalPrice.Text) && !string.IsNullOrEmpty(txtQuantity.Text))
            {
                txtPrice.Text = (Convert.ToDecimal(txtTotalPrice.Text) / Convert.ToDecimal(txtQuantity.Text)).ToString("F2");
            }
        }

        void _Refresh()
        {
            dateTimePicker1.Value = _startDate; dateTimePicker2.Value = _endDate;
            comboBox1.SelectedIndex = -1;
            comboBox1.Refresh();
            _LoadProduct();
            cmbProduct.Refresh();
            txId.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            todayDate.Value = DateTime.Today;
            txtCartonPrice.Clear();
            txtCartonQuantity.Clear();
            txtPerQuantity.Clear();
            txtTotalPrice.Clear();
            cmbProduct.SelectedIndex = -1;

            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _Refresh();
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
                else if (string.IsNullOrWhiteSpace(txtTotalPrice.Text))
                {
                    throw new Exception("Please enter a  Total price.");

                }
                else if (string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    throw new Exception("Please enter a  price.");

                }

                var productsingle = _productRepository.GetById(selected.Id);
                int remainingStock = (productsingle.StockIn - Convert.ToInt32(txtQuantity.Text));
                if (remainingStock < 0)
                {
                    throw new Exception($"You only have {productsingle.StockIn} number of item in stock (Out of stock:{(productsingle.StockIn - Convert.ToInt32(txtQuantity.Text))}");

                }
                if (productsingle.StockIn <= 0)
                {
                    throw new Exception($"The {selected.ProductName}  is currently out of stock. Please purchase it from the nearest shop.");
                }
                if (string.IsNullOrEmpty(txId.Text))
                {
                    ProductSales _productsales = new(selected.Id, Convert.ToInt32(txtQuantity.Text),
                        Convert.ToDecimal(txtPrice.Text), todayDate.Value, Convert.ToDecimal(txtTotalPrice.Text));

                    productsingle.SetStockOut(Convert.ToInt32(txtQuantity.Text));

                    _productsales.AddProduct(productsingle);

                    _productSalesRepository.Add(_productsales);
                    _productRepository.Update(productsingle);
                }
                else
                {
                    ProductSales productsales = _productSalesRepository.GetById(int.Parse(txId.Text));
                    int remainingQuentity = (productsingle.StockIn + productsales.Quantity) - int.Parse(txtQuantity.Text);


                    productsales.SetDetail(
                   productsingle.Id,
                   int.Parse(txtQuantity.Text),
                   decimal.Parse(txtPrice.Text),
                  todayDate.Value,
                  Convert.ToDecimal(txtTotalPrice.Text));

                    productsingle.SetRemainingQuantity(remainingQuentity);
                    _productRepository.Update(productsingle);
                    _productSalesRepository.Update(productsales);

                }


                MessageBox.Show("Product sales saved successfully.");

                _Refresh();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var selectedProduct = dataGridView1.CurrentRow?.DataBoundItem as ProductSalesModel;

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

                        ProductSales productSales = _productSalesRepository.GetById(selectedProduct.ProductSalesId);
                        var productsingle = _productRepository.GetById(productSales.ProductId);
                        if (productsingle is not null)
                        {
                            int remainingQuentity = productsingle.StockIn + productSales.Quantity;
                            productsingle.SetRemainingQuantity(remainingQuentity);
                            _productRepository.Update(productsingle);
                        }

                        _productSalesRepository.Remove(selectedProduct.ProductSalesId);
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

        private void button6_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row's data
                var product = (ProductSalesModel)_bindingSource[e.RowIndex];
                var productPrice = _productSalesRepository.GetById(product.ProductSalesId);
                _LoadProduct(productPrice.ProductId);
                // Fill the win form with the selected row's data
                txtQuantity.Text = product.Quantity.ToString();
                txId.Text = product.ProductSalesId.ToString();
                cmbProduct.SelectedValue = productPrice.ProductId;
                cmbProduct.SelectedItem = product.ProductName;
                txtPrice.Text = product.PricePer.ToString();
                cmbProduct.SelectedItem = "Non-Carton";
                txtTotalPrice.Text = productPrice.TotalPrice.ToString();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            var selectedValue = cmbType.SelectedItem?.ToString();
            if (selectedValue == "Carton" && !string.IsNullOrEmpty(txtPerQuantity.Text)
                && !string.IsNullOrEmpty(txtCartonQuantity.Text) && !string.IsNullOrEmpty(txtCartonPrice.Text))
            {
                int totalQuantity = (Convert.ToInt32(txtPerQuantity.Text) * Convert.ToInt32(txtCartonQuantity.Text));
                txtQuantity.Text = totalQuantity.ToString();
                txtPrice.Text = (Convert.ToDecimal(txtCartonPrice.Text) / Convert.ToDecimal(totalQuantity)).ToString("F2");
            }
            if (!string.IsNullOrEmpty(txtTotalPrice.Text) && !string.IsNullOrEmpty(txtQuantity.Text))
            {
                txtPrice.Text = (Convert.ToDecimal(txtTotalPrice.Text) / Convert.ToDecimal(txtQuantity.Text)).ToString("F2");
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTotalPrice.Text))
            {
                if (!string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(txtQuantity.Text))
                {
                    txtTotalPrice.Text = (Convert.ToDecimal(txtPrice.Text) / Convert.ToDecimal(txtQuantity.Text)).ToString("F2");
                }
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selected = (Product)cmbProduct.SelectedItem;
            if (selected is not null)
            {
                var productsingle = _productRepository.GetById(selected.Id);
                txtPrice.Text = productsingle.RetailPrice.ToString();
                txtTotalPrice.Text = productsingle.RetailPrice.ToString();
                txtQuantity.Text = "1";
            }
            else
            {
                txtPrice.Clear();
                txtQuantity.Clear();
                txtTotalPrice.Clear();
            }

        }
    }
}
