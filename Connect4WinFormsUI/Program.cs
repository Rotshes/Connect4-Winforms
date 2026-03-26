using System.Windows.Forms;

namespace Connect4WinFormsUI
{
    internal class Program
    {
        public static void Main()
        {
            GameSettings settings = new GameSettings();
            if(settings.ShowDialog() == DialogResult.OK)
            {
                GameBoard gameBoard = new GameBoard(settings.Rows, settings.Columns, settings.IsComputer, settings.Player1Name, settings.Player2Name);
                gameBoard.ShowDialog();
            }
        }
    }
}
