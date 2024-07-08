
int[][] matrix1 = new int[3][];
matrix1[0] = new int[3] { 1, 2, 3 };
matrix1[1] = new int[3] { 4, 5, 6 };
matrix1[2] = new int[3] { 7, 8, 9 };

SpiralOrder(matrix1);

Console.ReadLine();




IList<int> SpiralOrder(int[][] matrix)
{
    var output = new List<int>();

    int top = 0;
    int right = matrix[0].Length - 1;
    int bottom = matrix.Length - 1;
    int left = 0;

    while (top <= bottom && left <= right)
    {
        for (int i = left; i <= right; i++)
        {
            output.Add(matrix[top][i]);
        }
        top++;

        for (int i = top; i <= bottom; i++)
        {
            output.Add(matrix[i][right]);
        }
        right--;

        if (top <= bottom)
        {
            for (int i = right; i >= left; i--)
            {
                output.Add(matrix[bottom][i]);
            }
            bottom--;
        }

        if (left <= right)
        {
            for (int i = bottom; i >= top; i--)
            {
                output.Add(matrix[i][left]);
            }
            left++;
        }
    }

    return output;
}
