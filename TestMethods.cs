using System;
using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal static uint StackFirstPrime(Stack<uint> stack)
        {
            Stack<uint> temp = new Stack<uint>();
            uint result = 0;

            while (stack.Count > 0)
            {
                uint value = stack.Pop();
                temp.Push(value);
                if (result == 0 && IsPrime(value))
                {
                    result = value;
                }
            }

            while (temp.Count > 0)
            {
                stack.Push(temp.Pop());
            }

            return result;
        }

        internal static Stack<uint> RemoveFirstPrime(Stack<uint> stack)
        {
            Stack<uint> reversed = new Stack<uint>();
            bool removed = false;

            while (stack.Count > 0)
            {
                uint val = stack.Pop();
                if (!removed && IsPrime(val))
                {
                    removed = true;
                    continue;
                }
                reversed.Push(val);
            }

            Stack<uint> result = new Stack<uint>();
            while (reversed.Count > 0)
            {
                result.Push(reversed.Pop());
            }

            return result;
        }

        internal static Queue<uint> CreateQueueFromStack(Stack<uint> stack)
        {
            Stack<uint> temp = new Stack<uint>();
            Queue<uint> queue = new Queue<uint>();

            while (stack.Count > 0)
            {
                temp.Push(stack.Pop());
            }

            while (temp.Count > 0)
            {
                uint val = temp.Pop();
                stack.Push(val); 
                queue.Enqueue(val);
            }

            return queue;
        }

        internal static List<uint> StackToList(Stack<uint> stack)
        {
            Stack<uint> temp = new Stack<uint>();
            List<uint> list = new List<uint>();

            while (stack.Count > 0)
            {
                temp.Push(stack.Pop());
            }

            while (temp.Count > 0)
            {
                uint val = temp.Pop();
                list.Add(val);
                stack.Push(val); 
            }

            return list;
        }


        internal static bool FoundElementAfterSorted(List<int> list, int value)
        {
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }

            int left = 0, right = list.Count - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (list[mid] == value)
                    return true;
                else if (list[mid] < value)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return false;
        }

        private static bool IsPrime(uint number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            for (uint i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
