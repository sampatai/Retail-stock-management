using LiquorInStock.UI;
using Microsoft.Extensions.Logging;
using Retail.Stock.Application.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retail.Stock.UI
{
    public partial class LoginForm : Form
    {
        private readonly ICategoryRepository _categoryRepository;

        private readonly IProductRepository _productRepository;
        private readonly IProductPriceRepository _productPriceRepository;
        public LoginForm(ILogger<Main> logger,
            ICategoryRepository categoryRepository,
            IProductRepository productRepository,
            IProductPriceRepository productPriceRepository)
        {
            InitializeComponent();

            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
            _productPriceRepository = productPriceRepository;
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
            Thread.CurrentPrincipal = new WindowsPrincipal(identity);
            if (Thread.CurrentPrincipal.Identity.IsAuthenticated)
            {
                // Show the main form
                this.Hide();
                Main mainForm = new Main(_categoryRepository, _productRepository, _productPriceRepository);
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();
            }
            else
            {
                // Show an error message
                MessageBox.Show("Authentication failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
