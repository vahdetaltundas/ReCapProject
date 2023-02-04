using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<Color> GetById(int id);
        IResult Add(Color entity);
        IResult Delete(Color entity);
        IResult Update(Color entity);
        IDataResult<List<Color>> GetAll();
    }
}
