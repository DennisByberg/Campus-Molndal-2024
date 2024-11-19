namespace campus_molndal_2024_oop._07_inheritance
{
    public static class Exercises1
    {
        // 1. Skapa en basklass Vehicle med följande egenskaper make(string), model(string), //year(int)
        // 2. Lägg till en metod StartEngine() som skriver ut att motorn startar.
        // 3a .Skapa två underklasser: //Car som ärver från Vehicle och har en specifik metod PlayRadio().
        // 3b. Motorcycle som ärver från Vehicle och har en specifik metod PopWheelie().
        // 4. Skapa objekt av typerna Car och Motorcycle.
        // 5. Använd egenskaperna och metoderna från basklassen Vehicle.
        // 6. Anropa de specifika metoderna PlayRadio() och PopWheelie().
        public static void PrintExercise1()
        {
            var car = new Car("Ford", "Focus", 2023);
            var motorcycle = new Motorcycle("Yamaha", "WR450F", 2021);

            car.PlayRadio();
            motorcycle.PopWheelie();
        }
    }
}
