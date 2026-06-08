using BlApi;
using BO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class CustomerImplementation : ICustomer
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Customer item)
        {
            return _dal.Customer.Create(Tools.ConversBoCustomerToDoCustomer(item));

        }
        public void Delete(int id)
        {
            _dal.Customer.Delete(id);

        }

        public BO.Customer? Read(Func<BO.Customer, bool> filter)
        {
            return _dal.Customer.Read(c => filter(c.ConversDoCustomerToBoCustomer()))
                .ConversDoCustomerToBoCustomer();

        }

        public BO.Customer? Read(int id)
        {
            return Tools.ConversDoCustomerToBoCustomer(_dal.Customer.Read(id));

        }

        public List<BO.Customer> ReadAll(Func<BO.Customer, bool>? filter = null)
        {
            try
            {
                if (filter == null)
                {
                    return _dal.Customer.ReadAll().Select(c => c.ConversDoCustomerToBoCustomer()).ToList();
                }
                return _dal.Customer.ReadAll(c => filter(c.ConversDoCustomerToBoCustomer()))
                .Select(c => c.ConversDoCustomerToBoCustomer()).ToList();
            }
            catch
            {
                throw new Dont_Found_Id_Exception("There is not customers match to the filter");
            }

        }

        public void UpDate(BO.Customer item)
        {
            _dal.Customer.UpDate(Tools.ConversBoCustomerToDoCustomer(item));
        }
        public bool IsExists(BO.Customer item)
        {
            try{ 
                _dal.Customer.Read(Tools.ConversBoCustomerToDoCustomer(item).CustomerId); 
            }
            catch(Exception e) 
            {
                return false;
            }

            return true;
        }

    }
}
