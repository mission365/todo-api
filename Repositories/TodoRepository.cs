using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TodoApi.Data;
using TodoApi.DTOs;
using TodoApi.Models;

namespace TodoApi.Repositories;

public class TodoRepository : ITodoRepository
{

    private readonly TodoContext _context;
    private readonly IMapper _mapper;

    public TodoRepository(TodoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<TodoResponseDto>> GetAllAsync()
    {
        var todos = await _context.Todos.ToListAsync();
        return _mapper.Map<List<TodoResponseDto>>(todos);
    }

    public async Task<TodoResponseDto?> GetByIdAsync(int id)
    {
        var todo = await _context.Todos.FindAsync(id);
        return todo == null ? null : _mapper.Map<TodoResponseDto>(todo);
    }

    public async Task<TodoResponseDto> CreateAsync(TodoCreateDto createDto)
    {
        var todo = _mapper.Map<TodoItem>(createDto);
        _context.Todos.Add(todo);
        await _context.SaveChangesAsync();
        return _mapper.Map<TodoResponseDto>(todo);
    }

    public async Task<TodoResponseDto> UpdateAsync(int id, TodoUpdateDto updateDto)
    {
        var todo = await _context.Todos.FindAsync(id);
        if(todo == null) return null;

        _mapper.Map(updateDto, todo);
        await _context.SaveChangesAsync();
        return _mapper.Map<TodoResponseDto>(todo);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var todo = await _context.Todos.FindAsync(id);
        if(todo == null) return false;

        _context.Todos.Remove(todo);
        await _context.SaveChangesAsync();
        return true;

    }

    

    
}