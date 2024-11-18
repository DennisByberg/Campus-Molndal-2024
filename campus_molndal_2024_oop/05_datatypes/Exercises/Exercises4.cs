namespace campus_molndal_2024_oop._05_datatypes
{
    public static class Exercises4
    {
        // 1. Skapa en klass Team som innehåller en array av Player-objekt.
        // 2. Implementera metoder för att lägga till en spelare och lista alla spelare i teamet.
        public static void PrintExercise1()
        {
            var team = new Team(3);
            team.AddPlayer(new Player("Dennis", 10));
            team.AddPlayer(new Player("Eric", 19));
            team.AddPlayer(new Player("Niklas", 8));

            team.ListPlayers();
        }
    }
}
