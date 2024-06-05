


int[] height1 = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
int[] height2 = { 4, 2, 0, 3, 2, 5 };
int[] height3 = { 10527, 740, 9013, 1300, 29680, 4898, 13993, 15213, 18182, 24254, 3966, 24378, 11522, 9190, 6389, 32067 };


Console.WriteLine(Trap(height1));
Console.WriteLine(Trap(height2));
Console.WriteLine(Trap(height3));

Console.ReadLine();


int Trap(int[] height)
{
    return 1;
}

void FindingHeights(int[] height,int sum,int max)
{

	for (int i = 0; i < height.Length; i++)
	{
		if (i != 0 && height[i] > max)
		{
			sum = max - height[i];
            max = height[i];
        }
	}

}

