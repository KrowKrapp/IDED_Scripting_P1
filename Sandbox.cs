using System;

namespace TestProject1
{
    internal class Sandbox
    {
        public static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;

namespace TestProject1
    {
        internal class Sandbox
        {
            public static void Main(string[] args)
            {
                Stack<int> pila = new Stack<int>();
                pila.Push(18);
                pila.Push(27);
                pila.Push(17); 
                pila.Push(45);

                Console.WriteLine("Probando GetFirstPrime :P");
                int primerPrimo = TestMethods.GetFirstPrime(pila);
                Console.WriteLine($"Primer número primo encontrado: {primerPrimo}"); 

                Console.WriteLine("Probando RemoveFirstPrime");
                TestMethods.RemoveFirstPrime(pila);
                Console.WriteLine("Pila después de eliminar el primer primo:");
                foreach (int num in pila)
                    Console.WriteLine(num);

                Console.WriteLine("Probando StackToQueue");
                Queue<int> cola = TestMethods.StackToQueue(pila);
                Console.WriteLine("Cola generada desde la pila:");
                foreach (int num in cola)
                    Console.WriteLine(num);

                Console.WriteLine("Probando StackToList");
                List<int> lista = TestMethods.StackToList(pila);
                Console.WriteLine("Lista generada desde la pila:");
                foreach (int num in lista)
                    Console.WriteLine(num);

                Console.WriteLine("Probando IsNumberInSortedList");
                List<int> lista2 = new List<int> { 42, 13, 7, 66, 1, 3 };
                int target = 7;
                bool encontrado = TestMethods.IsNumberInSortedList(lista2, target);
                Console.WriteLine($"¿El número {target} está en la lista? {encontrado}");
            }
        }
    }
}
    }
}