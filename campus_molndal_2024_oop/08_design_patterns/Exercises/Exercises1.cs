using campus_molndal_2024_oop._08_design_patterns.Classes;

namespace campus_molndal_2024_oop._08_design_patterns.Exercises
{
    public static class Exercises1
    {
        // 1. Implementera ett Singleton-mönster i en klass som hanterar en applikationskonfiguration.
        // 2. Klassen ska ha metoder för att sätta och hämta olika konfigurationsinställningar.
        public static void PrintExercise1()
        {
            //AppManager.cs
        }

        // 1. Implementera ett Factory-mönster för att skapa olika typer av transportmedel(t.ex.Car, Bicycle, Bus).
        // 2. Låt fabriken returnera ett objekt baserat på användarens val.
        public static void PrintExercise2()
        {
            var car = VehicleFactory.CreateVehicle("Car");
            var bicycle = VehicleFactory.CreateVehicle("Bicycle");

            car.Drive(); // Output: Driving the car...
            bicycle.Drive(); // Output: Driving the bicycle...
        }
    }
}
