

int num1 = 3;
int num2 = 1;

GenerateMatrix(num1);
GenerateMatrix(num2);

Console.ReadLine();


int[][] GenerateMatrix(int n)
{
    int[][] result = CreateArray(n);
    int num = 1;

    int left = 0;
    int top = 0;
    int right = n - 1;
    int bot = n - 1;

    while (left <= right && top <= bot)
    {
        for (int i = left; i <= right; i++)
        {
            result[top][i] = num;
            num++;
        }
        top++;

        for (int i = top; i <= bot; i++)
        {
            result[i][right] = num;
            num++;
        }
        right--;

        for (int i = right; i >= left; i--)
        {
            result[bot][i] = num;
            num++;
        }
        bot--;

        for (int i = bot; i >= top; i--)
        {
            result[i][left] = num;
            num++;
        }
        left++;
    }



    return result;
}


int[][] CreateArray(int n)
{

    int[][] result = new int[n][];
    for (int i = 0; i < n; i++)
    {
        result[i] = new int[n];
    }
    return result;
}