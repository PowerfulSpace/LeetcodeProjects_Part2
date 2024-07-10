

int[][] nums1 = new int[2][]
{
    new int[]{1,3 },
    new int[]{6,9 }

};

int[][] nums2 = new int[5][]
{
    new int[]{1,2 },
    new int[]{3,5},
    new int[]{6,7},
    new int[]{8,10},
    new int[]{12,16}
};
int[][] nums3 = new int[1][]
{
    new int[]{1,5 },

};

Insert(nums1, new int[] { 2, 5 });
Insert(nums2, new int[] { 4, 8 });
Insert(nums3, new int[] { 2,7 });


Console.ReadLine();

int[][] Insert(int[][] intervals, int[] newInterval)
{
    int[][] newintervals = new int[intervals.Length + 1][];
    for (int i = 0; i < intervals.Length; i++)
    {
        newintervals[i] = intervals[i];
    }
    newintervals[newintervals.Length - 1] = newInterval;
    intervals = newintervals;

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