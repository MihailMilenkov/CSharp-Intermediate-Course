namespace CSharpIntermediateCourse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StackStack : IStackStack
    {
        private Stack<object> stack;

        public StackStack()
        {
            stack = new Stack<object>();
        }

        internal void TurnOn()

        {
            while (true)
            {
                Console.WriteLine("Press \"1\" to Push and obj, \"2\" to Pop, \"3\" to Clear everything and \"4\" to exit.");
                Console.WriteLine("-------------------------------");
                int inputNum = int.Parse(Console.ReadLine().TrimEnd());
                if (inputNum == 4)
                    break;
                else if (inputNum == 1)
                {
                    Console.WriteLine("Please enter an object.");
                    object? input_obj = Console.ReadLine();
                    Push(input_obj);
                }
                else if (inputNum == 2)
                {
                    Console.WriteLine("Popping: " + Pop());
                }
                else if (inputNum == 3)
                {
                    Console.WriteLine("Clearing");
                    Clear();
                }
                else
                    Console.WriteLine("Invalid Command");
            }

            foreach (var item in stack)
                Console.WriteLine(item);
        }

        void Push(object obj)
        {
            if (obj != null)
                stack.Push(obj);
            else
                throw new InvalidOperationException("Object cannot be null");
        }

        object Pop()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("Stack is empty");
            return stack.Pop();
        }

        void Clear()
        {
            stack.Clear();
        }


    }
}
