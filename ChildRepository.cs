using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Threading.Tasks;
using System.Numerics;


// A Test repo/controller
public class ChildRepository : BaseRepository, IChild<Child>
{

    public ChildRepository(IConfiguration configuration) : base(configuration) { }

    public async Task<IEnumerable<Child>> Get(long id)
    {
        using var connection = CreateConnection();

        return (List<Child>)await connection.QueryAsync<Child>(@"
select children.id, children.name, children.avatar, childrensHomework.image,childrensHomework.comment, childrensHomework.annotation
from children
FULL OUTER JOIN
childrensHomework
on
children.id = childrensHomework.childId
 where homeworkId=@Id;", new { Id = id });

    }



}