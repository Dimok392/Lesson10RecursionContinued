// Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные
// представления нескольких чисел (без разделителя). В массиве data хранится
// информация о количестве бит, которые занимают числа из массива info.
// Напишите программу, которая составит массив десятичных представлений чисел
// массива data с учётом информации из массива info.
// 25 мин
// входные данные:
// - data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// - info = {2, 3, 3, 1 }
// выходные данные:
// - 1, 7, 0, 1
int[] array1 = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] array2 = { 2, 3, 3, 1 };
int Transfer(int[] data, int[] info)
{
    int count = 0;
    int[] result = new int[info.Length];
    for (int i = 0; i < info.Length; i++)
    {
        for (int j = count; j < count + info[i]; j++)
        {
            result[i] += data[j]*(int)Math.Pow(2,info[i]+count-j-1);

        }
        count += info[i];
        Console.Write(result[i] + " ");
    }
    return result[0];
}

Transfer(array1, array2);