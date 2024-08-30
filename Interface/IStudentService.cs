using UserService.Dto;

namespace UserService.Interface;

public interface IStudentService
{
    Task<StudentDto> GetStudentByIdAsync(int id);
    Task<IEnumerable<StudentDto>> GetAllStudentsAsync();
    Task AddStudentAsync(StudentDto student);
    Task UpdateStudentAsync(StudentDto student);
    Task DeleteStudentAsync(int id);
}