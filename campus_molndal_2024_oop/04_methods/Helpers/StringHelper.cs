namespace campus_molndal_2024_oop._04_methods.Helpers
{
    public static class StringHelper
    {
        public static string ReverseString(string input)
        {
            // Basfall: Om strängen är tom eller innehåller ett tecken, returnera den direkt
            if (input.Length == 0)
                return input;

            return ReverseString(input.Substring(1)) + input[0];
        }
    }
}
