
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
//Rotate(nums2);



Console.ReadLine();


void Rotate(int[][] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = i; j < matrix.Length; j++)
        {
            temp = matrix[i][j];
            matrix[i][j] = matrix[j][i];
            matrix[j][i] = temp;
        }
    }

    for (int i = 0; i < matrix.Length; i++)
    {
        for (int j = 0; j < matrix.Length / 2; j++)
        {
            temp = matrix[i][j];
            matrix[i][j] = matrix[i][matrix.Length - 1 - j];
            matrix[i][matrix.Length - 1 - j] = temp;
        }
    }
}