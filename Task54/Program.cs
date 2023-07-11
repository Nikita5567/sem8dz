/*
        Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
        Например, задан массив:
        1 4 7 2
        5 9 2 3
        8 4 2 4
        В итоге получается вот такой массив:
        7 4 2 1
        9 5 3 2
        8 4 4 2
*/


Random rnd = new Random();

int m = rnd.Next(4, 6);
int n = rnd.Next(4, 6);

int[,] arr = new int[m, n];

arr = GeneradeArray(arr, m, n);
Output(arr, m, n);

arr = Sort(arr, m, n);
Output(arr, m, n);

int[,] GeneradeArray(int[,] arr, int m, int n) {
    Random rand = new Random();

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            arr[i, j] = rand.Next(1, 10);
        }
    }


    return arr;
}

void Output(int[,] arr, int m, int n) {
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] Sort(int[,] arr, int m, int n) {
    int temp = 0;
    Console.WriteLine("Отсортированная матрица");

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            if (j < n - 1) {
                if (arr[i, j] < arr[i, j + 1] && j < n - 1) {
                    temp = arr[i, j];
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j + 1] = temp;
                    j = -1;
            }
            }
        }
    }


    return arr;
}