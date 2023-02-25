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
        public Main(ILogger<Main> logger,
            ICategoryRepository categoryRepository,
            IProductRepository productRepository)
        {
            InitializeComponent();
            _logger = logger;
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _logger.LogInformation("Form1 {BusinessLayerEvent} at {dateTime}", "Started", DateTime.UtcNow);
                // Perform Business Logic here 

                MessageBox.Show("Hello .NET Core 3.1.This is First Forms app in .NET Core");
                _logger.LogInformation("Form1 {BusinessLayerEvent} at {dateTime}", "Ended", DateTime.UtcNow);
            }
            catch (Exception ex)
            {
                //Log technical exception 
                _logger.LogError(ex.Message);
            }
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
        }
    }
}