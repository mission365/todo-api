using Microsoft.AspNetCore.Mvc;
using TodoApi.DTOs;
using TodoApi.Repositories;

namespace TodoApi.Controllers;

[Route("api/[controller]")]
[ApiController]

public class TodoController : ControllerBase
{
    private readonly ITodoRepository _todoRepository;

    public TodoController(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var todos = await _todoRepository.GetAllAsync();
        return Ok(todos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var todo = await _todoRepository.GetByIdAsync(id);
        if(todo == null)
        {
            return NotFound(new { message = "Todo not found"});
        }
        else
        {
            return Ok(todo);

        }
    }


    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TodoCreateDto createDto)
    {
        if(!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var createdTodo = await _todoRepository.CreateAsync(createDto);
        return CreatedAtAction(nameof(GetById), new { id = createdTodo.Id}, createdTodo);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] TodoUpdateDto updateDto)
    {
        var updatedTodo = await _todoRepository.UpdateAsync(id, updateDto);
        if(updatedTodo == null)
        {
            return NotFound(new { message = "Todo not found"});
        }
        else
        {
            return Ok(updatedTodo);
        }
    }

    [HttpDelete("{id}")]

    public async Task<IActionResult> Delete(int id)
    {
        var isDeleted = await _todoRepository.DeleteAsync(id);
        if(isDeleted)
        {
            return NoContent();
        }
        else
        {
            return NotFound(new { message = "Todo not found"});
        }
    }


}
