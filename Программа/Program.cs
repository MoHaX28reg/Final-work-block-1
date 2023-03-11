// Напсать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа.
Console.Clear();

string[] ArrayToThreeSymbol(string[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length < 4)
            count++;
    }
       
    string[] array2 = new string[count];
    int j = 0;

    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length < 4)
        {            
            array2[j] = inArray[i];  
            j++;          
        }
    }
    return array2;
}

string[] array = new string[] {"^)-", "123445", "no", "1", "Bu-ga-ga", "hi", "2   3", "o_O"};
string[] arrayChange = ArrayToThreeSymbol(array);
Console.WriteLine(String.Join(", ", arrayChange));