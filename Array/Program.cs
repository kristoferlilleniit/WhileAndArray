using System;
using System.Dynamic;
using System.Security.Claims;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] shoppingList = {"milk", "bread", "WC paper", "cookies", "pork"};

            int arrayLenght = shoppingList.Length;
            Console.WriteLine($"You have {arrayLenght} items on your list.");

            for(int i = 0; i < shoppingList.Length; i++)
            {
                Console.WriteLine($"{i+1}. {shoppingList[i]}");
            }

            Console.WriteLine($"The first item on your list is {shoppingList[0]}");
            Console.WriteLine($"The last item on your list is {shoppingList[4]}");
        }
    }
}
