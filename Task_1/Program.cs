// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Например, 0, 7, 8, -2, -2 -> 2, 1, -7, 567, 89, 223-> 3

// определение функции перевода массива со строкой в массив с числами:
int[] StringToNumberArray(string array)
{
    int count = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        string temp = "";

        while (array [i] != ',')
        {
        if(i != array.Length - 1)
        {
            temp += array [i].ToString();
            i++;
        }
        else
        {
            temp += array [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}

int FindNumbersGreaterZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


Console.WriteLine("Введите числа через запятую:");
string numbers = Console.ReadLine();
string[] array = new string[] {numbers};
int[] nums = StringToNumberArray(numbers);
PrintArray(nums);
Console.WriteLine();
int result = FindNumbersGreaterZero(nums);
Console.WriteLine($"Количество чисел больше нуля = {result}.");
