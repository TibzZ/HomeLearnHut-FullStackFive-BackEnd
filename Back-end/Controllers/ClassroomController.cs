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

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var allPupils = await _classroomRepository.GetAll();
            return Ok(allPupils);
        }
        catch (Exception)
        {
            return NoContent();
        }
    }

    // [HttpGet("{id}")]
    // public async Task<IActionResult> Get(long id)
    // {
    //     try
    //     {
    //         var pupil = await _pupilRepository.Get(id);
    //         return Ok(pupil);
    //     }
    //     catch (Exception)
    //     {
    //         return NotFound($"no pupil with id {id}");
    //     }
    // }

    // [HttpPost]
    // public async Task<IActionResult> Insert([FromBody] Pupil pupil)
    // {
    //     try
    //     {
    //         Console.WriteLine(ModelState.IsValid);
    //         var insertPupil = await _pupilRepository.Insert(pupil);
    //         return Ok(insertPupil);

    //     }
    //     catch (Exception error)
    //     {
    //         Console.WriteLine(error.Message);
    //         Console.WriteLine(error.StackTrace);
    //         //handle exception
    //         return BadRequest();
    //     }
    // }

    // [HttpPut("{id}")]
    // public async Task<IActionResult> Update(long id, [FromBody] Pupil pupil)
    // {
    //     try
    //     {
    //         var editPupil = await _pupilRepository.Update(new Pupil { Id = id, Name = pupil.Name, Dob = pupil.Dob, Avatar = pupil.Avatar });
    //         return Ok(editPupil);
    //     }
    //     catch (Exception error)
    //     {
    //         Console.WriteLine(error.Message);
    //         Console.WriteLine(error.StackTrace);
    //         //handle exception
    //         return NotFound("no pupil updated");
    //     }
    // }

    // [HttpDelete("{id}")]
    // public async Task<IActionResult> Delete(long id)
    // {
    //     try
    //     {
    //         await _pupilRepository.Delete(id);
    //         return NoContent();
    //     }
    //     catch (Exception)
    //     {
    //         return NotFound();
    //     }
    // }
}