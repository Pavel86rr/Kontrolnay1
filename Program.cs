/Задача. Написать программу, которая из имеющегося массива строк формирует 
//новый массив из строк, длина которых меньше, либо равна 3 символам.

Console.WriteLine("Введите массив строк через пробел");
string? stroka = Console.ReadLine();

void Main()
{
    string[] Massiv = stroka.Split(' ');
    var result = new string[Massiv.Length];
    var realSize = 0;

    foreach (var value in Massiv)
    {
        if (value.Length <= 3)
        {
            result[realSize] = value;
            realSize++;
        }
    }

    Console.Write("[");
    Console.Write(string.Join("; ", result, 0, realSize));
    Console.Write("]");
}

Main();



