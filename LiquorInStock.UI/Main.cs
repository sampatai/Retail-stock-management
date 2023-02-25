using Microsoft.Extensions.Logging;
using Retail.Stock.Application.Common;
using Retail.Stock.UI;

namespace LiquorInStock.UI
{
    public partial class Main : Form
    {
        //public Form1()
        //{


        //}
        private readonly ICategoryRepository _categoryRepository;
        private readonly ILogger _logger;
        private readonly IProductRepository _productRepository;
        private readonly IProductPriceRepository _productPriceRepository;
        public Main(ILogger<Main> logger,
            ICategoryRepository categoryRepository,
            IProductRepository productRepository,
            IProductPriceRepository productPriceRepository)
        {
            InitializeComponent();
            Size = new Size(1200, 800);
            _logger = logger;
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
            _productPriceRepository = productPriceRepository;
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
            TabPage tabPage3 = new TabPage("Product Purchase");
            tabPage3.Controls.Add(childForm3);
            tabControl1.TabPages.Add(tabPage3);

            // Show the first child form
            childForm3.Show();
        }
    }
}