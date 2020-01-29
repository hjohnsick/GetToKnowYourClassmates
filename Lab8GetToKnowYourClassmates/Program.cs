using System;

namespace Lab8GetToKnowYourClassmates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our C# class Which student would you like to learn more about? (enter a number 1 - 5): ");
            int student = int.Parse(Console.ReadLine());
            //I don't  know  how to pull out the information to use it from the array

            var namesList = new string[5, 3]
           {

                {"Heather", "St. Clair", "corn on the cob"},
                { "Ben", "Alpena", "cheese burger"},
                { "Luke", "Richmond", "apple sauce"},
                { "Dawn", "Marysville", "tacos"},
                { "Sandy", "Smiths Creek", "pancakes"},
           };
            
            for (var i = 0; i < namesList.Length; i++)
            {
                Console.WriteLine(namesList[i]);
            }


        }
       
    }
}
