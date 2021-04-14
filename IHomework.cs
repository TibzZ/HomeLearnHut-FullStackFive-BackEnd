using System.Collections.Generic;
using System.Threading.Tasks;
using System.Numerics;

public interface IHomework<T>
{
    Task<IEnumerable<T>> GetAll();
    Task Insert(T t);
    Task Update(long id, long childId, string image, string comment, string annotation);
}