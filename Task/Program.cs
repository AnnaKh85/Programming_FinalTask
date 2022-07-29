using System; 
using static System.Console;

Clear();

Write("Enter elements of the array (space-separated): ");
WriteLine();

string[] array3 = GetArrayFromString(ReadLine());
string[] array2 = new string[array3.Length];

Write($"[{String.Join(",", array3)}] - > ");

SecondArrayWithIF(array3, array2);

PrintArray(array2);

string[] GetArrayFromString(string arrStr)
{

    string[] ArS = arrStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string[] result = new string[ArS.Length];
    for (int i = 0; i < ArS.Length; i++)
    {
        result[i] = ArS[i];
    }
    return result;
}

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
