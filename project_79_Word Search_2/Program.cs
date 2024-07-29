

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


//Console.WriteLine(Exist(board1, word1));
Console.WriteLine(Exist(board2, word2));
Console.WriteLine(Exist(board3, word3));


Console.ReadLine();


//Ошибка алгоритма, в добавлении элемента с массива который уже используетися.
//Добавить ограничения в ввиде массива с указателями


bool Exist(char[][] board, string word)
{
    List<char> list = new List<char>();
    List<(int, int)> start = FindTheFirstLitter(board, word[0], list);
    bool[,] block = new bool[board.Length, board[0].Length];

    bool result = false;

    int index = 0;
    foreach ((int, int) c in start)
    {
        list.Add(word[0]);
        block[start[index].Item1, start[index].Item2] = true;

        result = WordSerach(board, 1, c.Item1, c.Item2, list, word, result, block);

        if (result == true) break;

        list.RemoveAt(list.Count - 1);
        block[start[index].Item1, start[index].Item2] = false;

        index++;
    }


    return result;
}


bool WordSerach(char[][] board, int index, int y, int x, List<char> litters, string word, bool result, bool[,] block)
{
    if (litters.Count == word.Length)
    {
        return true;
    }

    if (x < 0 || x > board[0].Length - 1 || y < 0 || y > board.Length - 1) { return false; }

    if ((litters.Count == 1 ? block[y, x] == true : block[y, x] == false) && x - 1 >= 0 && word[index] == board[y][x - 1])
    {
        litters.Add(word[index]);
        block[y, x] = true;
        result = WordSerach(board, index + 1, y, x - 1, litters, word, result, block);

        if (result) { return result; }

        block[y, x] = false;
        litters.RemoveAt(litters.Count - 1);
    }
    if ((litters.Count == 1 ? block[y, x] == true : block[y, x] == false) && y - 1 >= 0 && word[index] == board[y - 1][x])
    {
        litters.Add(word[index]);
        block[y, x] = true;

        result = WordSerach(board, index + 1, y - 1, x, litters, word, result, block);

        if (result) { return result; }

        block[y, x] = false;
        litters.RemoveAt(litters.Count - 1);
    }
    if ((litters.Count == 1 ? block[y, x] == true : block[y, x] == false) && x + 1 < board[0].Length && word[index] == board[y][x + 1])
    {
        litters.Add(word[index]);
        block[y, x] = true;

        result = WordSerach(board, index + 1, y, x + 1, litters, word, result, block);

        if (result) { return result; }

        block[y, x] = false;
        litters.RemoveAt(litters.Count - 1);
    }
    if ((litters.Count == 1 ? block[y, x] == true : block[y, x] == false) && y + 1 < board.Length && word[index] == board[y + 1][x])
    {
        litters.Add(word[index]);
        block[y, x] = true;

        result = WordSerach(board, index + 1, y + 1, x, litters, word, result, block);

        if (result) { return result; }

        block[y, x] = false;
        litters.RemoveAt(litters.Count - 1);
    }
    return result;
}



List<(int, int)> FindTheFirstLitter(char[][] board, char litter, List<char> result)
{
    List<(int, int)> list = new List<(int, int)>();

    for (int i = 0; i < board.Length; i++)
    {
        for (int j = 0; j < board[i].Length; j++)
        {
            if (board[i][j] == litter)
            {
                list.Add((i, j));
            }
        }
    }
    return list;
}