using System.Collections.Generic;

//store collections that get returned from GetCollection();
IEnumerable<int> unknownCollection;

unknownCollection = GetCollection(1); 

Console.WriteLine("This was a List<int>");

foreach (int num in unknownCollection)
{
    Console.Write(num + " ");

}
Console.WriteLine("");

unknownCollection = GetCollection(2);

Console.WriteLine("This was a Queue<int>");

foreach (int num in unknownCollection)
{
    Console.Write(num + " ");

}
Console.WriteLine("");

unknownCollection = GetCollection(5);

Console.WriteLine("This was a array of int");

foreach (int num in unknownCollection)
{
    Console.Write(num + " ");

}



//List, Que, Array, implementing Ienumerable interface
static IEnumerable<int> GetCollection(int option)
{
    List<int> numbersList = new() { 1, 2, 3, 4, 5 };


    Queue<int> numbersQueue = new();

    numbersQueue.Enqueue(6);
    numbersQueue.Enqueue(7);
    numbersQueue.Enqueue(8);
    numbersQueue.Enqueue(9);
    numbersQueue.Enqueue(10);

    if (option == 1)
    {
        return numbersList;
    }

    else if (option == 2)
    {
        return numbersQueue;
    }
    else
    {
        return new int[] { 11, 12, 13, 14, 15 };

    }

}