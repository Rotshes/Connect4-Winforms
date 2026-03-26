namespace Connect4GameLogic
{
    public class Participant
    {
        private string m_PlayerName;
        private readonly char r_Jiton;
        private readonly bool r_IsComputer;
        private int m_Score = 0;

        public Participant(string i_PlayerName, char i_Jiton, bool i_IsComp)
        {
            m_PlayerName = i_PlayerName;
            r_Jiton = i_Jiton;
            r_IsComputer = i_IsComp;
        }

        public string Name
        {
            get
            {
                return m_PlayerName;
            }
            set
            {
                m_PlayerName = value;
            }
        }

        public char Jiton
        {
            get 
            { 
                return r_Jiton; 
            }
        }

        public int Score
        {
            get
            { 
                return m_Score; 
            }
        }

        public bool IsComputer
        {
            get
            {
                return r_IsComputer;
            }
        }

        public void IncreaseScore()
        {
            m_Score++;
        }
    }
}
