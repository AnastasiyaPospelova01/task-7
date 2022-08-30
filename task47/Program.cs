//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] MakeMatrix(int row, int col) {
    double[,] matrix = new double [row, col];
    for (int columns = 0; columns < col; columns++) {
        for (int rows = 0; rows < row; rows++) {
            matrix[rows,columns] = Math.Round(new Random().NextDouble()* new Random().Next(-10, 10), 1);
        }
    }
    return matrix;
}

void PrintMatrix (double[,] matrix) {
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    for (int rows = 0; rows < row; rows++) {
        for (int column = 0; column < col; column++) {
            Console.Write($"{matrix[rows, column],10}");
            }
        Console.WriteLine();
    }
}

int m = 3, n = 4;
double[,] matrix = MakeMatrix(m, n);
PrintMatrix(matrix);
