void ArrayFilling(string[] array)
{
    int size = array.Length;

    for(int index = 0; index < size; index++)
    {
        Console.Write("Введите элимент масссива: ");
        array[index] = Console.ReadLine();
    }

}
int Elements_less_than_three_characters(string[] array)
{
    int size = array.Length;
    int counter = 0;
    for(int index = 0; index < size; index++)
    {          
        if (array[index].Length < 4)
            counter++;
    }
    return counter;
}

Console.Write("Количество элиментов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];


ArrayFilling(array);
Console.Write(string.Join(", ", array));
Console.WriteLine();
int size_resoult_array = Elements_less_than_three_characters(array);
string[] resoult_array = new string[size_resoult_array];