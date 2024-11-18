namespace campus_molndal_2024_oop._05_datatypes
{
    public class Animal
    {
        private readonly string _typeOfAnimal;

        public Animal(string typeOfAnimal)
        {
            _typeOfAnimal = typeOfAnimal;
        }

        public override string ToString()
        {
            return _typeOfAnimal;
        }
    }
}
