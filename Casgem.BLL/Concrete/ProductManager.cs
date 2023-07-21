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
    public class ProductManager : IProductService
    {
        private readonly IProductDAL productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            this.productDAL = productDAL;
        }
        public void TDelete(Product t)
        {
            productDAL.Delete(t);
        }

        public Product TGetById(int id)
        {
            return productDAL.GetById(id);
        }

        public List<Product> TGetList()
        {
            return productDAL.GetList();
        }

        public List<Product> TGetProductsWithCategories()
        {
            return productDAL.GetProductsWithCategories();
        }

        public void TInsert(Product t)
        {
            productDAL.Insert(t);
        }

        public void TUpdate(Product t)
        {
            productDAL.Update(t);
        }
    }
}
