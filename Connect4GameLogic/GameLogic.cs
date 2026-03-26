using System;

namespace Connect4GameLogic
{
    public class GameLogic
    {
        private readonly Random r_Randomizer = new Random();
        private readonly Participant[] r_PlayerList = new Participant[2];
        private char[,] m_JitonsMatrix;
        private Participant m_CurrentPlayer;
        private Coordinates m_LastPlayed;

        public event Action<int, int> JitonDropped;
        public event Action<Participant> PlayerChanged;
        public event Action ScoresChanged;

        public GameLogic(bool i_VsComp, int i_Rows, int i_Cols)
        {
            r_PlayerList[0] = new Participant("Player1", 'X',false);
            if (i_VsComp == true)
            {
                r_PlayerList[1] = new Participant("Computer",'O',true);
            }
            else
            {
                r_PlayerList[1] = new Participant("Player2",'O',false);
            }

            m_CurrentPlayer = r_PlayerList[0];
            m_JitonsMatrix = new char[i_Rows, i_Cols];
        }

        public Participant[] PlayerList
        {
            get
            {
                return r_PlayerList;
            }
        }

        public char[,] JitonsMatrix
        {
            get
            {
                return m_JitonsMatrix;
            }
        }

        public Participant CurrentPlayer
        {
            get
            {
                return m_CurrentPlayer;
            }
        }

        public void Reset(int i_Rows, int i_Cols)
        {
            m_JitonsMatrix = new char[i_Rows, i_Cols];
            m_CurrentPlayer = r_PlayerList[0];
            OnPlayerChanged(m_CurrentPlayer);
        }

        public void MakeMove(int i_Column)
        {
            for (int row = m_JitonsMatrix.GetLength(0) - 1; row >= 0; row--)
            {
                if (m_JitonsMatrix[row, i_Column] == '\0')
                {
                    m_JitonsMatrix[row, i_Column] = m_CurrentPlayer.Jiton;
                    OnJitonDropped(row, i_Column);
                    m_LastPlayed = new Coordinates(row, i_Column);
                    break;
                }
            }
        }

        public int MakeMoveComputer()
        {
            bool validColumn = false;
            int rndCol = 0;

            while (validColumn == false)
            {
                rndCol = r_Randomizer.Next(m_JitonsMatrix.GetLength(1));
                if (m_JitonsMatrix[0, rndCol] == '\0')
                {
                    validColumn = true;
                }
            }

            return rndCol;
        }

        public bool CheckFullColumn(int i_Col)
        {
            return JitonsMatrix[0, i_Col] != '\0';
        }

        public bool CheckFullBoard()
        {
            bool isFull = true;
            int maxColumn = JitonsMatrix.GetLength(1);
            for (int column = 0; column < maxColumn; column++)
            {
                if (JitonsMatrix[0,column] == '\0')
                {
                    isFull = false;
                    break;
                }
            }

            return isFull;
        }

        public bool WinCondition() // Checking all directions from the current move for a series of 4 of the same Jitons.
        {
            bool isWin = (checkJitonSeries(1, 0) || checkJitonSeries(0, 1) || checkJitonSeries(1, 1) || checkJitonSeries(-1, 1)); // Vertical,Horizontal,Diagonal,Anti diagonal
            if (isWin == false)
            {
                changePlayer(ref m_CurrentPlayer);
            }
            else
            {
                m_CurrentPlayer.IncreaseScore();
                OnScoresChanged();
            }

            return isWin; 
        }

        public void WinConditionForfeit()
        {
            changePlayer(ref m_CurrentPlayer);
            m_CurrentPlayer.IncreaseScore();
            OnScoresChanged();
        }

        private bool checkJitonSeries(int i_RowDelta, int i_ColDelta)
        {
            bool win = false;
            int counter = countDirection(i_RowDelta, i_ColDelta) + countDirection(-i_RowDelta, -i_ColDelta) + 1;
            if (counter >= 4)
            {
                win = true;
            }

            return win;
        }

        private int countDirection(int i_RowDelta, int i_ColDelta)
        {

            int currRow = m_LastPlayed.Row + i_RowDelta;
            int maxRow = JitonsMatrix.GetLength(0);
            int currCol = m_LastPlayed.Column + i_ColDelta;
            int maxCol = JitonsMatrix.GetLength(1);
            int counter = 0;
            bool continueScan = true;
            while (continueScan == true)
            {
                if ((currRow >= 0 && currRow < maxRow) && (currCol >= 0 && currCol < maxCol))
                {
                    if (JitonsMatrix[currRow,currCol] == m_CurrentPlayer.Jiton)
                    {
                        counter++;
                    }
                    else
                    {
                        continueScan = false;
                    }
                }
                else
                {
                    continueScan = false;
                }

                currRow += i_RowDelta;
                currCol += i_ColDelta;
            }

            return counter;
        }

        private void changePlayer(ref Participant io_CurrentPlayer)
        {
            io_CurrentPlayer = (io_CurrentPlayer == r_PlayerList[0]) ? r_PlayerList[1] : r_PlayerList[0];
            OnPlayerChanged(io_CurrentPlayer);
        }

        protected virtual void OnJitonDropped(int i_Row, int i_Col)
        {
            JitonDropped?.Invoke(i_Row, i_Col);
        }

        protected virtual void OnPlayerChanged(Participant i_Player)
        {
            PlayerChanged?.Invoke(i_Player);
        }

        protected virtual void OnScoresChanged()
        {
            ScoresChanged?.Invoke();
        }
    }
}
