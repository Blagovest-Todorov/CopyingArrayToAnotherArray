using System;

namespace _11.ReferentialType
{
    class Program   //example of reference type Array
    {
        static void Main(string[] args)
        {


            static void Main(string[] args)
            {
                int[] numbers = { 1, 2, 3 };

                int[] anotherNumbers = new int[numbers.Length - 1]; //allocate Space for the New Array
                                                                    //be aware of the length of the new array,  or we will get Exception/ SystemArgumentException
                Array.Copy(numbers, anotherNumbers, numbers.Length);


                foreach (int item in numbers)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("The new array is :");
                foreach (int item in anotherNumbers)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
