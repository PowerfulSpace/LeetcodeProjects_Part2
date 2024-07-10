

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
Insert(nums3, new int[] { 0,0});


Console.ReadLine();

int[][] Insert(int[][] intervals, int[] newInterval)
{

     var result = new List<int[]>();

    foreach (var interval in intervals)
    {
        if (interval[1] < newInterval[0])
        {
            result.Add(interval);
        }
        else if (interval[0] > newInterval[1])
        {
            result.Add(newInterval);
            newInterval = interval;
        }
        else
        {
            newInterval[0] = Math.Min(interval[0], newInterval[0]);
            newInterval[1] = Math.Max(interval[1], newInterval[1]);
        }
    }

    result.Add(newInterval);

    return result.ToArray();
}