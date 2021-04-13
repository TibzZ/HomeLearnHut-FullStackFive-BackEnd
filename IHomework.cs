using System.Collections.Generic;
using System.Threading.Tasks;
using System.Numerics;


public interface IHomework<T>
{
    Task<IEnumerable<T>> GetAll();

    void Insert(T t);

    //void Update(long id, T t);

    void Update(long id, long childId, string image, string comment, string annotation);

}