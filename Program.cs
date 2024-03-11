string[] OneArray = FirstArray();
string[] TwoArray = SecondArray(OneArray);
string ThreeArray = MiddleArray(OneArray);
string FourArray = MiddleArray(TwoArray);
Console.WriteLine(ThreeArray + " -> " + FourArray);

string[] FirstArray()
{
    Console.WriteLine("Введите количество элементов массива:");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null) { enterSymbols = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] workArray = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return workArray;
}

string MiddleArray(string[] OneArray)
{
    string stringArray = "[";
    for (int i = 0; i < OneArray.Length; i++)
    {
        if (i == OneArray.Length - 1)
        {
            stringArray += $"\"{OneArray[i]}\"";
            break;
        }
        stringArray += ($"\"{OneArray[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}

int Symbols(string[] OneArray)
{
    int counter = 0;
    foreach (string item in OneArray)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}

string[] SecondArray(string[] workArray)
{
    int resultArrayLength = Symbols(workArray);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in workArray)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}
