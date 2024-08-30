

using UserService.Dto;
using UserService.Entitie;
using UserService.Interface;

namespace MyApp.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> _studentRepository;

        public StudentService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<StudentDto> GetStudentByIdAsync(int id)
        {
            var student = await _studentRepository.GetByIdAsync(id);
            return new StudentDto { Id = student.Id, Name = student.Name, Age = student.Age };
        }

        public async Task<IEnumerable<StudentDto>> GetAllStudentsAsync()
        {
            var students = await _studentRepository.GetAllAsync();
            return students.Select(s => new StudentDto { Id = s.Id, Name = s.Name, Age = s.Age });
        }

        public async Task AddStudentAsync(StudentDto studentDto)
        {
            var student = new Student { Id = studentDto.Id, Name = studentDto.Name, Age = studentDto.Age };
            await _studentRepository.AddAsync(student);
        }

        public async Task UpdateStudentAsync(StudentDto studentDto)
        {
            var student = new Student { Id = studentDto.Id, Name = studentDto.Name, Age = studentDto.Age };
            await _studentRepository.UpdateAsync(student);
        }

        public async Task DeleteStudentAsync(int id)
        {
            await _studentRepository.DeleteAsync(id);
        }
    }
}
