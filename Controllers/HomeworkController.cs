using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Numerics;


[ApiController]
[Route("[controller]")]
public class HomeworkController : ControllerBase
{
    private readonly IHomework<Homework> _homeworkRepository;

    public HomeworkController(IHomework<Homework> homeworkRepository)
    {
        _homeworkRepository = homeworkRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var homework = await _homeworkRepository.GetAll();
            return Ok(homework);
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }

    [HttpPost]
    public async Task<IActionResult> Insert([FromBody] Homework homework)
    {
        try
        {
            _homeworkRepository.Insert(homework);
            return await GetAll();
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
            Console.WriteLine(error.StackTrace);
            return BadRequest();

        }
    }



    [HttpPut("{id}")]
    public async Task<IActionResult> Update(long id, [FromBody] Child child)
    {
        try
        {
            _homeworkRepository.Update(id, child.Id, child.Image, child.Comment, child.Annotation);
            return await GetAll();

        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
            Console.WriteLine(error.StackTrace);
            return BadRequest();
        }

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