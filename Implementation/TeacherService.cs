

using UserService.Dto;
using UserService.Entitie;
using UserService.Interface;

namespace MyApp.Application.Services
{

    public class TeacherService : ITeacherService
    {
        private readonly IRepository<Teacher> _teacherRepository;

        public TeacherService(IRepository<Teacher> teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public async Task<TeacherDto> GetTeacherByIdAsync(int id)
        {
            var teacher = await _teacherRepository.GetByIdAsync(id);
            return new TeacherDto { Id = teacher.Id, Name = teacher.Name, Subject = teacher.Subject };
        }

        public async Task<IEnumerable<TeacherDto>> GetAllTeachersAsync()
        {
            var teachers = await _teacherRepository.GetAllAsync();
            return teachers.Select(t => new TeacherDto { Id = t.Id, Name = t.Name, Subject = t.Subject });
        }

        public async Task AddTeacherAsync(TeacherDto teacherDto)
        {
            var teacher = new Teacher { Id = teacherDto.Id, Name = teacherDto.Name, Subject = teacherDto.Subject };
            await _teacherRepository.AddAsync(teacher);
        }

        public async Task UpdateTeacherAsync(TeacherDto teacherDto)
        {
            var teacher = new Teacher { Id = teacherDto.Id, Name = teacherDto.Name, Subject = teacherDto.Subject };
            await _teacherRepository.UpdateAsync(teacher);
        }

        public async Task DeleteTeacherAsync(int id)
        {
            await _teacherRepository.DeleteAsync(id);
        }
    }
}
