using System.Collections.Generic;
using System.Threading.Tasks;
using System.Numerics;


public interface IClassroom<T>
{
    Task<T> Get(long id);

    Task<T> Update(T t);

    // Task<IEnumerable<T>> GetAll();
    // // Task<T> Get(long id);
    // // Task Delete(long id);
    // // Task<T> Update(T t);
    // Task<T> Insert(T t);

}