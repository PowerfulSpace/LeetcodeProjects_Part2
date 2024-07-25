

int[] nums1 = { 2, 0, 2, 1, 1, 0 };
int[] nums2 = { 2, 0, 1 };

SortColors(nums1);

Console.ReadLine();


void SortColors(int[] nums)
{
    int i = 0, j = nums.Length - 1;

    for (int k = 0; k <= j;)
    {
        if (nums[k] == 0)
        {
            swap(nums, i, k);
            i++;
            k++;
        }
        else if (nums[k] == 2)
        {
            swap(nums, j, k);
            j--;
        }
        else
            k++;
    }
}
void swap(int[] nums, int i, int j)
{
    int t = nums[i];
    nums[i] = nums[j];
    nums[j] = t;
}