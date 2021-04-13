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

            homework[i].children = (List<Child>)await connection.QueryAsync<Child>(@"
select children.id, children.name, children.avatar, childrensHomework.image,childrensHomework.comment, childrensHomework.annotation
from children
FULL OUTER JOIN
childrensHomework
on
children.id = childrensHomework.childId
 where homeworkId=@Id;", new { Id = homework[i].Id });


        }




        return homework;
    }


    // Upload homework
    //Task<Homework>
    public async void Insert(Homework homework)
    {
        using var connection = CreateConnection();

        // create homework record, returning just the id of the object
        Homework hw = await connection.QuerySingleAsync<Homework>("INSERT INTO homework (Name,Image,Datedue,Comment) VALUES (@Name,@Image,@Datedue,@Comment) RETURNING id;", homework);

        // get the empty "classroom" from the children table
        List<Child> children = (List<Child>)await connection.QueryAsync<Child>(@"select * from childrenWHERE id=@homeworkId;", hw.Id);


        // Now do the INSERTS for the linking database
        foreach (Child child in children)
        {
            //  INSERT INTO childrensHomework (homeworkid,childid) VALUES ()
            await connection.QuerySingleAsync<Homework>("INSERT INTO childrensHomework (homeworkid,childid) VALUES (@HomeworkId,@ChildId);"
            , new { HomeworkId = hw.Id, ChildId = child.Id });
        }

    }

    // Update is for Mark and Reject
    public async void Update(long id, long childId, string image, string comment, string annotation)
    {
        using var connection = CreateConnection();
        await connection.QuerySingleAsync<Child>(@"UPDATE childrensHomework 
        SET image = @Image, comment = @Comment, annotation = @Annotation
         WHERE homeworkid= @HomeworkId AND childid = @ChildId;",
         new
         {
             HomeworkId = id,
             ChildId = childId,
             Image = image,
             Comment = comment,
             Annotation = annotation
         });
    }


}