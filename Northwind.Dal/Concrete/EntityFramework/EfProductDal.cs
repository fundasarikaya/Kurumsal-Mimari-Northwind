﻿using Northwind.Dal.Abstract;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public IProductDal Get(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
