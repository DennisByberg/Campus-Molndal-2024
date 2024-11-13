using System;

namespace campus_molndal_2024_oop._02_basiccsharp
{
    public static class VariablesAndDataTypes
    {
        public static void GetExercise1()
        {
            // En heltalsvariabel age med värdet 30.
            const int age = 30;
            // En flyttalsvariabel height med värdet 1.75.
            const float height = 1.75f;
            // En char-variabel initial med värdet 'A'.
            const char initial = 'A';
            // En strängvariabel name med värdet "Alice".
            const string name = "Alice";
            // En bool-variabel isStudentmed värdettrue`.
            const bool isStudent = true;

            Console.WriteLine(age);
            Console.WriteLine(height);
            Console.WriteLine(initial);
            Console.WriteLine(name);
            Console.WriteLine(isStudent);
        }
    }
}
