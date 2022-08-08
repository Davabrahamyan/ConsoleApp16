// See https://aka.ms/new-console-template for more information
using ConsoleApp16;

int[] a = { 3, 2, 5, 1, 7, 4 };
Class1.QuickSort(a, 0, 5);
for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine(a[i]);
}
