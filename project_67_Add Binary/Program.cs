
string a1 = "11";
string b1 = "1";

string a2 = "1010";
string b2 = "1011";

Console.WriteLine(AddBinary(a1,b1));
Console.WriteLine(AddBinary(a2,b2));

Console.ReadLine();





string AddBinary(string a, string b)
{
	string result = string.Empty;
	Dictionary<int, int> binary = new Dictionary<int, int>()
	{
		[0] = 1,
		[1] = 2,
        [2] = 4,
        [3] = 8,
        [4] = 16,
        [5] = 32,
        [6] = 64,
        [7] = 128
    };
    List<string> list = new List<string>();
	
	list.Add(a);
	list.Add(b);

	int[] nums = new int[2];
	int indexNum = 0;
	int indexBinary = 0;

	foreach (string s in list)
	{
		int num = 0;
		indexBinary = 0;
        for (int i = s.Length - 1; i >= 0; i--, indexBinary++)
        {
			if (s[i] == '1')
			{
				num += binary[indexBinary];
            }
        }
		nums[indexNum] = num;
		indexNum++;
    }
	


    return result;
}