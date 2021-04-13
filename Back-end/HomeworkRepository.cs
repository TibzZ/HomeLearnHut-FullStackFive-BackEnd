using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Threading.Tasks;
using System.Numerics;
using System.Linq;

public class HomeworkRepository : BaseRepository, IHomework<Homework>
{

    public HomeworkRepository(IConfiguration configuration) : base(configuration) { }

    public async Task<IEnumerable<Homework>> GetAll()
    {
        using var connection = CreateConnection();
        List<Homework> homework = (List<Homework>)await connection.QueryAsync<Homework>("SELECT * FROM Homework;");
        // IEnumerable<Homework> homework = await connection.QueryAsync<Homework>("SELECT * FROM Homework;");

        // get list of children
        // List<Children> children = (List<Children>)await connection.QueryAsync<Homework>("SELECT * FROM children;");

        // // iterate through the list and add it to the homework
        for (int i = 0; i < homework.Count; i++)
        {
            homework[i].children = (List<Children>)await connection.QueryAsync<Children>("SELECT * FROM children;");
        }




        return homework;
    }



    public async Task<Homework> Insert(Homework pupil)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleAsync<Homework>("INSERT INTO Pupils (Name, Dob, Avatar) VALUES (@Name, @Dob, @Avatar) RETURNING *;", pupil);
    }
}



// JUNK code

// public async Task Delete(long id)
// {
//     using var connection = CreateConnection();
//     await connection.ExecuteAsync("DELETE FROM Pupils WHERE Id = @Id;", new { Id = id });
// }

// public async Task<Pupil> Get(long id)
// {
//     using var connection = CreateConnection();
//     return await connection.QuerySingleAsync<Pupil>("SELECT * FROM Pupils WHERE Id = @Id;", new { Id = id });
// }

// public async Task<Pupil> Update(Pupil pupil)
// {
//     using var connection = CreateConnection();
//     return await connection.QuerySingleAsync<Pupil>("UPDATE Pupils SET Name = @Name, Dob = @Dob, Avatar = @Avatar WHERE Id = @Id RETURNING *", pupil);
// }