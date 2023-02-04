// Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// 1. Ввод количества строк 
// 2. Ввод длины каждой из строк и формирование массива из этих значений
// 3. Создание ступенчатого массива
// 4. Заполнение ступенчатого массива
// 5. Печать массива
// 6. Ввод максимальной длины строк в новом массиве
// 7. Формирование нового массива 

// 1. Ввод количества строк 
int GetNumberOfStrings()
{
    System.Console.WriteLine("Введите количество строк в массиве = ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

// 2. Ввод длины каждой из строк и формирование массива из этих значений
int[] GetLengthsOfStrings(int n)
{
    int[] lengths = new int[n];
    System.Console.WriteLine("Введите длины каждой из строк: ");
    for (int i = 0; i < n; i++)
    {
        System.Console.Write($"Длина строки {i} = ");
        lengths[i] = Convert.ToInt32(Console.ReadLine());
    }
    return lengths;
}

// 3. Создание ступенчатого массива
int[][] CreateSteppedArray(int n, int[] lengths)
{
    int[][] steppedArray = new int[n][];
    for (int i = 0; i < n; i++)
    {
        steppedArray[i] = new int[lengths[i]];
    }
    return steppedArray;
}

// 4. Заполнение ступенчатого массива
void GetStrings(int[][] steppedArray, int[] lengths)
{
    System.Console.WriteLine("Введите элементы каждой строки: ");
    for (int i = 0; i < steppedArray.Length; i++)
    {
        for (int j = 0; j < lengths[i]; j++)
        {
            System.Console.Write($"Строка {i}, элемент {j} = ");
            steppedArray[i][j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

// 5. Печать массива
void PrintSteppedArray(int[][] steppedArray, int[] lengths)
{
    for (int i = 0; i < steppedArray.Length; i++)
    {
        for (int j = 0; j < lengths[i]; j++)
        {
            System.Console.Write($"{steppedArray[i][j], 5}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

// 6. Ввод максимальной длины строк в новом массиве
int GetMaxLength()
{
    System.Console.WriteLine("Введите значение максимально допустимой длины строк: ");
    int maxLength = Convert.ToInt32(Console.ReadLine());
    return maxLength;
}

// 7. Формирование нового массива 
int[][] CreateNewSteppedArray(int[][] steppedArray, int[] lengths, int maxLength)
{
    int k = 0;
    int[][] newSteppedArray = new int[k][];
    for (int i = 0; i < steppedArray.Length; i++)
    {
        if (lengths[i] <= maxLength)
        {
            for (int j = 0; j < lengths[i]; j++)
            {
                newSteppedArray[k][j] = steppedArray[i][j];
            }
            k++;
        }
    }
    return newSteppedArray;
}

int n = GetNumberOfStrings();
int[] lengths = GetLengthsOfStrings(n);
int[][] array = CreateSteppedArray(n, lengths);
GetStrings(array, lengths);
PrintSteppedArray(array, lengths);

int maxLength = GetMaxLength();
int[][] newArray = CreateNewSteppedArray(array, lengths, maxLength);

