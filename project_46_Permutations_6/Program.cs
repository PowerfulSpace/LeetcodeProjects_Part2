

int[] nums1 = { 1, 2, 3, };
int[] nums2 = { 0, 1 };
int[] nums3 = { 1 };
int[] nums4 = { 1, 2, 3, 4 };

Print(Permute(nums1));
Print(Permute(nums2));
Print(Permute(nums3));
Print(Permute(nums4));

Console.ReadLine();


IList<IList<int>> Permute(int[] nums)
{
    var results = new List<IList<int>>();
    Permutation(results, nums, 0, nums.Length - 1);

    return results;
}

void Permutation(IList<IList<int>> results, int[] nums, int start, int end)
{
    if (start == end)
    {
        results.Add(new List<int>(nums));
        return;
    }

    for (int i = start; i <= end; i++)
    {
        Swap(nums, start, i);
        Permutation(results, nums, start + 1, end);
        Swap(nums, start, i);
    }
}

void Swap(int[] nums, int i, int j)
{
    var tmp = nums[i];
    nums[i] = nums[j];
    nums[j] = tmp;
}


void Print(IList<IList<int>> lists)
{
    Console.WriteLine();
    Console.WriteLine();
    foreach (var list in lists)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i]);
        }
        Console.WriteLine();
    }
}