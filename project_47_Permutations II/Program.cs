

int[] nums1 = { 1, 1, 2 };
int[] nums2 = { 1, 2, 3 };


Print(PermuteUnique(nums1));
Print(PermuteUnique(nums2));

Console.ReadLine();


IList<IList<int>> PermuteUnique(int[] nums)
{
    IList<IList<int>> result = new List<IList<int>>();

    return result;
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