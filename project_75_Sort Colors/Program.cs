

int[] nums1 = { 2, 0, 2, 1, 1, 0 };
int[] nums2 = { 2, 0, 1 };

SortColors(nums1);

Console.ReadLine();


void SortColors(int[] nums)
{
    Dictionary<int, int> colors = new Dictionary<int, int>()
    {
        [0] = 0,
        [1] = 0,
        [2] = 0,
    };

    for (int i = 0; i < nums.Length; i++)
    {
        colors[nums[i]]++;
    }
    int index = 0;

    foreach (int key in colors.Keys)
    {
        int count = colors[key];
        while(count > 0)
        {
            nums[index] = key;
            count--;
            index++;
        }
    }
}


