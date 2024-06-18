

int[] nums1 = { 1, 2, 3, };
int[] nums2 = { 0, 1 };
int[] nums3 = { 1 };
int[] nums4 = { 1, 2, 3, 4 };

Print(Permute(nums1));
Print(Permute(nums2));
Print(Permute(nums3));
Print(Permute(nums4));

Console.ReadLine();



List<IList<int>> permutations;

IList<IList<int>> Permute(int[] nums)
{
    permutations = new List<IList<int>>();
    RecursivelySolve(new List<int>(), nums);
    return permutations;
}

void RecursivelySolve(List<int> curr, int[] nums)
{
    if (curr.Count == nums.Length)
    {
        permutations.Add(new List<int>(curr));
        return;
    }

    foreach (var n in nums)
    {
        if (!curr.Contains(n))
        {
            curr.Add(n);
            RecursivelySolve(curr, nums);
            curr.RemoveAt(curr.Count - 1);
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