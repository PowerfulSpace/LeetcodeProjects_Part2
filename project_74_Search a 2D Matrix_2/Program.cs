

int target1 = 3;
int[][] array1 = new int[3][]
{
    new int[4]{1,3,5,7},
    new int[4]{10,11,16,20},
    new int[4]{23,30,34,60}
};

int target2 = 13;
int[][] array2 = new int[3][]
{
    new int[4]{1,3,5,7},
    new int[4]{10,11,16,20},
    new int[4]{23,30,34,60}
};


Console.WriteLine(SearchMatrix(array1, target1));
Console.WriteLine(SearchMatrix(array2, target2));



Console.ReadLine();

bool SearchMatrix(int[][] matrix, int target)
{
    int m = matrix.Length, n = matrix[0].Length;
    int left = 0, right = m * n - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        int row = mid / n, col = mid % n;

        if (matrix[row][col] == target)
            return true;
        if (matrix[row][col] > target)
            right = mid - 1;
        else
            left = mid + 1;
    }

    return false;
}