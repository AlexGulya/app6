int[,] number = { { 1, 2, 3 },{ 4, 5, 6 } };
int rows = number.GetUpperBound(0)+1;
int columns = number.Length / 2; 
//foreach (int i in number)
//{
//    Console.WriteLine(i);
//}

for (int i = 0; i < rows; i++)
{
	for (int j = 0; j < columns; j++)
	{
        
        Console.Write(number[i,j]);
    }
    Console.WriteLine();
	
}