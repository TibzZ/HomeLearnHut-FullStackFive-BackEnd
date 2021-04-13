using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Threading.Tasks;
using System.Numerics;


public class ClassroomRepository : BaseRepository, IClassroom<Homework>
{

    public ClassroomRepository(IConfiguration configuration) : base(configuration) { }

    // more complex needed
    public async Task<Homework> Get(long id)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleAsync<Homework>("SELECT * FROM Homework WHERE Id = @Id;", new { Id = id });
    }

    public async Task<Homework> Update(Homework homework)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleAsync<Homework>("SELECT * FROM Homework WHERE Id = @Id;", homework);
        // using var connection = CreateConnection();
        // return await connection.QuerySingleAsync<Homework>("UPDATE Pupils SET Name = @Name, Dob = @Dob, Avatar = @Avatar WHERE Id = @Id RETURNING *", pupil);
    }

}