//Задача:
// Написать программу, 
// которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.

// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int arraySize = GetUserInputOnArraySize();
if (arraySize > 0)
{
    string[] userInputArray = CaptureAndGenerateUserInputArray(arraySize);
    string arrayAsString = DisplayArrayResultsAsString(userInputArray);
    string[] finalResultArray = DetermineItemsWithLengthEqualToOrLessThanThree(userInputArray);
    DisplayFinalResult(userInputArray, finalResultArray);
}
else
{
    Console.WriteLine("The array size should be greater than 0. The program will exit now.");
}

int GetUserInputOnArraySize()
{
    Console.Write("Set how many strings you will enter: ");
    return Convert.ToInt32(Console.ReadLine());
}

string[] CaptureAndGenerateUserInputArray(int arraySize)
{
    string[] userArray = new string[arraySize];
    int inputCounter = 0;
    while (inputCounter < arraySize)
    {
        Console.Write($"Enter {inputCounter + 1} string: ");
        userArray[inputCounter] = Console.ReadLine();
        inputCounter++;
    }
    return userArray;
}

string DisplayArrayResultsAsString(string[] array)
{
    string resultAsString = "";

    if (array.Length > 0)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                resultAsString = "[";
            }
            if (i < array.Length - 1)
            {
                resultAsString += $"\"{array[i].ToString()}\", ";
            }
            else
            {
                resultAsString += $"\"{array[i].ToString()}\"]";
            }
        }
    }
    else
    {
        resultAsString = "[]";
    }
    return resultAsString;
}

string[] DetermineItemsWithLengthEqualToOrLessThanThree(string[] array)
{
    int arraySize = 0;
    string[] resultArray = new string[arraySize];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arraySize++;
            Array.Resize(ref resultArray, arraySize);
            resultArray[arraySize - 1] = array[i];
        }
    }
    return resultArray;
}

void DisplayFinalResult(string[] userArray, string[] resultArray)
{
    string initialArrayAsString = DisplayArrayResultsAsString(userArray);
    string finalArrayAsString = DisplayArrayResultsAsString(resultArray);
    Console.Write(initialArrayAsString);
    Console.Write(" -> ");
    Console.WriteLine(finalArrayAsString);
}