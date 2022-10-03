int[] number = new int[] { 1, 2, 3, 4, 5,6  };
int b;
int c = number.Length / 2;
for (int i = 0; i < c; i++)
{
    b = number[i];
    number[i] = number[number.Length-i-1];
    number[number.Length - i - 1] = b;
}
Console.ForegroundColor = ConsoleColor.Green;
foreach (int i in number)
{
    Console.Write(i);
}
