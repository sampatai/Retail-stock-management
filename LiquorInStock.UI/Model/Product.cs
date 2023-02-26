
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
        public string CategoryName { get; set; }
        public string ProductName { get;  set; }      
        public decimal? PurchasedPrice { get; set; }
        public decimal RetailPrice { get;  set; }
        public int StockIn { get; set; }


    }

    public class ProductPriceModel
    {
        public int Id { get; set; }
        public int ProductPriceId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasedPrice { get; set; }     
        public decimal TotaPurchasedPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal TotalSellingPrice { get; set; } 

    }

    public class ProductSalesModel
    {
        public int Id { get; set; }
        public int ProductSalesId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal TotalProfit { get; set; }

    }
}
