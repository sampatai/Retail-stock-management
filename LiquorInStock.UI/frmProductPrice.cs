using Retail.Stock.Application.Common;
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
    public partial class frmProductPrice : Form
    {
        private readonly IProductPriceRepository _productPriceRepository;
        private readonly IProductRepository _productRepository;
        public frmProductPrice(IProductPriceRepository productPriceRepository, IProductRepository productRepository)
        {
            _productPriceRepository = productPriceRepository;
            InitializeComponent();
            _productRepository = productRepository;
        }
    }
}
