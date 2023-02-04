// Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// 1. Ввод количества строк
// 2. Создание массива строк
// 3. Ввод строк в массив
// 4. Печать массива
// 5. Ввод максимальной длины строк в новом массиве
// 6. Поиск количества строк с длиной не больше максимального значения
// 7. Создание и заполнение нового массива


// 1. Ввод количества строк 
int GetNumberOfStrings()
{
    System.Console.Write("Введите количество элементов в массиве = ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

// 2. Создание массива строк
string[] CreateArray(int n)
{
    return new string[n];
}

// 3. Ввод строк в массив
void GetArray(string[] array)
{
    System.Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Строка {i}: ");
        array[i] = Console.ReadLine();
    }
}

// 4. Печать массива
void PrintArray(string[] array)
{
    string s = string.Empty;
    string separator = ", ";
    for (int i = 0; i < array.Length; i++)
    {
        s += $"{array[i]}{separator}"; 
    }
    s = s.Substring(0, s.Length - separator.Length);
    System.Console.WriteLine(s);
}

// 5. Ввод максимальной длины строк в новом массиве
int GetMaxLength()
{
    System.Console.Write("Введите значение максимально допустимой длины строк: ");
    int maxLength = Convert.ToInt32(Console.ReadLine());
    return maxLength;
}

// 6. Поиск количества строк с длиной не больше максимального значения
int FindNOfStrings(string[] array, int maxLength)
{
    int newN = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength) newN++;
    }
    return newN;
}

// 7. Создание и заполнение нового массива
string[] CreateNewArray(string[] array, int newN, int maxLength)
{
    string[] newArray = new string[newN];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            newArray[k] = array[i];
            k++;
        }
    }
    return newArray;

}

int n = GetNumberOfStrings();
int[] lengths = GetLengthsOfStrings(n);
char[][] array = CreateSteppedArray(n, lengths);
GetStrings(array, lengths);
System.Console.WriteLine();
System.Console.WriteLine("Исходный масссив представлен ниже:");
PrintSteppedArray(array, lengths);

int maxLength = GetMaxLength();
int newN = FindNOfStrings(lengths, maxLength);
int[] newLengths = FindNewLengthsOfStrings(lengths, maxLength, newN);
char[][] newArray = CreateSteppedArray(newN, newLengths);
FillNewSteppedArray(array, lengths, maxLength, newArray);
System.Console.WriteLine();
System.Console.WriteLine($"Новый массив из строк с длиной меньше или равной {maxLength}:");
PrintSteppedArray(newArray, newLengths);

