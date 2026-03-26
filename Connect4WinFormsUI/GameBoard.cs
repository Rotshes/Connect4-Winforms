using System;
using System.Drawing;
using System.Windows.Forms;
using Connect4GameLogic;

namespace Connect4WinFormsUI
{
    public partial class GameBoard : Form
    {
        private readonly GameLogic r_GameHandler;
        private readonly Timer r_ComputerTurnDelay;
        private Button[] m_InputButtons;
        private Button[,] m_JitonButtons;

        public GameBoard(int i_Rows, int i_Cols, bool i_IsComputer, string i_Player1Name, string i_Player2Name)
        {
            InitializeComponent();
            boardCreator(i_Rows, i_Cols);

            r_GameHandler = new GameLogic(i_IsComputer, i_Rows, i_Cols);
            r_GameHandler.JitonDropped += r_GameHandler_JitonDropped;
            r_GameHandler.PlayerChanged += r_GameHandler_PlayerChanged;
            r_GameHandler.ScoresChanged += r_GameHandler_ScoresChanged;
            r_GameHandler.PlayerList[0].Name = string.IsNullOrWhiteSpace(i_Player1Name) ? "Player 1" : i_Player1Name;
            r_GameHandler.PlayerList[1].Name = string.IsNullOrWhiteSpace(i_Player2Name) ? "Player 2" : i_Player2Name;
            
            r_ComputerTurnDelay = new Timer();
            r_ComputerTurnDelay.Interval = 1000;
            r_ComputerTurnDelay.Tick += r_ComputerTurnDelay_Tick;
            // initializing the board labels... (player names and whose turn)
            r_GameHandler_PlayerChanged(r_GameHandler.PlayerList[0]);
            r_GameHandler_ScoresChanged();
        }

        private void boardCreator(int i_Rows, int i_Cols)
        {
            int buttonX = 10;
            int buttonY = 40;

            m_InputButtons = new Button[i_Cols];
            m_JitonButtons = new Button[i_Rows, i_Cols];
            for (int col = 0; col < i_Cols; col++)
            {
                Button inputButton = new Button();
                inputButton.Text = (col + 1).ToString();
                inputButton.Cursor = Cursors.Hand;
                inputButton.FlatStyle = FlatStyle.Popup;
                inputButton.Tag = col;
                inputButton.Size = new Size(45,30);
                inputButton.Click += inputButton_Click;
                inputButton.Location = new Point(buttonX, 6);

                m_InputButtons[col] = inputButton;
                this.Controls.Add(inputButton);

                for (int row = 0; row < i_Rows; row++)
                {
                    Button jitonButton = new Button(); 
                    jitonButton.Size = new Size(45, 40);
                    jitonButton.Text = "";
                    jitonButton.Location = new Point(buttonX, buttonY);

                    m_JitonButtons[row, col] = jitonButton;
                    this.Controls.Add(jitonButton);

                    buttonY += 40;
                }

                buttonX += 55;
                buttonY = 40;
            }

            int formWidth = buttonX;
            int formHeight = (i_Rows + 1) * 40 + panelPlayerLabels.Height;
            this.ClientSize = new Size(formWidth, formHeight);
        }

        private void resetBoard(int i_Rows, int i_Cols)
        {
            for (int col = 0; col < i_Cols; col++)
            {
                for (int row = 0; row < i_Rows; row++)
                {
                    m_JitonButtons[row, col].Text = "";
                }
            }
        }

        private void endRound(bool i_IsForfeit, bool i_IsWin)
        {
            string message;
            string caption;

            if (i_IsForfeit)
            {
                string winnerName = r_GameHandler.CurrentPlayer.Name;
                string forfeiterName = r_GameHandler.CurrentPlayer == r_GameHandler.PlayerList[0] ? r_GameHandler.PlayerList[1].Name : r_GameHandler.PlayerList[0].Name;
                message = $"{forfeiterName} has forfeited the game!, {winnerName} has won!";
                caption = "A forfeit!";
            }
            else if (i_IsWin)
            {
                message = $"{r_GameHandler.CurrentPlayer.Name} has won!";
                caption = "A win!";
            }
            else
            {
                message = "The board is full! The round ends in a tie!";
                caption = "A tie!";
            }

            DialogResult playAgain = MessageBox.Show($"{message}{Environment.NewLine}Another Round?", caption, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (playAgain == DialogResult.Yes)
            { 
                startNewRound();
            }
            else
            { 
                this.Close();
            }
        }

        private void startNewRound()
        {
            int rows = m_JitonButtons.GetLength(0);
            int cols = m_JitonButtons.GetLength(1);

            r_GameHandler.Reset(rows, cols);
            resetBoard(rows, cols);
            for (int col = 0; col < cols; col++) // making sure all input buttons are enabled even if some are
            {
                m_InputButtons[col].Enabled = true;
            }
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            int chosenCol = (int)(sender as Button).Tag;

            r_GameHandler.MakeMove(chosenCol);
            if (r_GameHandler.CheckFullColumn(chosenCol) == true) // disables input button for a full column
            {
                (sender as Button).Enabled = false;
            }

            if (r_GameHandler.WinCondition() == true)
            {
                endRound(false, true);
            }
            else if (r_GameHandler.CheckFullBoard() == true)
            {
                endRound(false, false);
            }
            else if (r_GameHandler.CurrentPlayer.IsComputer == true)
            {
                buttonForfeit.Enabled = false; // so the user won't click input buttons while it's the computers turn
                foreach (Button inputButton in m_InputButtons) 
                {
                    inputButton.Enabled = false;
                }

                r_ComputerTurnDelay.Start();
            }
        }
        private void buttonForfeit_Click(object sender, EventArgs e)
        {
            r_GameHandler.WinConditionForfeit();
            endRound(true, false);
        }

        private void r_ComputerTurnDelay_Tick(object sender, EventArgs e)
        {
            r_ComputerTurnDelay.Stop();

            int chosenCol = r_GameHandler.MakeMoveComputer();
            r_GameHandler.MakeMove(chosenCol);
            if (r_GameHandler.CheckFullColumn(chosenCol))
            {
                m_InputButtons[chosenCol].Enabled = false;
            }

            for (int col = 0; col < m_InputButtons.Length; col++)
            {
                if (!r_GameHandler.CheckFullColumn(col))
                {
                    m_InputButtons[col].Enabled = true;
                }
            }

            if (r_GameHandler.WinCondition() == true)
            {
                endRound(false, true);
            }
            else if (r_GameHandler.CheckFullBoard() == true)
            {
                endRound(false, false);
            }
        }

        private void r_GameHandler_JitonDropped(int i_Row, int i_Col) // updating a column in the UI with the jiton after each play
        {
            m_JitonButtons[i_Row, i_Col].Text = r_GameHandler.JitonsMatrix[i_Row, i_Col].ToString();
        }

        private void r_GameHandler_PlayerChanged(Participant i_Player) // updating the whose turn label in the UI
        {
            labelWhoseTurn.Text = $"{i_Player.Name}'s Turn";
            if (i_Player.IsComputer == false)
            {
                buttonForfeit.Enabled = true;
            }
        }

        private void r_GameHandler_ScoresChanged() // updating the players names/scores labels in the UI
        {
            labelPlayer1Name.Text = $"{r_GameHandler.PlayerList[0].Name}: {r_GameHandler.PlayerList[0].Score}";
            labelPlayer2Name.Text = $"{r_GameHandler.PlayerList[1].Name}: {r_GameHandler.PlayerList[1].Score}";
        }
    }
}
