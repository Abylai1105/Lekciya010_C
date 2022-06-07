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
int[] binaryNumbers = GetBinaryNumbers(data, info);
int[] decimalNumbers = new int[binaryNumbers.Length];

for (int i = 0; i < decimalNumbers.Length; i++)
{
    decimalNumbers[i] = ConvertToDecimalNumber(binaryNumbers[i]);
}

PrintArray(binaryNumbers);
Console.WriteLine();
PrintArray(decimalNumbers);

int[] GetBinaryNumbers(int[] data, int[] info)
{
    int[] array = new int[info.Length];
    string stringNumber = String.Empty;
    int count = 0;
    for (int i = 0; i < info.Length; i++)
    {
        stringNumber = String.Empty;
        for (int j = 0; j < info[i]; j++)
        {
            stringNumber += data[j + count];
        }
        array[i] = Convert.ToInt32(stringNumber);
        count += info[i];
    }

    return array;
}

int ConvertToDecimalNumber(int binaryNumber)
{
    string stringNumber = Convert.ToString(binaryNumber);
    int decimalNumber = 0;
    for (int j = 0; j < stringNumber.Length; j++)
    {
        decimalNumber += (int) Math.Pow(2, j) * int.Parse(stringNumber[j].ToString());
    }

    return decimalNumber;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}