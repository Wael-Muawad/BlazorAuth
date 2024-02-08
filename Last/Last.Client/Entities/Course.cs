namespace Last.Client.Entities
{
    public class Course
    {
        public Guid CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? Description { get; set; }

        

        //Nav
        public List<Student> Students { get; set; }
    }
}
