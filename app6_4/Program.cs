int[] mas = { 15, -10, 4, 1, 28, 36, -2, 10 };
int n = mas.Length;
int k = mas.Length / 2;
int temp;
for (int i = 0; i < n-1; i++)
{
	for (int g = i+1; g < n; g++)
	{
		if (mas[i] > mas[g])
		{
			temp = mas[i];
			mas[i] = mas[g];
			mas[g] = temp;
		}
	}
}
foreach (var item in mas)
{
	Console.Write($" {item}");
}
