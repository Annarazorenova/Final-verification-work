// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символам
// Массив можно ввести с клавиатуры или задать на старте

string[] array = new string[] { "1254", "157", "8", "world", "Russia" };
string[] array2 = new string[array.Length];

SecondStringArray(array, array2);
PrintArray2(array2);

void SecondStringArray(string[] array, string[]array2)
{
    int count =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count ++;
        }
    }
}

void PrintArray2(string[] array2)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
    Console.WriteLine(" ");
}
