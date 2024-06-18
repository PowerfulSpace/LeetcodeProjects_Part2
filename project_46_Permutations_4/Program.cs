

int[] nums1 = { 1, 2, 3, };
int[] nums2 = { 0, 1 };
int[] nums3 = { 1 };
int[] nums4 = { 1, 2, 3, 4 };

Print(Permute(nums1));
Print(Permute(nums2));
Print(Permute(nums3));
Print(Permute(nums4));

Console.ReadLine();

List<IList<int>> output;

IList<IList<int>> Permute(int[] nums)
{
    output = new List<IList<int>>();
    BackTrack(nums, new HashSet<int>());
    return output;
}

void BackTrack(int[] nums, HashSet<int> h)
{
    if (h.Count == nums.Length)
    {
        // base case
        output.Add(new List<int>(h));
        return;
    }
    for (int i = 0; i < nums.Length; ++i)
    {
        if (h.Contains(nums[i]))
        {
            continue;
        }
        h.Add(nums[i]);
        BackTrack(nums, h);
        h.Remove(nums[i]);
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