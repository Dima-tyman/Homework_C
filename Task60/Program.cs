Console.Clear();

int[,,] FillArray3D (int I, int J, int K, int min, int max) {
    int[,,] arr = new int[I, J, K];
    int[] ar = new int[arr.Length];
    int l = 0;
    bool rep = true;
    for (int i = 0; i < I; i++)
        for (int j = 0; j < J; j++)
            for (int k = 0; k < K; k++, l++)
                do {
                    arr[i, j, k] = new Random().Next(min, max + 1);
                    ar[l] = arr[i, j, k];
                    rep = false;
                    for (int m = l - 1; m >= 0; m--)
                        if (ar[m] == ar[l]) {rep = true; break;}
                } while (rep);               
    return arr;
}

void PrintArray (int[,,] arr) {
    for (int k = 0; k < arr.GetLength(2); k++)
        for (int i = 0; i < arr.GetLength(0); i++) {
            for (int j = 0; j < arr.GetLength(1); j++)
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            Console.WriteLine();
        }
            
}

int[,,] array = FillArray3D(3, 3, 2, 10, 99);
Console.WriteLine("Построчный вывод:");
PrintArray(array);

//улучшенный вывод в 3D только с массивами i*j*2 (i и j упираются в размер консоли)
void PrintArray3D (int[,,] arr) {
    int curentTop = Console.CursorTop + 1;
    for (int k = 0; k < arr.GetLength(2); k++)
        for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++) {
                Console.SetCursorPosition(k == 1 ? (j * 15) + 6 : (j * 15),
                             curentTop + (k == 1 ? (i * 6) : (i * 6) + 3));
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
    Console.SetCursorPosition(0, curentTop + arr.GetLength(0) * 6);
}

if (array.GetLength(2) > 2) Console.WriteLine("Вывод в 3D не возможен =(");
else {
    Console.WriteLine("Вывод в 3D");
    PrintArray3D(array);
}