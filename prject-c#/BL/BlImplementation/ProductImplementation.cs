using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BO.Tools;

namespace BlImplementation
{
    internal class ProductImplementation : IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Product item)
        {
            return _dal.Product.Create(Tools.ConversBoProductToDoProduct(item));

        }
        public void Delete(int id)
        {
            _dal.Product.Delete(id);
        }

        public BO.Product? Read(Func<BO.Product, bool> filter)
        {
            return _dal.Product.Read(p => filter(p.ConversDoProductToBoProduct())).ConversDoProductToBoProduct();

        }

        public BO.Product? Read(int id)
        {
            return Tools.ConversDoProductToBoProduct(_dal.Product.Read(id));
        }

        public List<BO.Product> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                {
                    return _dal.Product.ReadAll().Select(p=>p.ConversDoProductToBoProduct()).ToList();
                }
                return _dal.Product.ReadAll(p => filter(p.ConversDoProductToBoProduct()))
                .Select(p => p.ConversDoProductToBoProduct()).ToList();
            }
            catch
            {
                throw new Dont_Found_Id_Exception("There is no products match to the filter");
            }


        }

        public void UpDate(BO.Product item)
        {
            _dal.Product.UpDate(Tools.ConversBoProductToDoProduct(item));
        }
        public bool IsExists(BO.Product item)
        {
            try
            {
                _dal.Product.Read(Tools.ConversBoProductToDoProduct(item).ProductId);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
        ////////TO DO
        public void GetAllSale(ProductInOrder pio, bool isPrefer)
        {
            throw new NotImplementedException();
        }
    }
}
