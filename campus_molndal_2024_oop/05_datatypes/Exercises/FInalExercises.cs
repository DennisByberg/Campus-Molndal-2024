using System;

namespace campus_molndal_2024_oop._05_datatypes
{
    public static class FInalExercises
    {
        // 1. Skapa en array med fem olika heltal.
        // 2. Skriv en metod som tar denna array som indata och returnerar summan av alla heltal i arrayen.
        // 3. Skriv en annan metod som räknar antalet jämna tal i arrayen och returnerar detta antal.
        // 4. Lägg till en metod som hittar det minsta värdet i arrayen och returnerar det.
        // 5. Se till att metoderna fungerar oavsett vilka tal som finns i arrayen.
        // 6. Testa metoderna genom att anropa dem från main-metoden och skriv ut resultaten.
        public static void PrintExercise1()
        {
            Console.WriteLine("--- FIRST TEST: { 1, 2, 3, 4, 5 } ---");
            var numbers = new int[5] { 1, 2, 3, 4, 5 };
            var sum = ArrayHelper.SumArray(numbers);
            var evenNumbers = ArrayHelper.EvenNumberCounter(numbers);
            var smallestNumber = ArrayHelper.GetSmallestNumberInArray(numbers);
            Console.WriteLine($"sum of numbers: {sum}");
            Console.WriteLine($"even numbers in numbers: {evenNumbers}");
            Console.WriteLine($"smallest number in numbers: {smallestNumber}");

            Console.WriteLine("\n--- SECOND TEST: { 73, 23, 33, 11, 2 } ---");
            var numbers2 = new int[5] { 73, 23, 33, 11, 2 };
            var sum2 = ArrayHelper.SumArray(numbers2);
            var evenNumbers2 = ArrayHelper.EvenNumberCounter(numbers2);
            var smallestNumber2 = ArrayHelper.GetSmallestNumberInArray(numbers2);
            Console.WriteLine($"sum of numbers: {sum2}");
            Console.WriteLine($"even numbers in numbers: {evenNumbers2}");
            Console.WriteLine($"smallest number in numbers: {smallestNumber2}");
        }

        // 1. Skapa en array med tio heltal.
        // 2. Implementera en metod för att sortera arrayen i stigande ordning utan att använda inbyggda sorteringsfunktioner.
        // 3. Implementera en linjär sökning i arrayen som letar efter ett specifikt tal och returnerar indexet där talet finns. Om talet inte finns i arrayen, returnera -1.
        // 4. Gör en metod som returnerar hur många gånger ett specifikt tal förekommer i arrayen.
        // 5. Testa att söka efter tal både före och efter att arrayen har sorterats.
        // 6. Använd sorteringsmetoden innan du letar efter ett specifikt tal för att säkerställa att arrayen är i rätt ordning.
        public static void PrintExercise2()
        {
            int[] numbers = new int[] { 10, 3, 5, 1, 4, 9, 8, 2, 7, 6 };
            Console.WriteLine("Original array:");
            PrintHelper.PrintArray(numbers);

            // Sortera arrayen
            SortHelper.BubbleSort(numbers);
            Console.WriteLine("\nSorted array:");
            PrintHelper.PrintArray(numbers);

            // Sök efter ett tal före sortering
            int searchNumber = 5;
            int index = ArrayHelper.LinearSearch(numbers, searchNumber);
            if (index != -1)
                Console.WriteLine($"\nNumber {searchNumber} found at index {index}.");
            else
                Console.WriteLine($"\nNumber {searchNumber} not found.");

            // Räkna förekomster av ett specifikt tal
            int count = ArrayHelper.CountOccurrences(numbers, searchNumber);
            Console.WriteLine($"\nNumber {searchNumber} occurs {count} times in the array.");
        }

        // 1. Skapa en klass Book med attributen title, author, och year.
        // 2. Skapa en lista för att lagra flera Book-objekt.
        // 3. Implementera en metod som lägger till en ny bok i listan.
        // 4. Skapa en metod som tar bort en bok från listan baserat på titeln.
        // 5. Gör en metod som söker efter en bok i listan baserat på författarens namn och returnerar alla böcker som matchar.
        // 6. Se till att metoderna hanterar situationer där boken inte finns eller där listan är tom.
        // 7. Implementera en metod som listar alla böcker i listan i kronologisk ordning baserat på årtal.
        public static void PrintExercise3()
        {
            var library = new Library();

            library.AddBook(new Book("The Hobbit", "J.R.R. Tolkien", 1937));
            library.AddBook(new Book("1984", "George Orwell", 1949));
            library.AddBook(new Book("Animal Farm", "George Orwell", 1945));
            library.AddBook(new Book("The Silmarillion", "J.R.R. Tolkien", 1977));
            library.AddBook(new Book("Brave New World", "Aldous Huxley", 1932));

            var booksByOrwell = library.FindBooksByAuthor("George Orwell");
            foreach (var book in booksByOrwell)
            {
                book.DisplayInfo();
            }

            // Lista alla böcker i kronologisk ordning
            library.ListBooksChronologically();

            // Visa alla böcker i biblioteket
            library.DisplayAllBooks();
        }


        // 1. Skapa en klass Course med attributen courseName och en array av Student-objekt.
        // 2. Implementera en metod i Course-klassen som tillåter att man lägger till en ny student till kursen.
        // 3. Skapa en metod som returnerar en lista av alla studenter i kursen som har ett visst betyg(du kan lägga till ett attribut grade i Student-klassen).
        // 4. Implementera en metod som hittar och returnerar den student som har högst betyg i kursen.
        // 5. Lägg till hantering för situationen där kursen är full och inte kan ta emot fler studenter.
        // 6. Implementera en metod som sorterar studenterna i kursen baserat på deras betyg i fallande ordning.
        public static void PrintExercise4()
        {
            // Create a course with capacity for 3 students
            Course course = new Course("Math", 3);

            // Create some students
            Student2 student1 = new Student2("Alice", 'A');
            Student2 student2 = new Student2("Bob", 'B');
            Student2 student3 = new Student2("Charlie", 'A');
            Student2 student4 = new Student2("David", 'C');

            // Add students to the course
            course.AddStudent(student1);
            course.AddStudent(student2);
            course.AddStudent(student3);

            // Try adding a student when the course is full
            course.AddStudent(student4);  // This should display a message saying the course is full

            // Display all students
            course.DisplayStudents();

            // Get students with grade 'A'
            var studentsWithA = course.GetStudentByGrade('A');
            Console.WriteLine("\nStudents with grade A:");
            foreach (var student in studentsWithA)
            {
                Console.WriteLine(student.GetName());
            }

            // Get the student with the best grade
            var bestStudent = course.GetStudentWithBestGrade();
            Console.WriteLine($"\nStudent with the best grade: {bestStudent.GetName()}");

            // Sort students by grade and display
            course.SortStudentsByGrade();
            Console.WriteLine("\nStudents sorted by grade (descending):");
            course.DisplayStudents();
        }
    }
}
