

int num1 = 3;
int num2 = 1;

GenerateMatrix(num1);
GenerateMatrix(num2);

Console.ReadLine();


int[][] GenerateMatrix(int n)
{
    int[][] ans = new int[n][];
    for (int i = 0; i < n; i++)
    {
        ans[i] = new int[n];
    }

    int x = 0;
    int y = 0;
    int direction = 1;

    //ans[x][y] = 0; 
    for (int i = 1; i <= n * n; i++)
    {
        ans[y][x] = i;
        if (direction == 1)
        {
            if (x == n - 1 || ans[y][x + 1] > 0)
            {
                direction = 2;
                y++;
            }
            else
            {
                x++;
            }
        }
        else if (direction == 2)
        {
            if (y == n - 1 || ans[y + 1][x] > 0)
            {
                direction = 3;
                x--;
            }
            else
            {
                y++;
            }
        }
        else if (direction == 3)
        {
            if (x == 0 || ans[y][x - 1] > 0)
            {
                direction = 4;
                y--;
            }
            else
            {
                x--;
            }
        }
        else if (direction == 4)
        {
            if (y == 0 || ans[y - 1][x] > 0)
            {
                direction = 1;
                x++;
            }
            else
            {
                y--;
            }
        }
    }

    return ans;
}
