using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<Brand> GetById(int id);
        IResult Add(Brand entity);
        IResult Delete(Brand entity);
        IResult Update(Brand entity);
        IDataResult<List<Brand>> GetAll();
    }
}
