

int[] nums1 = { 1, 1, 2 };
int[] nums2 = { 1, 2, 3 };
int[] nums3 = { 3, 3, 1, 2, 3, 2, 3, 1 };


Print(PermuteUnique(nums1));
Print(PermuteUnique(nums2));
//Print(PermuteUnique(nums3));

Console.ReadLine();


IList<IList<int>> PermuteUnique(int[] nums)
{
    IList<IList<int>> result = new List<IList<int>>();
    Array.Sort(nums);
    Permutations(nums.ToList(), new List<int>(), result);

    return result;
}

void Permutations(List<int> nums, List<int> currentPermutation, IList<IList<int>> result)
{
    if (nums.Count == 1)
    {
        currentPermutation.Add(nums[0]);
        result.Add(currentPermutation);
        return;
    }

    int previousNum = -1;

    for (int i = 0; i < nums.Count; i++)
    {
        while (i < nums.Count && nums[i] == previousNum)
        {
            i++;
        }

        if (i >= nums.Count) return;

        previousNum = nums[i];
        List<int> copyPermutation = new List<int>(currentPermutation);
        List<int> copyNums = new List<int>(nums);

        copyPermutation.Add(nums[i]);
        copyNums.RemoveAt(i);

        Permutations(copyNums, copyPermutation, result);
    }
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