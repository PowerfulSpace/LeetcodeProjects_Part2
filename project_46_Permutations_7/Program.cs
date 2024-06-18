

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
    IList<IList<int>> result = new List<IList<int>>();
    Backtrack(nums, new List<int>(), new bool[nums.Length], result);
    return result;
}

void Backtrack(int[] nums, List<int> current, bool[] used, IList<IList<int>> result)
{
    if (current.Count == nums.Length)
    {
        result.Add(new List<int>(current));
        return;
    }

    for (int i = 0; i < nums.Length; i++)
    {
        if (!used[i])
        {
            current.Add(nums[i]);
            used[i] = true;
            Backtrack(nums, current, used, result);
            current.RemoveAt(current.Count - 1);
            used[i] = false;
        }
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