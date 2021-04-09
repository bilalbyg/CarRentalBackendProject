using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new Result(true,"Brand updated");
        }
    }
}
