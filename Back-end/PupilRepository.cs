using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Threading.Tasks;
using System.Numerics;


public class PupilRepository : BaseRepository, IRepository<Pupil>
{

    public PupilRepository(IConfiguration configuration) : base(configuration) { }

    public async Task<IEnumerable<Pupil>> GetAll()
    {
        using var connection = CreateConnection();
        IEnumerable<Pupil> pupils = await connection.QueryAsync<Pupil>("SELECT * FROM Pupils;");
        return pupils;
    }

    public async Task Delete(long id)
    {
        using var connection = CreateConnection();
        await connection.ExecuteAsync("DELETE FROM Pupils WHERE Id = @Id;", new { Id = id });
    }

    public async Task<Pupil> Get(long id)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleAsync<Pupil>("SELECT * FROM Pupils WHERE Id = @Id;", new { Id = id });
    }

    public async Task<Pupil> Update(Pupil pupil)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleAsync<Pupil>("UPDATE Pupils SET Name = @Name, Dob = @Dob, Avatar = @Avatar WHERE Id = @Id RETURNING *", pupil);
    }

    public async Task<Pupil> Insert(Pupil pupil)
    {
        using var connection = CreateConnection();
        return await connection.QuerySingleAsync<Pupil>("INSERT INTO Pupils (Name, Dob, Avatar) VALUES (@Name, @Dob, @Avatar) RETURNING *;", pupil);
    }
}