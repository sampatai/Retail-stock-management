using Microsoft.Extensions.Logging;
using Retail.Stock.Application.Common;
using Retail.Stock.Infrastructure.Repositories;
using Retail.Stock.UI;

namespace LiquorInStock.UI
{
    public partial class Main : Form
    {
        //public Form1()
        //{


        //}
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductSalesRepository _productSalesRepository;
        private readonly IProductRepository _productRepository;
        private readonly IProductPriceRepository _productPriceRepository;
        public Main(
            ICategoryRepository categoryRepository,
            IProductRepository productRepository,
            IProductPriceRepository productPriceRepository,
            IProductSalesRepository productSalesRepository)
        {
            InitializeComponent();
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            Size = new Size(1200, 800);

            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
            _productPriceRepository = productPriceRepository;
            _productSalesRepository = productSalesRepository;
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Product")
            {
                frmProduct childForm2 = (frmProduct)tabControl1.SelectedTab.Controls[0];
                childForm2.Refresh();
            }
            else if (tabControl1.SelectedTab.Text == "Product Purchased")
            {
                frmProductPrice childForm3 = (frmProductPrice)tabControl1.SelectedTab.Controls[0];
                childForm3.Refresh();
            }
           else if (tabControl1.SelectedTab.Text == "Category")
            {
                frmCategory childForm1 = (frmCategory)tabControl1.SelectedTab.Controls[0];
                childForm1.Refresh();
            }
            else if (tabControl1.SelectedTab.Text == "Product Sales")
            {
                frmProductSales childForm1 = (frmProductSales)tabControl1.SelectedTab.Controls[0];
                childForm1.Refresh();
            }

            // Add more else if statements for other child forms as needed
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Create an instance of the first child form
            frmCategory childForm1 = new frmCategory(_categoryRepository);
            childForm1.TopLevel = false;
            childForm1.FormBorderStyle = FormBorderStyle.None;
            childForm1.Dock = DockStyle.Fill;

            // Create a new tab page and add the first child form to it
            TabPage tabPage1 = new TabPage("Category");
            tabPage1.Controls.Add(childForm1);
            tabControl1.TabPages.Add(tabPage1);

            // Show the first child form
            childForm1.Show();

            // Create an instance of the first child form
            frmProduct childForm2 = new frmProduct(_categoryRepository, _productRepository);
            childForm2.TopLevel = false;
            childForm2.FormBorderStyle = FormBorderStyle.None;
            childForm2.Dock = DockStyle.Fill;

            // Create a new tab page and add the first child form to it
            TabPage tabPage2 = new TabPage("Product");
            tabPage2.Controls.Add(childForm2);
            tabControl1.TabPages.Add(tabPage2);

            // Show the first child form
            childForm2.Show();

            frmProductPrice childForm3 = new frmProductPrice(_productPriceRepository, _productRepository);
            childForm3.TopLevel = false;
            childForm3.FormBorderStyle = FormBorderStyle.None;
            childForm3.Dock = DockStyle.Fill;

            // Create a new tab page and add the first child form to it
            TabPage tabPage3 = new TabPage("Product Purchased");
            tabPage3.Controls.Add(childForm3);
            tabControl1.TabPages.Add(tabPage3);

            // Show the first child form
            childForm3.Show();
            _ProductSales();
        }
        private void _ProductSales()
        {
            frmProductSales childForm3 = new frmProductSales(_productRepository, _productSalesRepository);
            childForm3.TopLevel = false;
            childForm3.FormBorderStyle = FormBorderStyle.None;
            childForm3.Dock = DockStyle.Fill;

            // Create a new tab page and add the first child form to it
            TabPage tabPage3 = new TabPage("Product Sales");
            tabPage3.Controls.Add(childForm3);
            tabControl1.TabPages.Add(tabPage3);

            // Show the first child form
            childForm3.Show();
        }
    }
}