

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
    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix[0].Length; j++)
        {
            if (matrix[i][j] == target)
            {
                return true;
            }
        }
    }
    return false;
}