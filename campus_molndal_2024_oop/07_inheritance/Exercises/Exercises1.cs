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

        // 1. Utvidga Vehicle-hierarkin genom att lägga till en underklass Truck.
        // 2. Truck ska ha en specifik metod LoadCargo().
        // 3. Lägg till en metod StopEngine() i basklassen Vehicle som skriver ut att motorn stannar.
        // 4. Använd Truck-objektet för att demonstrera arv av metoder och egenskaper från Vehicle samt den specifika LoadCargo()-metoden.
        // 5. Skapa ett objekt av typen Truck.
        // 6. Använd både ärvda och nya metoder för att visa hur trucken fungerar.
        public static void PrintExercise2()
        {
            var truck = new Truck("Ford", "F-Series", 2018);
            truck.StartEngine();
            truck.LoadCargo();
            truck.StopEngine();
        }
    }
}
