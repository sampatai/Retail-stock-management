
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Stock.UI.Model
{
    public class ProductModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get;  set; }
        public int StockIn { get;  set; }
        public decimal RetailPrice { get;  set; }
        public string CategoryName { get; set; }
    }
}
