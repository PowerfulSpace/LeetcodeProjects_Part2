

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

void Permutations(List<int> nums, List<int> comb, IList<IList<int>> result)
{
    if (nums.Count == 0)
    {
        result.Add(new List<int>(comb));

        return;
    }

    for (int i = 0; i < nums.Count; i++)
    {
        List<int> clone = new List<int>(nums);
        List<int> combination = new List<int>(comb);

        while (i < nums.Count - 1 && clone[i] == clone[i + 1])
        {
            i++;
        }

        combination.Add(clone[i]);
        clone.RemoveAt(i);

        Permutations(clone, combination, result);
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