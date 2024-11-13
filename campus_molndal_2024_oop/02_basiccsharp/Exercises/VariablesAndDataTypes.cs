using System;

namespace campus_molndal_2024_oop._02_basiccsharp
{
    public static class VariablesAndDataTypes
    {
        public static void PrintExercise1and2()
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

            Console.WriteLine($"age har värdet {age} och är av typen {age.GetType().Name}");
            Console.WriteLine($"height har värdet {height} och är av typen {height.GetType().Name}");
            Console.WriteLine($"initial har värdet {initial} och är av typen {initial.GetType().Name}");
            Console.WriteLine($"name har värdet {name} och är av typen {name.GetType().Name}");
            Console.WriteLine($"isStudent har värdet {isStudent} och är av typen {isStudent.GetType().Name}");
        }
    }
}
