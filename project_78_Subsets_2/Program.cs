

int[] nums1 = { 1, 2, 3 };
int[] nums2 = { 0 };

Subsets(nums1);
Subsets(nums2);


Console.ReadLine();



IList<IList<int>> Subsets(int[] nums)
{
    List<IList<int>> result = new List<IList<int>>();

    SubArrays(nums, 0,new List<int>(), result);

    return result;
}

void SubArrays(int[] nums, int index, List<int> list, List<IList<int>> result)
{
    result.Add(new List<int>(list));

    if (index == nums.Length)
    {
        return;
    }
    
    for (int i = index; i < nums.Length; i++)
    {
        list.Add(nums[i]);
        SubArrays(nums,i + 1,list,result);
        list.RemoveAt(list.Count - 1);
    }
}