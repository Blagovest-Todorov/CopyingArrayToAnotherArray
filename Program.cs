using System;

namespace _11.ReferentialType
{
    class Program   //example of reference type Array
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3 };
            //int[] anotherNumbers = new int[numbers.Length];  //We create new array

            ////this example is manual copying !  using loop
            //for (int i = 0; i < numbers.Length; i++)  //We statrt iteration to fill the Content  of anotherNumbers Array :
            //    //with the content of Numbers Array
            //{
            //    anotherNumbers[i] = numbers[i];  
            //    //every key of anotherNumbers take the value of numbers//We make a copy 
            //} //anotherNumbers is copying the numbers //
            //anotherNumbers[0] = 10;  //we chane the value
            //Console.WriteLine(anotherNumbers[0]);// We changed this key- > with new value =10
            //Console.WriteLine(numbers[0]); //now the old array key 0 ->  =  value = 1  --not changed becasue :
            //anotherNumbes is different array and points to another place in memory than array numbers

            //another way of copying the content of array numbers to a new array anothernumbers is:
            //using  method Array.Copy();

            int[] numbers = { 1, 2, 3 };
            int[] anotherNumbers = new int[numbers.Length]; //We allocate space and we create empty array 
            // with the same length size  so we can copy there the source, the parent Array ;
            Array.Copy(numbers, anotherNumbers, numbers.Length);
            //we copy the source Array- numbers to another new Array: anotherNumbers
            //with  numbers.Length we say copy all elements of source Array to the new array: anotherNumbers
            //now we have two arrays with same content, if changing one array does not chaneg  the other array;
            //we can copy and less using numbers.Length -1 , or numbers.Length -2 or, statuc number ....
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
