namespace Competition2_group4
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ID { get; set; }

        public Person(string name, string email, string id)
        {
            Name = name;
            Email = email;
            ID = id;
        }
    }
}