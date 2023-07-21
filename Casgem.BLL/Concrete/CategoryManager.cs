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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            this.categoryDAL = categoryDAL;
        }
        public void TDelete(Category t)
        {
            categoryDAL.Delete(t);
        }

        public Category TGetById(int id)
        {
            return categoryDAL.GetById(id);
        }

        public List<Category> TGetList()
        {
            return categoryDAL.GetList();
        }

        public void TInsert(Category t)
        {
            categoryDAL.Insert(t);
        }

        public void TUpdate(Category t)
        {
            categoryDAL.Update(t);
        }
    }
}
