void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-20, 21); 
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
double [] ArithmeticMean(int[,] matrix) 
{
    double[] mas = new double[matrix.GetLength(1)];
    double Srarf = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)                                       
    { 
        Srarf = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Srarf = Srarf + matrix[i,j];
    }
    Srarf = Srarf / matrix.GetLength(0); 
    mas[j] = Math.Round(Srarf, 2);
    }
    return mas;
}
Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);

double [] znach = ArithmeticMean(matrix);

Console.WriteLine();   
int j = 0;
while(j < matrix.GetLength(1))
{
   Console.Write( znach[j]);
   Console.Write(" ");
    j++;
}





