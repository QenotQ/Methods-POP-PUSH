using _18._03._22;
int num = 5;
int[] array = new int[num];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
    array[i] = random.Next(8);

Console.Write("введённый массив ");
Console.WriteLine(string.Join(" ", array));
int lenght = Methods.Push(ref array);
Console.WriteLine("Длинна изменённого массива " + lenght);
Console.Write("Изменённый массив ");
Console.WriteLine(string.Join(" ", array));
Console.WriteLine();
Console.Write("введённый массив ");
Console.WriteLine(string.Join(" ", array));
int deleted = Methods.Pop(ref array);
Console.WriteLine("Удалённый элемент массива " + deleted);
Console.Write("Изменённый массив ");
Console.WriteLine(string.Join(" ", array));