// // написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше 
//либо равна 3 символа. Перв массив м ввести с клавиатуры или задать самост на старте алгоритма

// написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше 
//либо равна 3 символа. Перв массив м ввести с клавиатуры или задать самост на старте алгоритма




//     Console.WriteLine("Введите слова или символы через пробел");
//     int size = 8;
//     string[] symbols = new string[size];
//     FillArray(string [] symbols);

// void FillArray(string [] symb)
// {
//     for (int i =0; i< size; i++)
//     {
//         symb[i] = Console.ReadLine();
//     }
// }


//     string[] symbols2 = new string[3];
//     int count = 0;
//     PrintArray(symbols); 
    
//     PrintArray(symbols2); 


// void PrintArray(string[]symbols)
// {
//     Console.WriteLine("Вывод массива");
//     for (int i =0; i<symbols.Length; i++)
//     {
//         Console.Write(symbols[i] + " ");
//     }
//     Console.WriteLine();
// }

string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);