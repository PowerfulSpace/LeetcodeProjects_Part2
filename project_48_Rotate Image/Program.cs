
int[][] nums1 = new int[][]
{
    new int[3]{ 1,2,3},
    new int[3]{ 4,5,6},
    new int[3]{ 7,8,9}
};

int[][] nums2 = new int[][]
{
    new int[1]{ 1}
};

Rotate(nums1);
Rotate(nums2);



Console.ReadLine();


void Rotate(int[][] matrix)
{

    int[][] array = GetCoppy(matrix);

    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = matrix.Length - 1, k = 0; j >= 0; j--,k++)
        {
            matrix[i][k] = array[j][i];
            Console.Write(matrix[i][k] + " ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[][] GetCoppy(int[][] matrix)
{
    int[][] array = new int[matrix.Length][];
    for (int i = 0; i < matrix.Length; i++)
    {
        array[i] = new int[matrix.Length];
    }

    for (int i = 0;i < matrix.Length; i++)
    {
        for(int j = 0;j < matrix.Length; j++)
        {
            array[i][j] = matrix[i][j];
        }
    }
    return array;
}