

int[] nums1 = { 1, 1, 2 };
int[] nums2 = { 1, 2, 3 };
int[] nums3 = { 3, 3, 1, 2, 3, 2, 3, 1 };


Print(PermuteUnique(nums1));
Print(PermuteUnique(nums2));
//Print(PermuteUnique(nums3));

Console.ReadLine();


IList<IList<int>> PermuteUnique(int[] nums)
{
    var dict = new Dictionary<int, int>();
    foreach (int num in nums)
    {
        if (dict.ContainsKey(num))
            dict[num]++;
        else
            dict.Add(num, 1);
    }
    var result = new List<IList<int>>();
    var temp = new List<int>();
    Permutations(nums, dict, temp, result);
    return result;
}
void Permutations(int[] nums, Dictionary<int, int> dict, List<int> lt, List<IList<int>> result)
{
    if (lt.Count == nums.Length)
    {
        result.Add(new List<int>(lt));
    }
    foreach (var key in dict.Keys)
    {
        if (dict[key] > 0)
        {
            lt.Add(key);
            dict[key]--;
            Permutations(nums, dict, lt, result);
            dict[key]++;
            lt.RemoveAt(lt.Count - 1);
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