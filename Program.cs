// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] generateArray(int length, int start, int end)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int getDif(int[] array)
{
    int min = 100;
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    int dif = max - min;
    return dif;
}

int[] array = generateArray(5, 0, 100); // В задании сказано "задайте массив вещественных чисел".
// Решил зафиксировать количество элементов 5 и поставить ограничение промежутка генерации от 0 до 100, как в примере условия.
printArray(array);
int dif = getDif(array);
Console.WriteLine($"Разница максимального и минимального элементов массива = {dif}.");
// В условии смутил термин вещественных. Стал пробивать. Если всё правильно понял, это типы данных float, double или decimal.
// При попытке написания с этими типами возникают ошибки типа невозможно перевести в или из int.
// Как в данном случае при решении отразить соответствие типа данных условию?