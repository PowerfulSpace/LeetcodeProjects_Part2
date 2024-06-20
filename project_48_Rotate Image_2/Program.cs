
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

//Добавить миетод на отображение
void Rotate(int[][] matrix)
{
    int n = matrix.Length;
    for (int i = 0; i < n; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            int temp = matrix[i][j];
            matrix[i][j] = matrix[j][i];
            matrix[j][i] = temp;
        }
    }
    for (int i = 0; i < n; i++)
    {
        Array.Reverse(matrix[i]);
    }
}