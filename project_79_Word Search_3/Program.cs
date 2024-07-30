

using System.Collections;
using System.Collections.Generic;

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
    // optimization
    Dictionary<char, int> boardLetters = GetBoardLetterCount(board);
    Dictionary<char, int> wordLetters = GetWordLetterCount(word);

    // compare letter count, unique chars, etc. 
    if (!LetterCheck(boardLetters, wordLetters))
        return false;

    // reverse word if last letter occurs less than first
    word = GetOptimizedWord(word, wordLetters);

    // optimization end
    HashSet<(int row, int col)> visited = new HashSet<(int, int)>();

    // run dfs 
    for (int row = 0; row < board.Length; row++)
    {
        for (int col = 0; col < board[row].Length; col++)
        {
            if (WordSerach(board, visited, word, row, col, 0))
                return true;
        }
    }
    return false;
}

bool LetterCheck(Dictionary<char, int> boardLetters, Dictionary<char, int> wordLetters)
{
    // return false if board does not have same amount of unique chars as word
    if (boardLetters.Keys.Count < wordLetters.Keys.Count)
        return false;

    // otherwise, go through each unique letter in word and check whether board possibly has it
    foreach (var key in wordLetters.Keys)
    {
        // board does not have letter
        if (!boardLetters.ContainsKey(key))
            return false;

        // board letter count is less than word letter count
        if (boardLetters[key] < wordLetters[key])
            return false;
    }
    return true;
}
string GetOptimizedWord(string word, Dictionary<char, int> wordLetters)
{
    if (wordLetters[word[0]] > wordLetters[word[word.Length - 1]])
    {
        return Reverse(word);
    }
    return word;
}
string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}
Dictionary<char, int> GetWordLetterCount(string word)
{
    Dictionary<char, int> letterCnt = new Dictionary<char, int>();
    foreach (char c in word)
    {
        if (letterCnt.ContainsKey(c))
        {
            letterCnt[c]++;
        }
        else
        {
            letterCnt[c] = 1;
        }
    }
    return letterCnt;
}
Dictionary<char, int> GetBoardLetterCount(char[][] board)
{
    Dictionary<char, int> letterCnt = new Dictionary<char, int>();
    for (int row = 0; row < board.Length; row++)
    {
        for (int col = 0; col < board[row].Length; col++)
        {
            char c = board[row][col];
            if (letterCnt.ContainsKey(c))
            {
                letterCnt[c]++;
            }
            else
            {
                letterCnt[c] = 1;
            }
        }
    }
    return letterCnt;
}

// call stack can be at most length of word
// O(n * m * dfs) - dimensions of matrix * dfs algo
// dfs algo - call stack is at most the size of the word
// we are calling 4 times, 4 ^ n where n is the length of the word

bool WordSerach(char[][] board, HashSet<(int, int)> visited, string word, int row, int col, int i)
{
    // base case, we matched all characters
    if (i == word.Length)
        return true;

    if (
        (row < 0 || row >= board.Length) ||
        (col < 0 || col >= board[row].Length) ||
        visited.Contains((row, col)) ||
        board[row][col] != word[i]
    )
        return false;

    visited.Add((row, col));
    var result = (
        WordSerach(board, visited, word, row + 1, col, i + 1) ||
        WordSerach(board, visited, word, row - 1, col, i + 1) ||
        WordSerach(board, visited, word, row, col + 1, i + 1) ||
        WordSerach(board, visited, word, row, col - 1, i + 1)
    );
    visited.Remove((row, col));
    return result;
}