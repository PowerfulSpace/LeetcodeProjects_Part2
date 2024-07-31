

int[] nums1 = { 1, 1, 1, 2, 2, 3 };
int[] nums2 = { 0, 0, 1, 1, 1, 1, 2, 3, 3 };

//Console.WriteLine(RemoveDuplicates(nums1));
Console.WriteLine(RemoveDuplicates(nums2));

Console.ReadLine();



int RemoveDuplicates(int[] nums)
{
	Dictionary<int,int> dict = new Dictionary<int,int>();
	int count = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (dict.ContainsKey(nums[i]))
        {
            if (dict[nums[i]] < 2)
            {
                dict[nums[i]]++;
                count++;
            }
        }
        else
        {
            dict[nums[i]] = 1;
            count++;
        }
    }

    int index = 0;
    foreach (var key in dict.Keys)
    {
        int i = dict[key];
        while (i > 0)
        {
            nums[index] = key;
            i--;
            index++;
        }
    }

    return count;
}

