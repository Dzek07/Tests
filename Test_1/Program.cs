void ArrayFilling(string[] array)
{
    int size = array.Length;

    for(int index = 0; index < size; index++)
    {
        Console.Write("Введите элимент масссива: ");
        array[index] = Console.ReadLine();
    }

}


Console.Write("Количество элиментов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];


ArrayFilling(array);
Console.Write(string.Join(", ", array));
Console.WriteLine();
