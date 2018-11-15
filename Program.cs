using System;

namespace csStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Dirk";
            var lastName = "Dobson";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, LastName);

            var names = new string[3] { "John", "Jane", "James"}
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);


        }
    }
}
