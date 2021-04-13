using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Numerics;


[ApiController]
[Route("[controller]")]
public class ChildController : ControllerBase
{
    private readonly IChild<Child> _childrenRepository;

    public ChildController(IChild<Child> childrenRepository)
    {
        _childrenRepository = childrenRepository;
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> Get(long id)
    {
        try
        {
            var children = await _childrenRepository.Get(id);
            return Ok(children);
        }
        catch (Exception)
        {
            return NotFound($"no homework with id {id}");
        }
    }



    // [HttpPut("{id}")]
    // public async Task<IActionResult> Update(long id, [FromBody] Child homework)
    // {
    //     try
    //     {
    //         var editPupil = await _childrenRepository.Update(new Child { Id = 1 });
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


}