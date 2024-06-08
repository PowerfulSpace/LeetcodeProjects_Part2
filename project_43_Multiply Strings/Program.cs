

string numA1 = "2";
string numA2 = "3";

string numB1 = "123";
string numB2 = "456";

string numC1 = "9333852702227987";
string numC2 = "85731737104263";

string numD1 = "65";
string numD2 = "4";



Console.WriteLine(Multiply(numA1, numA2));
Console.WriteLine(Multiply(numB1, numB2));
Console.WriteLine(Multiply(numC1, numC2));
Console.WriteLine(Multiply(numD1, numD2));

Console.ReadLine();

string Multiply(string num1, string num2)
{
    if (num1 == null && num2 == null) { return null!; }
    if (num1 == null || num2 == null)
    {
        return num1 == null ? num2 : num2 == null ? num1 : num2;
    }
    if((num1.Length == 1 && num1[0] == '0') || (num2.Length == 1 && num2[0] == '0')) { return "0"; }


    int[] array1 = GetArrayDigits(num1);
    int[] array2 = GetArrayDigits(num2);

    List<List<int>> collectionMultopliedNumbers = GetListsOfMultopliedNumbers(new List<List<int>>(), array1, array2);
    collectionMultopliedNumbers = CollectionAlignment(collectionMultopliedNumbers);

    List<int> listResult = AddingByCollectionIndeces(collectionMultopliedNumbers);

    var result = string.Concat(listResult);

    return result;
}

int[] GetArrayDigits(string num1)
{
    int[] array = new int[num1.Length];
    for (int i = 0; i < num1.Length; i++)
    {
        array[i] = Convert.ToInt32(char.ConvertFromUtf32(num1[i]));
    }
    return array;
}

List<List<int>> GetListsOfMultopliedNumbers(List<List<int>> collection, int[] array1, int[] array2)
{ 
    int multiplicationResult = 0;
    int remainder = 0;
    int integer = 0;

    int count = 0;

    for (int i = array1.Length - 1; i >= 0; i--)
    {
        List<int> list = new List<int>();
        integer = 0;

        for (int j = array2.Length - 1; j >= 0; j--)
        {
            multiplicationResult = array1[i] * array2[j];
            multiplicationResult += integer;

            remainder = multiplicationResult % 10;
            integer = multiplicationResult / 10;

            list.Add(remainder);
        }
        if (integer > 0) { list.Add(integer); }

        list.Reverse();
        list.AddRange(Enumerable.Repeat(0, count));

        collection.Add(list);
        count++;
    }
    return collection;
}

List<List<int>> CollectionAlignment(List<List<int>> collectionMultopliedNumbers)
{
    int maxLength = collectionMultopliedNumbers.MaxBy(list => list.Count).Count();
    List<List<int>> result = new List<List<int>>();

    foreach (var collection in collectionMultopliedNumbers)
    {
        if(collection.Count < maxLength)
        {
            List<int> list = new List<int>();
            list.AddRange(Enumerable.Repeat(0, maxLength - collection.Count));
            list.AddRange(collection);
            result.Add(list);
        }
        else
        {
            result.Add(collection);
        }
    }
    return result;
}

List<int> AddingByCollectionIndeces(List<List<int>> collectionMultopliedNumbers)
{
    List<int> list = new List<int>(collectionMultopliedNumbers[0]);

    int addition = 0;

    int remainder = 0;
    int integer = 0;

    foreach (var collection in collectionMultopliedNumbers.Skip(1))
    {
        integer = 0;
        for (int i = collection.Count - 1; i >= 0; i--)
        {
            addition = list[i] + collection[i];
            addition += integer;

            remainder = addition % 10;
            integer = addition / 10;

            list[i] = remainder;
        }
    }
    if(integer > 0)
    {
        List<int> newResult = new List<int>();
        newResult.Add(integer);
        newResult.AddRange(list);
        return newResult;
    }


    return list;
}