using Last.Client.Dtos.Student;
using Last.Client.Entities;
using Last.DataContext;

namespace Last.Services.Students
{
    public class StudentService : IStudentService
    {
        private readonly AppDBContext _context;

        public StudentService(AppDBContext context)
        {
            _context = context;
        }

        public Task<Student> AddStudent(Student createDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteStudent(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudentById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> GetStudents()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStudent(Student updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
