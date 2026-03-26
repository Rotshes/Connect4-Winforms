using System;
using System.Windows.Forms;

namespace Connect4WinFormsUI
{
    public partial class GameSettings : Form
    {
        public GameSettings()
        {
            InitializeComponent();
        }

        public string Player1Name
        {
            get
            {
                return textBoxPlayer1.Text;
            }
        }

        public string Player2Name
        {
            get
            {
                return textBoxPlayer2.Text;
            }
        }

        public bool IsComputer
        {
            get
            {
                return !checkBoxPlayer2.Checked;
            }
        }

        public int Rows
        {
            get
            {
                return (int)numericUpDownRows.Value;
            }
        }

        public int Columns
        {
            get
            {
                return (int)numericUpDownCols.Value;
            }
        }

        private void checkBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxPlayer2.Checked == true)
            {
                textBoxPlayer2.Text = "";
                textBoxPlayer2.Enabled = true;
            }
            else
            {
                textBoxPlayer2.Text = "Computer";
                textBoxPlayer2.Enabled = false;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
