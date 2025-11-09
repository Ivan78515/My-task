using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using BusinesLogica;

namespace WebApi.Controllers;
[ApiController]
[Route("Note")]
public class NoteController(INoteService noteService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateNoteAsync(string text)

    {
        await noteService.CreateAsync(text);

        return NoContent();
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetNoteAsync([FromRoute] int id)

    {
        var result = await noteService.GetByIdAsync(id);

        return Ok(result);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateNoteAsync([FromRoute] int id, [FromBody] string newText)

    {
        await noteService.UpdateAsync(id, newText);

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteNoteAsync([FromRoute] int id)
    {
        await noteService.DeleteAsync(id);
        return NoContent();
    }
}

