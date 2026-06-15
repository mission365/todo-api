using AutoMapper;
using TodoApi.DTOs;
using TodoApi.Models;

namespace TodoApi.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<TodoItem, TodoResponseDto>(); // Model -> DTO (Database theke API te Data pathanor somoi)
        
        // DTO -> Model (API theke Database e save korar somoi)
        CreateMap<TodoCreateDto, TodoItem>();
        CreateMap<TodoUpdateDto, TodoItem>();
    }
}