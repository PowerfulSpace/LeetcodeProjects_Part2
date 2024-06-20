


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
    for (int row = 0; row < n; row++)
    {
        for (int col = row + 1; col < n; col++)
        {
            int temp = matrix[row][col];
            matrix[row][col] = matrix[col][row];
            matrix[col][row] = temp;
        }
    }
    for (int i = 0; i < n; i++)
    {
        Array.Reverse(matrix[i]);
    }
}