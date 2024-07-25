

int[] nums1 = { 2, 0, 2, 1, 1, 0 };
int[] nums2 = { 2, 0, 1 };

SortColors(nums1);

Console.ReadLine();


void SortColors(int[] nums)
{
    List<int> red = new List<int>();
    List<int> white = new List<int>();
    List<int> blue = new List<int>();
   

    for (int i = 0; i < nums.Length; i++)
    {
        switch (nums[i])
        {
            case 0:
                red.Add(0);
                break;
            case 1:
                white.Add(1);
                break;
            case 2:
                blue.Add(2);
                break;
        }
    }
    List<int> colors = new List<int>(red);
    colors = colors.Concat(white).ToList();
    colors = colors.Concat(blue).ToList();


    for (int i = 0; i < colors.Count; i++)
    {
        nums[i] = colors[i];
    }
}


