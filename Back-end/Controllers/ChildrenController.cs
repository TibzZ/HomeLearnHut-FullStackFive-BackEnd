using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Numerics;


[ApiController]
[Route("[controller]")]
// [Route("children")]
public class ChildrenController : ControllerBase
{
    private readonly IChildren<Children> _childrenRepository;

    public ChildrenController(IChildren<Children> childrenRepository)
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



    [HttpPut("{id}")]
    public async Task<IActionResult> Update(long id, [FromBody] Children homework)
    {
        try
        {
            var editPupil = await _childrenRepository.Update(new Children { Id = 1 });
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