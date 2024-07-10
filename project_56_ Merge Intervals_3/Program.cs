

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

Merge(nums1);
Merge(nums2);
Merge(nums3);

Console.ReadLine();

int[][] Merge(int[][] intervals)
{
    var n = intervals.Length;
    Array.Sort(intervals, (a, b) => a[0] - b[0]);
    if (n == 1) return intervals;
    var res = new List<int[]>();
    res.Add(intervals[0]);
    for (var i = 0; i < n; i++)
    {
        var interval = intervals[i];
        var last = res[res.Count - 1];
        if (interval[0] > last[1])
        {
            res.Add(interval);
        }
        else
        {
            last[1] = Math.Max(last[1], interval[1]);
        }
    }
    return res.ToArray();
}