In C#, a stack is a data structure that follows the Last In, First Out (LIFO) principle. It means that the last element added to the stack is the first one to be removed. 

In C#, you can use the `Stack<T>` class from the `System.Collections.Generic` namespace to work with stacks. This class represents a generic collection of objects, where 'T' is the type of elements in the stack.

Here's a basic example of how you can use a stack in C#:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a stack of integers
        Stack<int> myStack = new Stack<int>();

        // Pushing elements onto the stack
        myStack.Push(10);
        myStack.Push(20);
        myStack.Push(30);

        // Peeking at the top element (without removing it)
        Console.WriteLine("Top element of the stack: " + myStack.Peek());

        // Popping elements off the stack
        Console.WriteLine("Popping elements off the stack:");
        while (myStack.Count > 0)
        {
            int poppedItem = myStack.Pop();
            Console.WriteLine(poppedItem);
        }
    }
}
```

Output:
```
Top element of the stack: 30
Popping elements off the stack:
30
20
10
```

In this example, we create a stack of integers (`Stack<int>`), push some elements onto the stack using the `Push` method, peek at the top element using the `Peek` method (which doesn't remove the element), and then pop elements off the stack using the `Pop` method, which removes and returns the top element of the stack.