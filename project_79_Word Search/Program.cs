
char[][] board1 = new char[3][]
{
    new char[4] { 'A', 'B', 'C', 'E' },
    new char[4] { 'S', 'F', 'C', 'S' },
    new char[4] { 'A', 'D', 'E', 'E' }
};
string word1 = "ABCCED";

char[][] board2 = new char[3][]
{
    new char[4] {'A', 'B', 'C', 'E'},
    new char[4] {'S', 'F', 'C', 'S'},
    new char[4] { 'A', 'D', 'E', 'E'}
};
string word2 = "SEE";

char[][] board3 = new char[3][]
{
    new char[4] {'A', 'B', 'C', 'E'},
    new char[4] {'S', 'F', 'C', 'S'},
    new char[4] {'A', 'D', 'E', 'E'}
};
string word3 = "ABCB";


Console.WriteLine(Exist(board1, word1));
Console.WriteLine(Exist(board2, word2));
Console.WriteLine(Exist(board3, word3));


Console.ReadLine();





bool Exist(char[][] board, string word)
{
    List<char> list = new List<char>();
    List<(int, int)> start = FindTheFirstLitter(board, word[0], list);
    
    if(start.Count > 0) { list.Add(word[0]); }
    else { return false; }

    bool result = false;

    foreach((int, int) c in start)
    {
        result = WordSerach(board, 1, c.Item1, c.Item2, list, word, result);

        if(result == true) break;
    }


    return result;
}


bool WordSerach(char[][] board,int index, int y, int x, List<char> litters, string word, bool result)
{
    if(litters.Count == word.Length)
    {
        return true;
    }

    if(x < 0 || x > board[0].Length - 1 || y < 0 || y > board.Length - 1) {  return false; }

    if (x - 1 >= 0 && word[index] == board[y][x - 1])
    {
        litters.Add(word[index]);
        result = WordSerach(board, index + 1, y, x - 1, litters, word, result);

        if (result) { return result; }

        litters.RemoveAt(litters.Count - 1);
    }
    if (y - 1 >= 0 && word[index] == board[y - 1][x])
    {
        litters.Add(word[index]);
        result = WordSerach(board, index + 1, y - 1, x, litters, word, result);

        if (result) { return result; }

        litters.RemoveAt(litters.Count - 1);
    }
    if (x + 1 < board[0].Length && word[index] == board[y][x + 1])
    {
        litters.Add(word[index]);
        result = WordSerach(board, index + 1, y, x + 1, litters, word, result);

        if (result) { return result; }

        litters.RemoveAt(litters.Count - 1);
    }
    if (y + 1 < board.Length && word[index] == board[y + 1][x])
    {
        litters.Add(word[index]);
        result = WordSerach(board, index + 1, y + 1, x, litters, word, result);

        if (result) { return result; }

        litters.RemoveAt(litters.Count - 1);
    }

    return result;
}

List<(int,int)> FindTheFirstLitter(char[][] board, char litter, List<char> result)
{
    List<(int,int)> list = new List<(int,int)> ();

    for (int i = 0; i < board.Length; i++)
    {
        for (int j = 0; j < board[i].Length; j++)
        {
            if (board[i][j] == litter)
            {
                list.Add((i,j));
            }
        }
    }
    return list;
}