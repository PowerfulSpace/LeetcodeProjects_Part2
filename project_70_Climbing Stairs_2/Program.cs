
int n1 = 2;
int n2 = 3;
int n3 = 5;

Console.WriteLine(ClimbStairs(n1));
Console.WriteLine(ClimbStairs(n2));
Console.WriteLine(ClimbStairs(n3));

Console.ReadLine();

int ClimbStairs(int n)
{
        int first  = 1;     
        int second = 2;     
        int tmp = 0;        
        
        if(n<=2)
        {
            return n;
        }
        else
        {
            for(int i =3; i<=n;i++) 
            {
                tmp = second;       
                second+=first;      
                first = tmp;        
            }
        }
        return second;
}


