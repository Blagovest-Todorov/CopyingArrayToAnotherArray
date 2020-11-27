using System;

namespace _11.ReferentialType
{
    class Program   //example of reference type Array
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            int[] anotherNumbers = new int[numbers.Length];  //We create new array

            //this example is manual copying !  using loop
            for (int i = 0; i < numbers.Length; i++)  //We statrt iteration to fill the Content  of anotherNumbers Array :
                //with the content of Numbers Array
            {
                anotherNumbers[i] = numbers[i];  
                //every key of anotherNumbers take the value of numbers//We make a copy 
            } //anotherNumbers is copying the numbers //
            anotherNumbers[0] = 10;  //we chane the value
            Console.WriteLine(anotherNumbers[0]);// We changed this key- > with new value =10
            Console.WriteLine(numbers[0]); //now the old array key 0 ->  =  value = 1  --not changed becasue :
            //anotherNumbes is different array and points to another place in memory than array numbers

            //another way of copying the content of array numbers to a new array anothernumbers is:
           //using  method Array.Copy();
        }
    }
}
