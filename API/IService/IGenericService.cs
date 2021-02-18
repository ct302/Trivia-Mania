using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.IService
{
    public interface IGenericService<T>
    {

        List<T> GetAll();
        T GetById(string Id);
        List<T> Insert(T item);
        List<T> Delete(string Id);



    }
}
