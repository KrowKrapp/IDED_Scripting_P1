using System;
using System.Collections.Generic;

namespace TestProject1
{
    internal class Sandbox
    {
        public static void Main(string[] args)
        {
            // Sample stack
            Stack<uint> pila = new Stack<uint>();
            pila.Push(10);
            pila.Push(4);
            pila.Push(7);
            pila.Push(6);
            pila.Push(8);

            // Test CreateQueueFromStack
            Console.WriteLine("Testing CreateQueueFromStack:");
            Queue<uint> cola = TestMethods.CreateQueueFromStack(pila);
            Console.WriteLine("Queue contents:");
            foreach (var item in cola)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Test StackFirstPrime
            Console.WriteLine("Testing StackFirstPrime:");
            uint firstPrime = TestMethods.StackFirstPrime(pila);
            Console.WriteLine("First Prime: " + firstPrime);

            // Test RemoveFirstPrime
            Console.WriteLine("Testing RemoveFirstPrime:");
            Stack<uint> modifiedStack = TestMethods.RemoveFirstPrime(pila);
            Console.WriteLine("Modified stack:");
            foreach (var item in modifiedStack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Test StackToList
            Console.WriteLine("Testing StackToList:");
            List<uint> listFromStack = TestMethods.StackToList(pila);
            Console.WriteLine("List from Stack:");
            foreach (var item in listFromStack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Test FoundElementAfterSorted
            List<int> sortedList = new List<int> { 4, 6, 7, 8, 10 };
            bool found = TestMethods.FoundElementAfterSorted(sortedList, 7);
            Console.WriteLine("Found 7 in sorted list: " + found);
        }
    }
}