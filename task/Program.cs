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
// 7. Поиск количества строк с длиной <= 3
// 8. Формирование нового массива длин строк
// 9. Заполнение нового ступенчатого массива 

// 1. Ввод количества строк 
int GetNumberOfStrings()
{
    System.Console.Write("Введите количество строк в массиве = ");
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
        string s = string.Empty;
        string separator = ", ";
        for (int j = 0; j < lengths[i]; j++)
        {
            s += $"{steppedArray[i][j]}{separator}";
        }
        s = s.Substring(0, s.Length - separator.Length);
        System.Console.WriteLine(s);
    }
    System.Console.WriteLine();
}

// 6. Ввод максимальной длины строк в новом массиве
int GetMaxLength()
{
    System.Console.Write("Введите значение максимально допустимой длины строк: ");
    int maxLength = Convert.ToInt32(Console.ReadLine());
    return maxLength;
}

// 7. Поиск количества строк с длиной <= 3
int FindNOfStrings(int[] lengths, int maxLength)
{
    int n = 0;
    for (int i = 0; i < lengths.Length; i++)
    {
        if(lengths[i] <= maxLength) n++;
    }
    return n;
}

// 8. Формирование нового массива длин строк
int[] FindNewLengthsOfStrings(int[] lengths, int maxLength, int n)
{
    int[] newLengths = new int[n];
    int k = 0;
    for (int i = 0; i < n; i++)
    {
        if(lengths[i] <= maxLength)
        {
            newLengths[k] = lengths[i];
            k++;
        }
    }
    return newLengths;
}

// 9. Заполнение нового ступенчатого массива 
void FillNewSteppedArray(int[][] steppedArray, int[] lengths, int maxLength, int[][] newSteppedArray)
{
    int k = 0;
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
}

int n = GetNumberOfStrings();
int[] lengths = GetLengthsOfStrings(n);
int[][] array = CreateSteppedArray(n, lengths);
GetStrings(array, lengths);
System.Console.WriteLine();
System.Console.WriteLine("Исходный масссив представлен ниже:");
PrintSteppedArray(array, lengths);

int maxLength = GetMaxLength();
int newN = FindNOfStrings(lengths, maxLength);
int[] newLengths = FindNewLengthsOfStrings(lengths, maxLength, newN);
int[][] newArray = CreateSteppedArray(newN, newLengths);
FillNewSteppedArray(array, lengths, maxLength, newArray);
System.Console.WriteLine();
System.Console.WriteLine($"Новый массив из строк с длиной меньше или равной {maxLength}:");
PrintSteppedArray(newArray, newLengths);

