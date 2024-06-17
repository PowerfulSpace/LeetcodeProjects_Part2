

int[] nums1 = { 1, 2, 3, };
int[] nums2 = { 0, 1 };
int[] nums3 = { 1 };
int[] nums4 = { 1, 2, 3, 4 };


Permute(nums1);
Permute(nums2);
Permute(nums3);
Permute(nums4);

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
        var num = nums[i];
        var perms = Permute(nums.Where(n => n != num).ToArray());
        output.AddRange(perms.Select(p => new List<int> { num }.Concat(p).ToList()));
    }

    return output;
}
