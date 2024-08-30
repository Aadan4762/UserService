using UserService.Dto;

namespace UserService.Interface;

public interface ITeacherService
{
    Task<TeacherDto> GetTeacherByIdAsync(int id);
    Task<IEnumerable<TeacherDto>> GetAllTeachersAsync();
    Task AddTeacherAsync(TeacherDto teacher);
    Task UpdateTeacherAsync(TeacherDto teacher);
    Task DeleteTeacherAsync(int id);
}