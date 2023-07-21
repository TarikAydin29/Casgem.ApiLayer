﻿using Casgem.DAL.Abstract;
using Casgem.DAL.Concrete;
using Casgem.DAL.GenericRepositories;
using Casgem.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.DAL.EntityFramework
{
    public class EFProductDAL : GenericRepository<Product>, IProductDAL
    {
        public EFProductDAL(Context context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            using var contex = new Context();
            return contex.Products.Include(x => x.Category).ToList();
        }
    }
}
