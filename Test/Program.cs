// // написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше 
//либо равна 3 символа. Перв массив м ввести с клавиатуры или задать самост на старте алгоритма
    
    int size = 6;
    string[] symbols = new string[size];
    string[] symbols2 = new string[symbols.Length];
    
    Console.WriteLine($"Введите набор символов {size} раз через Enter, без пробелов");
    FillArray(symbols);
    PrintArray(symbols);
    ArrayFilter(symbols, symbols2);
    PrintArray(symbols2); 
    void ArrayFilter(string[] symbols, string[] symbols2)
{
    int count = 0;
    for (int i = 0; i < symbols.Length; i++)
    {
    if(symbols[i].Length <= 3)
        {
        symbols2[count] = symbols[i];
        count++;
        }
    }
}

   void FillArray(string [] symbols)
{
    for (int i =0; i< size; i++)
    {
        symbols[i] = Console.ReadLine();
    }
}

   


void PrintArray(string[]symbols)
{
    Console.WriteLine("Вывод массива");
    for (int i =0; i<symbols.Length; i++)
    {
        Console.Write(symbols[i] + " ");
    }
    Console.WriteLine();
}

