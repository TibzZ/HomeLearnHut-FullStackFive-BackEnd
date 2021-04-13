using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Numerics;


[ApiController]
[Route("[controller]")]
public class ClassroomController : ControllerBase
{
    private readonly IClassroom<Homework> _classroomRepository;

    public ClassroomController(IClassroom<Homework> classroomRepository)
    {
        _classroomRepository = classroomRepository;
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> Get(long id)
    {
        try
        {
            var homework = await _classroomRepository.Get(id);
            return Ok(homework);
        }
        catch (Exception)
        {
            return NotFound($"no homework with id {id}");
        }
    }



    [HttpPut("{id}")]
    public async Task<IActionResult> Update(long id, [FromBody] Homework homework)
    {
        try
        {
            var editPupil = await _classroomRepository.Update(new Homework { Id = 1 });
            return Ok(editPupil);
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
            Console.WriteLine(error.StackTrace);
            //handle exception
            return NotFound("no pupil updated");
        }
    }


}