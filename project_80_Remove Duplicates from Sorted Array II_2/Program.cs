

int[] nums1 = { 1, 1, 1, 2, 2, 3 };
int[] nums2 = { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
int[] nums3 = { 1,1,1,1 };

//Console.WriteLine(RemoveDuplicates(nums1));
//Console.WriteLine(RemoveDuplicates(nums2));
Console.WriteLine(RemoveDuplicates(nums3));

Console.ReadLine();



int RemoveDuplicates(int[] nums)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();

    int step = 0;

    int indexSwap = 0;
    int i = 0;

    for (i = 0; i < nums.Length && indexSwap < nums.Length; i++, indexSwap++)
    {
        if (dict.ContainsKey(nums[i]))
        {
            if (dict[nums[i]] < 2)
            {
                dict[nums[i]]++;
                Swap(nums, indexSwap,i);
            }
            else
            {
                while (indexSwap < nums.Length && nums[i] == nums[indexSwap])
                {
                    indexSwap++;
                }
                if (i == nums.Length - 1 || indexSwap >= nums.Length - 1)
                {
                    indexSwap++;
                    break;
                }

                Swap(nums, indexSwap, i);
            }
        }
        else
        {
            dict[nums[i]] = 1;
            Swap(nums, indexSwap, i);
        }
    }

    return indexSwap - (indexSwap - i);
}

void Swap(int[] nums, int a, int b)
{
    int temp = nums[a];
    nums[a] = nums[b];
    nums[b] = temp;
}