

int[] nums1 = { 1, 2, 3 };
int[] nums2 = { 0 };

Subsets(nums1);
Subsets(nums2);


Console.ReadLine();



IList<IList<int>> Subsets(int[] nums)
{
    List<IList<int>> subsets = new List<IList<int>>();
    subsets.Add(new List<int>());
    foreach (int x in nums)
    {
        var tmp = subsets;
        foreach (List<int> list in subsets.ToArray())
        {
            List<int> tmpList = new(list);
            tmpList.Add(x);
            tmp.Add(tmpList);
        }
        subsets = tmp;
    }
    return subsets;
}
