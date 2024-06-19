
int[] nums1 = { 1, 1, 2 };
int[] nums2 = { 1, 2, 3 };


Print(PermuteUnique(nums1));
Print(PermuteUnique(nums2));

Console.ReadLine();


IList<IList<int>> PermuteUnique(int[] nums)
{
    IList<IList<int>> result = new List<IList<int>>();

    Permutations(nums.ToList(), new List<int>(), result);

    return result;
}

void Permutations(List<int> nums, List<int> comb, IList<IList<int>> result)
{
    if (nums.Count == 0)
    {
        bool combUnic = false;
        foreach (var list in result.Select(x => x))
        {
            combUnic = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (comb[i] != list[i])
                {
                    combUnic = true;
                    break;
                }
            }
            if(combUnic == false) { return; }
        }

        result.Add(new List<int>(comb));

        return;
    }

    for (int i = 0; i < nums.Count; i++)
    {
        List<int> clone = new List<int>(nums);
        List<int> combination = new List<int>(comb);

        combination.Add(clone[i]);
        clone.RemoveAt(i);

        Permutations(clone, combination, result);

        combination.RemoveAt(combination.Count - 1);

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