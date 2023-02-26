using Retail.Stock.Application.Common;
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

namespace Retail.Stock.UI
{
    public partial class frmProductSales : Form
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductSalesRepository _productSalesRepository;
        private BindingSource _bindingSource = new BindingSource();
        private DateTime _startDate = DateTime.Today.AddDays(-15);
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
                ProductName = productsList.Where(s => s.Id.Equals(x.ProductId)).FirstOrDefault()?.ProductName,
                Quantity = x.Quantity,
                //PurchasedPrice = x.Price,
                //TotaPurchasedPrice = x.Price * x.Quantity,
                //SellingPrice = x.SellingPrice,
                //TotalSellingPrice = x.SellingPrice * x.Quantity,
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
            }
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTotalPrice.Text) && !string.IsNullOrEmpty(txtQuantity.Text))
            {
                txtPrice.Text = (Convert.ToDecimal(txtTotalPrice.Text) / Convert.ToDecimal(txtQuantity.Text)).ToString();
            }
        }
    }
}
