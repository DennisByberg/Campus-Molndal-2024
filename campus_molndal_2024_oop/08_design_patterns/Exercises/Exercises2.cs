using campus_molndal_2024_oop._08_design_patterns.Classes;
using System;

namespace campus_molndal_2024_oop._08_design_patterns.Exercises
{
    public static class Exercises2
    {
        public static void PrintExercise1()
        {
            // Implementerat Computer.cs
        }

        public static void PrintExercise2()
        {
            Computer gamingPC = new Computer.ComputerBuilder("Intel i9", "32GB")
                .SetStorage("1TB SSD")
                .SetGraphicsCard("NVIDIA RTX 3080")
                .Build();

            Computer officePC = new Computer.ComputerBuilder("Intel i5", "16GB")
                    .SetStorage("512GB SSD")
                    .Build();

            Console.WriteLine(gamingPC);
            Console.WriteLine(officePC);
        }
    }
}
