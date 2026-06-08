using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ProductInOrder
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductOrderCount { get; set; }
        public List<SaleInProduct> ListSaleInProductOrder;
        public double ProductTotalPrice { get; set; }

        public ProductInOrder() {}
        public ProductInOrder(int ProductId, string ProductName, double ProductPrice, int productOrderCount, List<SaleInProduct> listSaleInProductOrder, double ProductTotalPrice)
        {
            this.ProductId = ProductId;
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
            this.ProductOrderCount = productOrderCount;
            this.ListSaleInProductOrder = listSaleInProductOrder;
            this.ProductTotalPrice = ProductTotalPrice;
        }

    }
}
