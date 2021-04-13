using System.Collections.Generic;
using System.Threading.Tasks;
using System.Numerics;


public interface IChild<T>
{
    Task<IEnumerable<T>> Get(long id);



    // Task<IEnumerable<T>> GetAll();
    // // Task<T> Get(long id);
    // // Task Delete(long id);
    // // Task<T> Update(T t);
    // Task<T> Insert(T t);

}