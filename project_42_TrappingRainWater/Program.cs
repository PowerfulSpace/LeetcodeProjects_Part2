

int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };


Console.WriteLine(Trap(height));

Console.ReadLine();


int Trap(int[] height)
{
    int[,] array = CreatingMatrix(height);

    bool start = false;
    bool end = false;


    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            if (height[col] == row)
            {

            }
        }
    }

    return 1;
}

int[,] CreatingMatrix(int[] height)
{
    int maxHeight = height.Max();

    int[,] array = new int[maxHeight, height.Length];

    int level = 1;

    for (int row = array.GetLength(0) - 1; row > 0; row--)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            if (height[col] >= level)
            {
                array[row, col] = 1;
            }
        }
        level++;
    }


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }

    return array;
}