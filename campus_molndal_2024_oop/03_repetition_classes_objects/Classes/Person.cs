namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Person(string name, int age, string email)
        {
            Name = name;
            Age = age;
            Email = email;
        }
    }
}
