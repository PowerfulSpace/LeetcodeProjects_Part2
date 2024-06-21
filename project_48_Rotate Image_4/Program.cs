
int[][] nums1 = new int[][]
{
    new int[3]{ 1,2,3},
    new int[3]{ 4,5,6},
    new int[3]{ 7,8,9}
};

int[][] nums2 = new int[][]
{
    new int[1]{ 1}
};

Rotate(nums1);
Rotate(nums2);



Console.ReadLine();


void Rotate(int[][] matrix)
{
    int layers = (matrix[0].Length + 2) / 2 - 1;

    for (int i = 0; i < layers; ++i)
    {
        int edgeOffset = matrix[0].Length - 2 * i - 1;
        int layerStart = i;
        int layerEnd = i + edgeOffset;

        for (int j = 0; j < edgeOffset; ++j)
        {
            int forward = j + layerStart;
            int backwards = layerEnd - j;

            int start = matrix[layerStart][forward];

            matrix[layerStart][forward] = matrix[backwards][layerStart];
            matrix[backwards][layerStart] = matrix[layerEnd][backwards];
            matrix[layerEnd][backwards] = matrix[forward][layerEnd];
            matrix[forward][layerEnd] = start;
        }
    }
}