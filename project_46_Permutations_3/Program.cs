

int[] nums1 = { 1, 2, 3, };
int[] nums2 = { 0, 1 };
int[] nums3 = { 1 };
int[] nums4 = { 1, 2, 3, 4 };

Print(Permute(nums1));
Print(Permute(nums2));
Print(Permute(nums3));
Print(Permute(nums4));

Console.ReadLine();

IList<IList<int>> Permute(int[] nums)
{
    List<IList<int>> result = new List<IList<int>>();
    Queue<List<int>> permutations = new Queue<List<int>>();
    permutations.Enqueue(new List<int>());
    foreach (int num in nums)
    {
        int n = permutations.Count;
        for (int i = 0; i < n; i++)
        {
            List<int> oldPermutation = permutations.Dequeue();
            for (int j = 0; j <= oldPermutation.Count; j++)
            {
                List<int> newPermutation = new List<int>(oldPermutation);
                newPermutation.Insert(j, num);
                if (newPermutation.Count == nums.Length)
                {
                    result.Add(newPermutation);
                }
                else
                {
                    permutations.Enqueue(newPermutation);
                }
            }
        }
    }
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