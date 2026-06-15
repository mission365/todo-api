using TodoApi.DTOs;
using TodoApi.Models;

namespace TodoApi.Repositories;

public interface ITodoRepository
{
    Task<List<TodoResponseDto>> GetAllAsync();
    Task<TodoResponseDto?> GetByIdAsync(int id);
    Task<TodoResponseDto> CreateAsync(TodoCreateDto createDto);
    Task<TodoResponseDto> UpdateAsync(int id, TodoUpdateDto updateDto);
    Task<bool> DeleteAsync(int id);

}