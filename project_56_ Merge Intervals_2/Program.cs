

using System.Collections.Generic;

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
    List<int[]> res = new();

    Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
    var intervalStart = intervals[0][0];
    var intervalEnd = intervals[0][1];

    for (int i = 1; i < intervals.Length; i++)
    {
        if (intervals[i][0] <= intervalEnd)
        {
            intervalEnd = Math.Max(intervalEnd, intervals[i][1]);
            intervalStart = Math.Min(intervals[i][0], intervalStart);
        }
        else
        {
            res.Add(new int[] { intervalStart, intervalEnd });

            intervalStart = intervals[i][0];
            intervalEnd = intervals[i][1];
        }
    }

    res.Add(new int[] { intervalStart, intervalEnd });

    return res.ToArray(); ;
}