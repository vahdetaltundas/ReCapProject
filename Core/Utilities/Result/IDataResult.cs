using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public interface IDataResult<T>
    {
        T Data { get; }
    }
}
