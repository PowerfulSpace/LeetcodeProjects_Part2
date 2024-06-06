


int[] height1 = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
int[] height2 = { 4, 2, 0, 3, 2, 5 };
int[] height3 = { 5, 1, 2, 0, 11, 9, 1, 1, 3, 3, 5, 6, 3, 2, 1, 5, 5, 1, 1, 1, 5, 0, 1, 3, 8, 6, 4 };
int[] height4 = { 2, 0, 2 };
int[] height5 = { 0, 1, 2, 0, 3, 0, 1, 2, 0, 0, 4, 2, 1, 2, 5, 0, 1, 2, 0, 2 };
int[] height6 = { 5, 4, 1, 2 };
int[] height7 = { 9, 6, 8, 8, 5, 6, 3 };


//Console.WriteLine(Trap(height1));
//Console.WriteLine(Trap(height2));
//Console.WriteLine(Trap(height3));
//Console.WriteLine(Trap(height4));
//Console.WriteLine(Trap(height5));
//Console.WriteLine(Trap(height6));
Console.WriteLine(Trap(height7));

Console.ReadLine();

int head;
int tail;
int Trap(int[] height)
{
    head = height[0];
    tail = height[height.Length - 1];
    if (height.Length == 0) {  return 0; }

    int result = FindingHeights(height, 0, 0,0);
    return result;
}

int FindingHeights(int[] height,int indexTail, int sum,int indexHead)
{

    if(indexTail == height.Length) { return sum; }

    if (height[indexTail] >= head && indexHead != indexTail)
    {
        int i = indexTail - 1;

        while (indexHead != indexTail)
        {
            sum += head - height[i] ;
            i--;
            indexHead++;
        }

        head = height[indexTail];
        indexHead = indexTail;
    }

    sum = FindingHeights(height, indexTail + 1, sum, indexHead);

    if(indexTail > 0 && tail < height[indexTail - 1])
    {
        tail = height[indexTail - 1];
        return sum;
    }

    if (head > tail)
    {
        int i = indexTail - 1;

        while (i != indexHead)
        {
            if(tail < height[i])
            {
                tail = height[i];
            }

            sum += tail - height[i];

            i--;
        }

        head = tail;
    }

    return sum;
}

