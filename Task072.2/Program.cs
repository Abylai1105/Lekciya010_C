// Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел 
// (без разделителя). В массиве data хранится информация о количестве бит, которые занимают числа из массива info. 
// Напишите программу, которая составит массив десятичных представлений чисел массива 
// data с учётом информации из массива info.

// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// выходные данные:
// 1, 7, 0, 1

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int[] output = DecodeAll(data, info);

WriteArray(output);
Console.WriteLine(DecodePosition(data, info, 3));

int[] DecodeAll(int[] data, int[] info)
{
    int[] result = new int[info.Length];
    int k = 0;
    for (int i = 0; i < info.Length; i++)
    {
        for (int j = 0; j < info[i]; j++)
        {
            result[i] = result[i] * 2 + data[k];
            k++;
        }
    }
    return result;
}

int DecodePosition(int[] data, int[] info, int position)
{
    int result = 0;
    int k = 0;
    for (int i = 0; i < position; i++)
        k += info[i];

    for (int i = 0; i < info[position]; i++)
        result = result * 2 + data[k++];

    return result;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}