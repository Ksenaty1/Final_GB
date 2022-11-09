void ShowArray(string[] array)
{
    string output = "[";
    for(int i = 0; i < array.Length; i++)
    {
        output = output +  $"{array[i]}|";
    }
    output = output.Replace("|", ", ");
    output = output.Substring(0, output.Length - 2);
    output = output + "]";
    Console.WriteLine(output);
}

string[] InputArray(string input)
{
    string[] array = input.Split(", ");
    return array;
    
}

string[] Function(string[] array)
{
    int count = 0;
    string[] new_array = new string[count];
    for(int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3) {
                count++;
                Array.Resize(ref new_array, count);
                new_array[count - 1] = array[i];
            }
        }
    return new_array;
}


//Заданный программно ввод
string[] array = {"hello", "2", "world", ":-)"};

// Ввод с клавиатуры
Console.Write("Введите массив: ");
string[] array_input = InputArray(Console.ReadLine());

//Вывод массива, который задали в программе
string[] new_array = Function(array);
ShowArray(new_array);

//Вывод массива, набранного на клавиатуре
string[] new_input_array = Function(array_input);
ShowArray(new_input_array);