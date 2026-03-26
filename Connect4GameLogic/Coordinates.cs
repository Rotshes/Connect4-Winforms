namespace Connect4GameLogic
{
    public readonly struct Coordinates
    {
        private readonly int r_Row;
        private readonly int r_Column;

        public Coordinates(int i_Row, int i_Column)
        {
            r_Row = i_Row;
            r_Column = i_Column;
        }

        public int Row 
        {
            get
            {
                return r_Row;
            } 
        }

        public int Column
        {
            get
            {
                return r_Column;
            }
        }
            
    }
}
