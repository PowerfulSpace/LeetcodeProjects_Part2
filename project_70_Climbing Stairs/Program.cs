
int n1 = 2;
int n2 = 3;
int n3 = 5;

Console.WriteLine(ClimbStairs(n1));
Console.WriteLine(ClimbStairs(n2));
Console.WriteLine(ClimbStairs(n3));

Console.ReadLine();

int ClimbStairs(int n)
{
    int result = 0;
    int count = CalculateSteps(n,0, ref result);

    return result;
}



int CalculateSteps(int stairs,int count,ref int result)
{
    if(count > stairs) { return count; }
    if(count == stairs)
    {
        result++;
        return count;
    }

    for (int i = 1; i < 3; i++)
    {
        count += i;
        count = CalculateSteps(stairs, count, ref result);
        count -= i;       
    }

    return count;
}