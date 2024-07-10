

using System.Collections;
using System.Linq;

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

//Insert(nums1, new int[] { 2, 5 });
//Insert(nums2, new int[] { 4, 8 });
Insert(nums3, new int[] { 0, 0 });


Console.ReadLine();

int[][] Insert(int[][] intervals, int[] newInterval)
{

    List<int[]> result = new();
    int n = intervals.Length;
    int i = 0;

    while (i < n && newInterval[0] > intervals[i][1])
    {
        result.Add(intervals[i]);
        i++;
    }

    while (i < n && intervals[i][0] <= newInterval[1])
    {
        newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
        newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
        i++;
    }

    result.Add(newInterval);

    while (i < n)
    {
        result.Add(intervals[i]);
        i++;
    }




    return result.ToArray();
}