using System.Security;

namespace Prog_260_W24_L5_021424
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stack 
            Stack<int> stackExample = new Stack<int>();

            // Example
            // Last In First Out
            // 4
            // 3
            // 2
            // 1

            // Push - Adds a value to the top
            // Pop - Removes the last value added
            // Peek - Returns the last value added - does not remove

            stackExample.Push(4);
            stackExample.Push(3);
            stackExample.Push(2);
            stackExample.Push(1);


            //int value = stackExample.Pop();

            Console.WriteLine("Current Size: " + stackExample.Count);

            int currentStackSize = stackExample.Count;

            Stack<int> temp = new Stack<int>();

            while(stackExample.Count > 0)
            {
                int currentPop = stackExample.Pop();
                temp.Push(currentPop);

                currentStackSize = stackExample.Count;
            }

            int tempStackSize = temp.Count;

            while(temp.Count > 0)
            {

                int tempPop = temp.Pop();
                Console.WriteLine(tempPop);
                stackExample.Push(tempPop);
            }

            //foreach (int item in stackExample)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("Current Size: " + stackExample.Count);

            //Console.WriteLine($"Value POPPED from the stack {value}");



        }

        public static void QueueExample()
        {
            // Queue
            Queue<int> queueExample = new Queue<int>();

            // Enqueue
            // Dequeue
            // Peek
            // Clear

            // TO add elements we use Enqueue
            queueExample.Enqueue(4);
            queueExample.Enqueue(3);
            queueExample.Enqueue(2);
            queueExample.Enqueue(1);

            //int value = queueExample.Peek();
            //Console.WriteLine("The value that we dequeued was " + value);


            // How can we loop through a queue to display all the values, without removing all of them.

            int currentCount = queueExample.Count;
            int count = 2;


            Console.WriteLine($"Current Size - {queueExample.Count}");

            while (count < currentCount)
            {
                // Remove the value
                int value = queueExample.Dequeue();
                //Console.WriteLine(value);
                queueExample.Enqueue(value);

                count++;
            }

            // How to empty a queue
            while (currentCount >= 0)
            {
                Console.WriteLine(queueExample.Dequeue());

                currentCount = queueExample.Count;
            }





            //while (queueExample.TryDequeue(out int number))
            //{
            //    Console.WriteLine(number);
            //}



            Console.WriteLine($"Current Size - {queueExample.Count}");

            // Stack


        }
    }
}
