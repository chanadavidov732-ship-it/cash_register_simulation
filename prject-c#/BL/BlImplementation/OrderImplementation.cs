using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class OrderImplementation : IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public void DoOrder(Order o)
        {
            foreach (ProductInOrder p in o.ProductListInOrder)
            {
                Product realP = Tools.ConversDoProductToBoProduct(_dal.Product.Read(p.ProductId));
                _dal.Product.UpDate(Tools.ConversBoProductToDoProduct(new Product(
                realP.ProductId, realP.ProductName, realP.ProductCategory, realP.ProductQuntity - p.ProductOrderCount, realP.ProductPrice, realP.ProductDateCreat)));
            }
            Console.WriteLine("Order created!");
        }

        public void CalcTotalPriceForProduct(ProductInOrder p)
        {
            List<SaleInProduct> usedSales = new List<SaleInProduct>();
            int count = p.ProductOrderCount;
            double totalSum = 0;

            foreach (SaleInProduct sip in p.ListSaleInProductOrder)
            {
                if (count == 0)
                    break;

                if (count < sip.SaleCount)
                    continue;

                int times = count / sip.SaleCount;
                totalSum += times * sip.SalePrice;

                count = count % sip.SaleCount;

                usedSales.Add(sip);
            }

            totalSum += count * p.ProductPrice;

            p.ListSaleInProductOrder = usedSales;
            p.ProductTotalPrice = totalSum;
        }

        public void SearchSaleForProduct(ProductInOrder pin, bool forMember)
        {
            var Sales = from sale in _dal.Sale.ReadAll()
                        where sale.ProductId == pin.ProductId &&              
                              sale.SaleDateStart <= DateTime.Now &&       
                              sale.SaleDateEnd >= DateTime.Now &&             
                              pin.ProductOrderCount >= sale.Count &&         
                              (forMember || !sale.ForCustomerMember)   
                        orderby (sale.Price / sale.Count)               
                        select new SaleInProduct
                        {
                            SaleId = sale.SaleId,
                            SaleCount = sale.Count,
                            SalePrice = sale.Price,
                            SaleProductForCustomer = sale.ForCustomerMember
                        };

            pin.ListSaleInProductOrder = Sales.ToList();
        }

        public void CalcTotalPrice(Order o)
        {
            double sumOrder = 0;
            foreach (ProductInOrder p in o.ProductListInOrder)
            {
                sumOrder += p.ProductTotalPrice;
            }
            o.TotalPrice = sumOrder;
        }

        public List<SaleInProduct> AddProductToOrder(Order o, int id, int count)
        {
            Product pr = Tools.ConversDoProductToBoProduct(_dal.Product.Read(id));
            List<ProductInOrder> pi = o.ProductListInOrder;
            foreach (var item in pi)
            {
                if (item.ProductId == id)
                {
                    if (pr.ProductQuntity >= item.ProductOrderCount + count)
                    {
                        item.ProductOrderCount += count;
                        if (item.ProductOrderCount <= 0)
                        {
                            pi.Remove(item);
                            CalcTotalPrice(o);
                            return new List<SaleInProduct>();
                        }

                        SearchSaleForProduct(item, o.member);
                        CalcTotalPriceForProduct(item);
                        CalcTotalPrice(o);

                        return item.ListSaleInProductOrder; 
                    }
                    else
                        /////need to change the exception type and message
                        throw new BL_Dont_Faund_EntitysId_Exception("");
                }
            }
            if (pr.ProductQuntity >= count)
            {
                ProductInOrder newP= new ProductInOrder(id, pr.ProductName, pr.ProductPrice, count, new List<SaleInProduct>(), 0);  
                pi.Add(newP);
                SearchSaleForProduct(newP,o.member);
                CalcTotalPriceForProduct(newP);
                CalcTotalPrice(o);
                return newP.ListSaleInProductOrder; 
            }
            else
                /////need to change the exception type and message
                throw new BL_Dont_Faund_EntitysId_Exception("");
        }
    }
}
