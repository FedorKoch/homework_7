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

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.Write("Введите позицию элемента: ");
int[] pos = Console.ReadLine().Split(" ").Select(y => int.Parse(y)).ToArray();

if ((matrix.GetLength(0) - 1) < pos[0] | (matrix.GetLength(1) - 1) < pos[1]){
    Console.WriteLine();
    Console.WriteLine("такой позиции в массиве нет");
}
else{         
    int i = pos[0] - 1;
    int j = pos[1] - 1;
    Console.WriteLine();
    Console.WriteLine(matrix[i, j]);
}


