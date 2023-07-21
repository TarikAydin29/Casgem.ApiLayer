using Casgem.BLL.Abstract;
using Casgem.DAL.Abstract;
using Casgem.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.BLL.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDAL customerDAL;

        public CustomerManager(ICustomerDAL customerDAL)
        {
            this.customerDAL = customerDAL;
        }
        public void TDelete(Customer t)
        {
            customerDAL.Delete(t);
        }

        public Customer TGetById(int id)
        {
            return customerDAL.GetById(id);
        }

        public List<Customer> TGetList()
        {
            return customerDAL.GetList();
        }

        public void TInsert(Customer t)
        {
            customerDAL.Insert(t);
        }

        public void TUpdate(Customer t)
        {
            customerDAL.Update(t);
        }
    }
}
