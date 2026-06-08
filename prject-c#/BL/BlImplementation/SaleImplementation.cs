using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class SaleImplementation:ISale
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;


        public int Create(BO.Sale item)
        {
            return _dal.Sale.Create(Tools.ConversBoSaleToDoSale(item));

        }
        public void Delete(int id)
        {
            _dal.Sale.Delete(id);
        }

        public BO.Sale? Read(Func<BO.Sale, bool> filter)
        {
            return _dal.Sale.Read(s => filter(s.ConversDoSaleToBoSale()))
                .ConversDoSaleToBoSale();
        }

        public BO.Sale? Read(int id)
        {
            return Tools.ConversDoSaleToBoSale(_dal.Sale.Read(id));
        }

        public List<BO.Sale> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                {
                    return _dal.Sale.ReadAll().Select(s => s.ConversDoSaleToBoSale()).ToList();
                }
                return _dal.Sale.ReadAll(s => filter(s.ConversDoSaleToBoSale()))
                .Select(s => s.ConversDoSaleToBoSale()).ToList();
            }
            catch
            {
                throw new Dont_Found_Id_Exception("There is not sales match to the filter");
            }
        }

        public void UpDate(BO.Sale item)
        {
            _dal.Sale.UpDate(Tools.ConversBoSaleToDoSale(item));
        }
        public bool IsExists(BO.Sale item)
        {
            try
            {
                _dal.Sale.Read(Tools.ConversBoSaleToDoSale(item).SaleId);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}
