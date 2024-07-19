

using System.Text;

string a1 = "11";
string b1 = "1";

string a2 = "1010";
string b2 = "1011";

string a3 = "0";
string b3 = "0";

//Console.WriteLine(AddBinary(a1,b1));
//Console.WriteLine(AddBinary(a2,b2));
Console.WriteLine(AddBinary(a3,b3));

Console.ReadLine();





string AddBinary(string a, string b)
{
    if (a[0] =='0' && b[0] == '0') {  return "0"; }
    if(a.Length > 8 || b.Length > 8) { return "0"; }

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

    int sum = GetSum(list,binary);

    string result = ConverToBinary(sum,binary);

    return result;
}

int GetSum(List<string> list, Dictionary<int, int> binary)
{
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

    return nums[0] + nums[1];
}


string ConverToBinary(int sum, Dictionary<int,int> binary)
{
    StringBuilder sb = new StringBuilder();
    for (int i = binary.Count - 1; i >= 0; i--)
    {
        if (binary[i] <= sum)
        {
            sb.Append('1');
            sum -= binary[i];
        }
        else
        {
            sb.Append('0');
        }
    }
    

    return sb.ToString().TrimStart('0');
}