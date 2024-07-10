

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
    if(intervals.Length == 1) { return intervals; }

    intervals = intervals.OrderBy(x => x[0]).ToArray();

    List<int[]> result = new List<int[]>();

    result.Add(intervals[0]);

    foreach (int[] arrayWithIntervals in intervals.Skip(1))
    {
        int[] array = result.Last();
        if (array[1] >= arrayWithIntervals[0])
        {
            array[0] = array[0] < arrayWithIntervals[0] ? array[0] : arrayWithIntervals[0];
            array[1] = array[1] > arrayWithIntervals[1] ? array[1] : arrayWithIntervals[1];

            intervals.Skip(1);
        }
        else
        {
            result.Add(arrayWithIntervals);
        }

    }

    return result.ToArray();
}