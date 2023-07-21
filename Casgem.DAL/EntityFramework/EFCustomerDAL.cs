using Casgem.DAL.Abstract;
using Casgem.DAL.Concrete;
using Casgem.DAL.GenericRepositories;
using Casgem.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.DAL.EntityFramework
{
    public class EFCustomerDAL : GenericRepository<Customer>, ICustomerDAL
    {
        public EFCustomerDAL(Context context) : base(context)
        {
        }
    }
}
