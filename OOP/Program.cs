using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // stack work lifo style(last in first out)

            Stack<int> numbers = new Stack<int>();

            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);

            //remove from last
            numbers.Pop();


            //when you use peek method it get last one value from dataset
            Console.WriteLine(numbers.Peek());


            // contains method check value exist or not,it return boolean value
            Console.WriteLine(numbers.Contains(1));


            // it iteration from last. it means last in first out
          
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


            // you can use clear method
            numbers.Clear();


            // you can also use this generic version.
        }
    }
}


