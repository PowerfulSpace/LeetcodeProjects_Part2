

int[] nums1 = { 1, 2, 3, };
int[] nums2 = { 0, 1 };
int[] nums3 = { 1 };
int[] nums4 = { 1, 2, 3, 4};


Permute(nums1);
Permute(nums2);
Permute(nums3);
Permute(nums4);

Console.ReadLine();

List<IList<int>> result;
IList<IList<int>> Permute(int[] nums)
{
    result = new List<IList<int>>();

    Permutations(nums.ToList(), new List<int>());

    return result;
}

void Permutations(List<int> nums, List<int> combination)
{

    if(nums.Count == 1)
    {
        combination.Add(nums[0]);
        result.Add(combination);
        return;
    }

    for (int i = 0; i < nums.Count; i++)
    {
        List<int> comb = new List<int>(combination);
        List<int> clone = new List<int>(nums);

        comb.Add(clone[i]);
        clone.RemoveAt(i);

        Permutations(clone, comb);
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