
int n1 = 2;
int n2 = 3;
int n3 = 5;

Console.WriteLine(ClimbStairs(n1));
Console.WriteLine(ClimbStairs(n2));
Console.WriteLine(ClimbStairs(n3));

Console.ReadLine();

int ClimbStairs(int n)
{
    int data = 0;
    int result = CalculateSteps(n,1,0, ref data);

    return data;
}



int CalculateSteps(int stairs,int step, int count,ref int result)
{

    if(count > stairs)
    {
        return count;
    }
    if (count == stairs)
    {
        result += 1;
        return count;
    }

    for (int i = step; i < 3; i++)
    {
        count += i;
        count = CalculateSteps(stairs, i, count,ref result);
        count -= i;       
    }

    return count;
}