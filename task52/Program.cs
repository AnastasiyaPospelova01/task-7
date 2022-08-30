//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] MakeMatrix(int row, int col) {
    int[,] matrix = new int [row, col];
    for (int columns = 0; columns < col; columns++) {
        for (int rows = 0; rows < row; rows++) {
            matrix[rows,columns] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix) {
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    for (int rows = 0; rows < row; rows++) {
        for (int column = 0; column < col; column++) {
            Console.Write($"{matrix[rows, column],3}");
            }
        Console.WriteLine();
    }
}

double[] ArithmeticMean (int[,] matrix) {
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    double[] results = new double [col];
    int k = 0;
    double am;
    for (int j = 0; j < col; j++) {
        am = 0;
        for (int i = 0; i < row; i++) {
            am += matrix[i,j];
        }
        results[k] = am/row;
        k++;
    }
    return results;
}

void PrintValues (double[] values) {
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < values.Length; i++) {
        Console.Write(values[i] + "  ");
    }
}

int m = 4, n = 4;
int [,] matrix = MakeMatrix(m, n);
PrintMatrix(matrix);

double[] values = ArithmeticMean(matrix);
PrintValues(values);