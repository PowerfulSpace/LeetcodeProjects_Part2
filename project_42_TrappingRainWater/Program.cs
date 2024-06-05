

using System.Threading.Tasks;

int[] height1 = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
int[] height2 = { 4, 2, 0, 3, 2, 5 };


Console.WriteLine(Trap(height1));
Console.WriteLine(Trap(height2));

Console.ReadLine();


int Trap(int[] height)
{
    int[,] array = CreatingMatrix(height);
    int sum = 0;

    bool isStorageTank = false;


    for (int row = 0; row < array.GetLength(0); row++)
    {
        int currentSum = 0;
        isStorageTank = false;

        for (int col = 0; col < array.GetLength(1); col++)
        {
            if (array[row,col] == 1)
            {
                isStorageTank = true;

                if (currentSum > 0)
                {
                    sum += currentSum;
                    currentSum = 0;
                }
            }

            if (isStorageTank == true && array[row, col] == 0)
            {
                currentSum++;
            }
        }
    }

    return sum;
}

int[,] CreatingMatrix(int[] height)
{
    int maxHeight = height.Max();

    int[,] array = new int[maxHeight, height.Length];

    int level = maxHeight;

    for (int row = array.GetLength(0) - 1; row >= 0; row--)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            if (height[col] >= level)
            {
                array[row, col] = 1;
            }
        }
        level--;
    }



    for (int row = array.GetLength(0) - 1; row >= 0; row--)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write(array[row, col] + " ");
        }
        Console.WriteLine();
    }

    return array;
}