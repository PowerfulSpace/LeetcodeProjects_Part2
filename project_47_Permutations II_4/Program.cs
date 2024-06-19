

int[] nums1 = { 1, 1, 2 };
int[] nums2 = { 1, 2, 3 };
int[] nums3 = { 3, 3, 1, 2, 3, 2, 3, 1 };


Print(PermuteUnique(nums1));
Print(PermuteUnique(nums2));
//Print(PermuteUnique(nums3));

Console.ReadLine();


IList<IList<int>> PermuteUnique(int[] nums)
{
    Array.Sort(nums);
    IList<IList<int>> result = new List<IList<int>>();
    backtracking(nums, new bool[nums.Length], new List<int>(), result);
    return result;
}
void backtracking(int[] nums, bool[] used, IList<int> path, IList<IList<int>> result)
{
    if (path.Count == nums.Length)
    {
        result.Add(new List<int>(path));
        return;
    }
    for (int i = 0; i < nums.Length; i++)
    {
        if (used[i]) continue;
        if (i > 0 && nums[i] == nums[i - 1] && !used[i - 1]) continue;
        used[i] = true;
        path.Add(nums[i]);
        backtracking(nums, used, path, result);
        used[i] = false;
        path.RemoveAt(path.Count - 1);
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