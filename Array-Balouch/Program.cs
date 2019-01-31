/* 
 
Author: Bisma Balouch
Date: 01/30/2019
Comment: creating a program which demonstrates the use of arrays.
*/
  
 using System;

namespace Array_Balouch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program executes an array which is of size 25 elements");

        // initiating the try catch block to validate user input
            try
            {
                Console.WriteLine("Let's populate the array with 25 integars using for each loop");
                //here is the manually populated array 
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
                Console.WriteLine("Here are the list of elements in the array:");
                Console.WriteLine(" ");
                //for each loop iterates
                foreach(int i in numbers)
                {
                    Console.WriteLine("Element value = " + i + " "); 
                    
                }
                Console.WriteLine(" ");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true); //ends the program when user presses key
            } //end of try
            catch
            {
                Console.WriteLine("The program worked perfectly, yay!");
                Console.WriteLine("Let's exit the program, press any key");
                Console.ReadKey(true);
            } //end of catch
        }
    }
}
