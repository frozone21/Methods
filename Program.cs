using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user their name 
            Console.WriteLine("Please enter your name");

            //to handle input errors 
            try
            {
                //Read input from user 
                string name = Console.ReadLine();

                //Calling the method and using the user name 
                User_Name(name);
            }
            catch
            {
                //Show this message if there is a wrong input
                Console.WriteLine("You have entered invalid data");
            }
        }
        //Calling the customers user name 
        private static string User_Name(string get_name)
        {

            Console.WriteLine("");
            //Display "hello" along with the users name 
            Console.WriteLine("Hello " + get_name + "!");

            //return value
            return get_name;
        }
    }
}
