using System;


//  Return Statement | C# | Tutorial 13

namespace CSharpExercises_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //cube(5);
            //Console.WriteLine(cube(5));

            int cubedNumber = cube(5);
            Console.WriteLine("The cubed answer is  " + cubedNumber);


            Console.ReadLine();
        }

        // we are returning an int type
        static int cube(int num)
        {
            // the variable called result is where the calculated value will be stored
            int result = num * num * num;
            // this return keyword tells us that we want to return a variable or info 
            // back to the caller - in this case the value of the variable called result
            return result;
        }


    }
}
