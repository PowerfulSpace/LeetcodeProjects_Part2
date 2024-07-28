

int[] nums1 = { 1, 2, 3 };
int[] nums2 = { 0 };

Subsets(nums1);
Subsets(nums2);


Console.ReadLine();



IList<IList<int>> Subsets(int[] nums)
{
    var ret = new List<IList<int>>();
    GenerateSubsets(nums, 0, new List<int>(), ret);
    return ret;
}
void GenerateSubsets(int[] num, int pos, List<int> temp, List<IList<int>> ret)
{
    ret.Add(new List<int>(temp));
    for (int i = pos; i < num.Length; i++)
    {
        temp.Add(num[i]);
        GenerateSubsets(num, i + 1, temp, ret);
        temp.RemoveAt(temp.Count - 1);
    }
}
