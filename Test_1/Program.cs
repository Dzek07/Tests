Console.WriteLine("Количество элиментов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];


Console.Write(string.Join(", ", array));