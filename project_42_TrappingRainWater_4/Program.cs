


int[] height1 = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
int[] height2 = { 4, 2, 0, 3, 2, 5 };
int[] height3 = { 5, 1, 2, 0, 11, 9, 1, 1, 3, 3, 5, 6, 3, 2, 1, 5, 5, 1, 1, 1, 5, 0, 1, 3, 8, 6, 4 };
int[] height4 = { 2, 0, 2 };
int[] height5 = { 0, 1, 2, 0, 3, 0, 1, 2, 0, 0, 4, 2, 1, 2, 5, 0, 1, 2, 0, 2 };
int[] height6 = { 5, 4, 1, 2 };
int[] height7 = { 9, 6, 8, 8, 5, 6, 3 };


//Console.WriteLine(Trap(height1));
//Console.WriteLine(Trap(height2));
Console.WriteLine(Trap(height3));
//Console.WriteLine(Trap(height4));
//Console.WriteLine(Trap(height5));
//Console.WriteLine(Trap(height6));
//Console.WriteLine(Trap(height7));

Console.ReadLine();


int Trap(int[] height)
{
    int i = 0, leftMax = height[0], trapped = 0;
    int j = height.Length - 1, rightMax = height[j];

    while (i < j)
    {
        if (leftMax <= rightMax)
        {
            trapped += leftMax - height[i];
            i++;
            leftMax = Math.Max(leftMax, height[i]);
        }
        else
        {
            trapped += rightMax - height[j];
            j--;
            rightMax = Math.Max(rightMax, height[j]);
        }
    }

    return trapped;
}
