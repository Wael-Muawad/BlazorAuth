namespace Last.Client.Entities
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string? Name { get; set; }


        //Nav
        public List<Course> Courses { get; set; }
    }
}
