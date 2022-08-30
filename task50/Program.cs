//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном
//массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого числа в массиве нет

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

void Find (int[,] matrix, int i, int j) {
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    if (i > row || j > col) {
        Console.WriteLine("Такого числа в массиве нет.");
    }
    else {
        Console.WriteLine($"Число: {matrix[i-1,j-1]}");
    }
}

int m = 4, n = 4;
int [,] matrix = MakeMatrix(m, n);
PrintMatrix(matrix);

Console.Write("Введите номер строки: ");
int i = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int j = int.Parse(Console.ReadLine());
Find(matrix, i, j);
