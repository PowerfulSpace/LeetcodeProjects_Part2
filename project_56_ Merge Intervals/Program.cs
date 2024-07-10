

int[][] nums1 = new int[4][]
{
    new int[]{1,3 },
    new int[]{2,6 },
    new int[]{8, 10 },
    new int[]{15,18 },
};

int[][] nums2 = new int[2][]
{
    new int[]{1, 4 },
    new int[]{4,5 },
};

int[][] nums3 = new int[2][]
{
    new int[]{1, 4 },
    new int[]{5,6 },
};

//Console.WriteLine(Merge(nums1));
//Console.WriteLine(Merge(nums2));
Console.WriteLine(Merge(nums3));


Console.ReadLine();

int[][] Merge(int[][] intervals)
{
    if(intervals.Length == 1) { return intervals; }

    List<List<int>> result = new List<List<int>>();

    int[] array = intervals[0];

    foreach (int[] arrayWithIntervals in intervals.Skip(1))
    {
        if (array[1] >= arrayWithIntervals[0])
        {
            result.Add(new List<int>() { array[0], arrayWithIntervals[1] });
            intervals.Skip(1);
        }
        else
        {
            result.Add(new List<int>(arrayWithIntervals));
        }
    }

    intervals = new int[result.Count][];
    int index = 0;
    foreach (var item in result)
    {
        intervals[index] = item.ToArray();
        index++;
    }


    return intervals;
}