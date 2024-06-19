

int[] nums1 = { 1, 1, 2 };
int[] nums2 = { 1, 2, 3 };
int[] nums3 = { 3, 3, 1, 2, 3, 2, 3, 1 };


Print(PermuteUnique(nums1));
Print(PermuteUnique(nums2));
//Print(PermuteUnique(nums3));

Console.ReadLine();


IList<IList<int>> PermuteUnique(int[] nums)
{
    var output = new List<IList<int>>();
    if (nums.Length == 0)
    {
        output.Add(new List<int>());
        return output;
    }

    var seen = new HashSet<int>();
    for (var i = 0; i < nums.Length; i++)
    {
        var num = nums[i];
        if (seen.Add(num))
        {
            var nextNums = nums.ToList();
            nextNums.RemoveAt(i);
            var perms = PermuteUnique(nextNums.ToArray());
            output.AddRange(perms.Select(p => new List<int> { num }.Concat(p).ToList()));
        }
    }

    return output;
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