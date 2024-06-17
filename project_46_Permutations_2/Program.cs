

int[] nums1 = { 1, 2, 3, };
int[] nums2 = { 0, 1 };
int[] nums3 = { 1 };
int[] nums4 = { 1, 2, 3, 4 };


//Permute(nums1);
//Permute(nums2);
//Permute(nums3);
Permute(nums4);

Console.ReadLine();

List<IList<int>> output;

IList<IList<int>> Permute(int[] nums)
{

    output = new List<IList<int>>();

    Permutations(nums.ToList(), new List<int>());

    return output;
}

void Permutations(List<int> nums, List<int> currentPermutation)
{
    if (nums.Count == 1)
    {
        currentPermutation.Add(nums[0]);
        output.Add(currentPermutation);
        return;
    }

    for (int i = 0; i < nums.Count; i++)
    {
        List<int> copyPermutation = new List<int>(currentPermutation);
        List<int> copyNums = new List<int>(nums);

        copyPermutation.Add(nums[i]);
        copyNums.RemoveAt(i);

        Permutations(copyNums, copyPermutation);
    }
}