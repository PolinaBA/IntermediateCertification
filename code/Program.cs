// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] MyArray = { "Leo", "Nick", "Charles", "Bob", "Vi", "Zelda" };


string[] NewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {

            count++;
        }

    string[] array2 = new string[count];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            array2[j] = array[i];
            j++;

        }

    return array2;

}

void PrintArray(string[] array)

{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length -1 )
        { 
            Console.Write("'" + array[i] + "'");
        }
        else 
        Console.Write("'" + array[i] + "'" + ",");
    }
    Console.Write("]");

}


string[] MyArray2 = NewArray(MyArray);
PrintArray(MyArray2);
