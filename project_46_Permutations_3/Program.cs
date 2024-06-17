

int[] nums1 = { 1, 2, 3, };
int[] nums2 = { 0, 1 };
int[] nums3 = { 1 };
int[] nums4 = { 1, 2, 3, 4 };

IList<IList<int>> perms = new List<IList<int>>() { new List<int> { 1, 2, 3 }, new List<int> { 2, 3, 4 } };

var a = perms.Select(x => new List<int>() { 11}.Concat(x));
Console.WriteLine();

Print(Permute(nums1));
Print(Permute(nums2));
Print(Permute(nums3));
Print(Permute(nums4));

Console.ReadLine();

IList<IList<int>> Permute(int[] nums)
{
    var output = new List<IList<int>>();
    if (nums.Length == 1)
    {
        output.Add(new List<int> { nums[0] });
        return output;
    }

    for (var i = 0; i < nums.Length; i++)
    {
        int num = nums[i];

        int[] specificNums = nums.Where(n => n != num).ToArray();

        IList<IList<int>> perms = Permute(specificNums);

        IEnumerable<IList<int>> addingNum = perms.Select(p => new List<int> { num }.Concat(p).ToList());

        output.AddRange(addingNum);
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