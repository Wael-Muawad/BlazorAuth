using Last.Client.Entities;

namespace Last.Services.Students
{
    public interface IStudentService
    {
        Task<List<Student>> GetStudents();
        Task<Student> GetStudentById(Guid id);
        Task<Student> AddStudent(Student createDto);
        Task<bool> UpdateStudent(Student updateDto); 
        Task<bool> DeleteStudent(Guid id);
    }
}
