using Core.DataAccess.EntityFramewok;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand,CarRentalContext>, IBrandDal
    {
        
    }
}
