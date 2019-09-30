using System;
using BinaryTree;

namespace BinaryTreeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(10);
            tree.Insert(5);
            tree.Insert(11);
            tree.Insert(5);
            tree.Insert(-12);
            tree.Insert(15);
            tree.Insert(0);
            tree.Insert(14);
            tree.Insert(-8);
            tree.Insert(10);
            tree.Insert(8);
            tree.Insert(8);

            string sortedData = tree.WalkTree();
            Console.WriteLine($"Sorted data is {sortedData}");

            Console.ReadLine();
        }
    }
}
