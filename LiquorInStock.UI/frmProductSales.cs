using Retail.Stock.Application.Common;
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
    }
}
