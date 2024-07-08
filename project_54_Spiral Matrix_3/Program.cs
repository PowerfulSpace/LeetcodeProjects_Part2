
int[][] matrix1 = new int[3][];
matrix1[0] = new int[3] { 1, 2, 3 };
matrix1[1] = new int[3] { 4, 5, 6 };
matrix1[2] = new int[3] { 7, 8, 9 };

SpiralOrder(matrix1);

Console.ReadLine();




IList<int> SpiralOrder(int[][] matrix)
{
    var cols = matrix.First().Length;
    var rows = matrix.Length;
    var size = cols * rows;
    var result = new List<int>(size);
    var l = 0;
    var r = matrix[0].Length - 1;
    var t = 0;
    var b = matrix.Length - 1;
    while (result.Count < size)
    {
        for (int i = l; i <= r; i++) result.Add(matrix[t][i]);
        t++;
        for (int i = t; i <= b && result.Count < size; i++) result.Add(matrix[i][r]);
        r--;
        for (int i = r; i >= l && result.Count < size; i--) result.Add(matrix[b][i]);
        b--;
        for (int i = b; i >= t && result.Count < size; i--) result.Add(matrix[i][l]);
        l++;
    }
    return result;
}
