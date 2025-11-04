//Creates a single-dimensional integer array containing 5 of your favorite numbers.
using static System.Runtime.InteropServices.JavaScript.JSType;

int[] myFavNum = { 1, 22, 33, 44, 55 };

//Uses Array.Sort() to sort the array in ascending order.
Array.Sort(myFavNum);

//Uses Array.Reverse() to reverse the sorted array.
Array.Reverse(myFavNum);

//Prints each element of the array using a for loop.
Console.WriteLine("Printing each element of array using loop:");
for (int i = 0; i < myFavNum.Length; i++)
{
    Console.WriteLine(myFavNum[i]);
}

//Uses Array.IndexOf() to find the position of a specific number in the array.
int specificNumToFind = 44;
int index = Array.IndexOf(myFavNum, specificNumToFind);

Console.WriteLine($"The index of the {specificNumToFind} in array is {index}");


