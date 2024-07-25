

int[] nums1 = { 2, 0, 2, 1, 1, 0 };
int[] nums2 = { 2, 0, 1 };

SortColors(nums1);

Console.ReadLine();


void SortColors(int[] nums)
{
    int low = 0, mid = 0, high = nums.Length - 1;

    while (mid <= high)
    {
        if (nums[mid] == 0)
        {
            Swap(nums, low, mid);
            low++;
            mid++;
        }
        else if (nums[mid] == 1)
        {
            mid++;
        }
        else
        {
            Swap(nums, mid, high);
            high--;
        }
    }
}
void Swap(int[] nums, int i, int j)
{
    int temp = nums[i];
    nums[i] = nums[j];
    nums[j] = temp;
}