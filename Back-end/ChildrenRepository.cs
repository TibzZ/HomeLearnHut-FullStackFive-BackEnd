using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Threading.Tasks;
using System.Numerics;


public class ChildrenRepository : BaseRepository, IChildren<Children>
{

    public ChildrenRepository(IConfiguration configuration) : base(configuration) { }

    // more complex needed
    public async Task<IEnumerable<Children>> Get(long id)
    {
        using var connection = CreateConnection();

        return (List<Children>)await connection.QueryAsync<Children>(@"select (children.id, children.name, children.avatar,
childrensHomework.childId,
childrensHomework.image,childrensHomework.comment, childrensHomework.annotation
) from children
FULL OUTER JOIN
childrensHomework
on
children.id = childrensHomework.childId
    where childrensHomework.homeworkId=@Id;
", new { Id = id });

    }

    public async Task<Children> Update(Children homework)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleAsync<Children>("SELECT * FROM Homework WHERE Id = @Id;", homework);
        // using var connection = CreateConnection();
        // return await connection.QuerySingleAsync<Homework>("UPDATE Pupils SET Name = @Name, Dob = @Dob, Avatar = @Avatar WHERE Id = @Id RETURNING *", pupil);
    }

}