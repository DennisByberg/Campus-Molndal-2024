namespace campus_molndal_2024_oop._03_repetition_classes_objects
{
    public class Engine
    {
        public int Horsepower { get; set; }
        public string Type { get; set; }

        public Engine(int horsepower, string type)
        {
            Horsepower = horsepower;
            Type = type;
        }
    }
}
