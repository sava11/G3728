Random rnd = new Random();
// создание массва и его заполнение
int[,,] Create2DArray(int xLen, int yLen, int zLen)
{
    int[,,] arr = new int[yLen, xLen, zLen];
    for (int i = 0; i < yLen; i++)
    {
        for (int j = 0; j < xLen; j++)
        {
            for (int k = 0; k < zLen; k++)
            {
                arr[i, j, k] = 10 + i*2 + j*3 + k*6;
            }
        }
    }
    return arr;
}
// вывод двумерного массива
void Show3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}
// создание двумерного массива
int[,,] arr = Create2DArray(2, 2, 2);
// вывод двумерного массива
Show3DArray(arr);