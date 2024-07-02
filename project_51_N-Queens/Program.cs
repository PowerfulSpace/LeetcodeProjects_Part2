
int n1 = 4;

SolveNQueens(n1);

Console.ReadLine();


// Решить вопрос, с бесконечным циклом


IList<IList<string>> SolveNQueens(int n)
{
    var result = new List<IList<string>>();

    char[,] CheasBoard = new char[n,n];

    int countQueens = 0;

    int x = 0;
    int y = 0;

    int left = 0;
    int rigth = 0;

  
    AccommodationQueens(CheasBoard,y,x,left,rigth, countQueens);

    return result;
}

void AccommodationQueens(char[,] cheasBoard, int y, int x, int left, int rigth, int countQueens)
{
    if(y > cheasBoard.GetLength(0) || x > cheasBoard.GetLength(0)) { return; }
    if (countQueens == cheasBoard.GetLength(0)) { return; }

    bool isAdd = false;


    if (y < cheasBoard.GetLength(1))
    {
        for (int j = x; j < cheasBoard.GetLength(0); j++)
        {
            if (cheasBoard[y, j] == '.') { continue; };

            if (cheasBoard[y, j] != '.' && cheasBoard[y, j] != 'Q')
            {
                cheasBoard[y, j] = 'Q';               
                x = j;

                isAdd = true;
                countQueens++;

                break;
            }
        }

        if (isAdd)
        {
            left = x - y;
            rigth = x + y;

            LokingCells(cheasBoard, y, x, left, rigth);

            Print(cheasBoard);


            AccommodationQueens(cheasBoard, y + 1, 0, left, rigth, countQueens);
        }
        else
        {
            for (int i = 0; i < cheasBoard.GetLength(0); i++)
            {
                if(cheasBoard[y - 1, i] == 'Q')
                {
                    cheasBoard[y - 1, i] = '.';
                    break;
                }
            }
            
            return;
        }

        if (cheasBoard[y, x] == '\0')
        {
            AccommodationQueens(cheasBoard, y, x + 1, left, rigth, countQueens);
        }
        


    }

    return;
}

void LokingCells(char[,] CheasBoard, int y, int x, int left, int rigth)
{
    
    for (int j = 0; j < CheasBoard.GetLength(0); j++, left++, rigth--)
    {
        if (CheasBoard[y, j] != 'Q') { CheasBoard[y, j] = '.'; }
        if (CheasBoard[j, x] != 'Q') { CheasBoard[j, x] = '.'; }

        if (left >= 0 && left <= CheasBoard.GetLength(1) - 1)
        {
            if (CheasBoard[y, left] != 'Q' && CheasBoard[j, left] != 'Q') { CheasBoard[j, left] = '.'; }
        }

        if (rigth <= CheasBoard.GetLength(1) - 1 && rigth >= 0)
        {
            if (CheasBoard[y, rigth] != 'Q' && CheasBoard[j, rigth] != 'Q') { CheasBoard[j, rigth] = '.'; }
        }
    }
}


void Print(char[,] CheasBoard)
{
    for (int i = 0; i < CheasBoard.GetLength(0); i++)
    {
        for (int j = 0; j < CheasBoard.GetLength(1); j++)
        {
            Console.Write(CheasBoard[i,j] + " ");
        }
        Console.WriteLine();
    }
}