

int[] nums1 = { 1, 2, 3 };
int[] nums2 = { 0 };

Subsets(nums1);
Subsets(nums2);


Console.ReadLine();



IList<IList<int>> Subsets(int[] nums)
{
    List<IList<int>> result = new List<IList<int>>();
    result.Add(new List<int>());
    int left = 0;
    int rigth = 1;

    int count = 1;
    int index = 0;


    while (count <= nums.Length)
    {
        List<int> list;

        while (rigth <= nums.Length)
        {
            list = new List<int>();
            for (int i = left; i < rigth; i++)
            {
                list.Add(nums[i]);
            }
            result.Add(list);
            left++;
            rigth++;
        }

        count++;
        left = 0;
        rigth = count;
    }


    return result;
}

