# Описание решения


*__Условие задачи:__*  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

---

1. Создаем метод для формирования нового массива, который будет содержать строки, длина которых меньше или равна 3 символам.

```
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
    Console.WriteLine();

    return array2;

}
```

1.1 В данном методе создаем  цикл для определения размерности нового массива.

```
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {

            count++;
        }
```

1.2 Также в данном методе создаем цикл для заполнения нового массива.
```
for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            array2[j] = array[i];
            j++;

        }
```


2. Создаем метод, который выводит массив на консоль.
```
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
}

```
