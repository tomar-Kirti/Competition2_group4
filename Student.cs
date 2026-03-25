namespace Competition2_group4
{
    public class Student : Person
    {
        public string Major { get; set; }
        public int GraduationYear { get; set; }

        public Student(string name, string email, string id, string major, int graduationYear)
            : base(name, email, id)
        {
            Major = major;
            GraduationYear = graduationYear;
        }
    }
}