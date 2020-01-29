using System;

namespace Lab8GetToKnowYourClassmates
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. user is going to enter 1-5 .. link to student ..
            // 2. incorrect prompt
            // 3. adrres and favo food..

            Console.WriteLine("Welcome to our C# class Which student would you like to learn more about? (enter a number 1 - 5): ");
            int studentNumber = int.Parse(Console.ReadLine());
            //I don't  know  how to pull out the information to use it from the array
            var namesList = new string[5, 3]
           {

                {"Heather", "St. Clair", "corn on the cob"},
                { "Ben", "Alpena", "cheese burger"},
                { "Luke", "Richmond", "apple sauce"},
                { "Dawn", "Marysville", "tacos"},
                { "Sandy", "Smiths Creek", "pancakes"},
           };
            if (namesList.Length < studentNumber)
            {
                Console.WriteLine("Invalid Value");
                return;
            }

            

            Console.WriteLine($"Student is {namesList[studentNumber, 0]}, Hometown is {namesList[studentNumber, 1]}, Favorite food is {namesList[studentNumber, 2]}");
            Console.ReadLine();

         

        }
       
    }
}
