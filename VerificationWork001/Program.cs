void PrintArray(string[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] mas = new string [size];
string[] arr = new string [size];

for (int i = 0; i < mas.Length; i++)
{
    Console.Write("Введите элемент массива №{0}:\r\n", i + 1);
    mas[i] = Console.ReadLine();
    if(mas[i].Length<=3)
    {
        arr[i]=mas[i];
    }
}

Console.WriteLine();
PrintArray(mas);
Console.WriteLine();
PrintArray(arr);
