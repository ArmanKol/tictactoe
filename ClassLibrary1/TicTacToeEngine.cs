using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class TicTacToeEngine
    {

        public Dictionary<int, CellStatus> dict = new Dictionary<int, CellStatus>();

        public string board = "-------------\n" +
                            "| 0 | 1 | 2 |\n" +
                            "-------------\n" +
                            "| 3 | 4 | 5 |\n" +
                            "-------------\n" +
                            "| 6 | 7 | 8 |\n" +
                            "-------------\n";

        public TicTacToeEngine()
        {
            Status = GameStatus.PlayerOPlays;
        }

        public enum GameStatus
        {
            PlayerOPlays, PlayerXPlays, Equal, PlayerOWins, PlayerXWins
        }

        public enum CellStatus
        {
            PlayerO, PlayerX, Empty
        }

        public GameStatus Status { get; private set; }
        public CellStatus cellstatus { get; set; }

        public string Board(int x)
        {
            string boardX = board;
            if (dict.ContainsKey(x))
            {
                if(dict[x] == CellStatus.PlayerX)
                {
                    boardX = boardX.Replace(Convert.ToString(x), "X");
                }
                if(dict[x] == CellStatus.PlayerO)
                {
                    boardX = boardX.Replace(Convert.ToString(x), "O");
                }
            }
            return boardX;
        }

        public bool ChooseCell(int x)
        {

            if(Status == GameStatus.PlayerOPlays && dict.ContainsKey(x))
            {
                return true;
            }
            else if(Status == GameStatus.PlayerXPlays && dict.ContainsKey(x))
            {
                return true;
            }

            return false;
        }

        public string DrawCell(CellStatus x)
        {   
            if(dict.ContainsValue(x) && Status == GameStatus.PlayerOPlays)
            {
                return "O";
            }
            if(dict.ContainsValue(x) && Status == GameStatus.PlayerXPlays)
            {
                return "X";
            }
            return "";
        }

        public void PlayerChange(bool result)
        {
            if(result)
            {
                if (Status == GameStatus.PlayerOPlays)
                {
                    Status = GameStatus.PlayerXPlays;
                    cellstatus = CellStatus.PlayerX;
                }
                else
                {
                    Status = GameStatus.PlayerOPlays;
                    cellstatus = CellStatus.PlayerO;
                }
            }
        }

        public void Checkwin()
        {
            CellStatus player = CellStatus.Empty;

            if (Status == GameStatus.PlayerOPlays)
            {
                player = CellStatus.PlayerO;
            }
            if(Status == GameStatus.PlayerXPlays)
            {
                player = CellStatus.PlayerX;
            }
   
            for(int i=0; i<9; i++)
            {
                if((dict.ContainsKey(i) && dict.ContainsKey(i + 1)) && (dict.ContainsKey(i + 1) && dict.ContainsKey(i + 2)) && (dict[i] == player && dict[i + 1] == player && dict[i + 2] == player))
                {
                    MessageBox.Show("Hoera speler " + Status + " heeft gewonnen");
                    if (Status == GameStatus.PlayerOPlays)
                    {
                        Status = GameStatus.PlayerOWins;
                    }
                    else
                    {
                        Status = GameStatus.PlayerXWins;
                    }
                    
                }

                if ((dict.ContainsKey(i) && dict.ContainsKey(i + 3)) && (dict.ContainsKey(i + 3) && dict.ContainsKey(i + 6)) && ((dict[i] == player && dict[i + 3] == player && dict[i + 6] == player)))
                {
                    MessageBox.Show("Hoera speler " + Status + " heeft gewonnen");
                    if (Status == GameStatus.PlayerOPlays)
                    {
                        Status = GameStatus.PlayerOWins;
                    }
                    else
                    {
                        Status = GameStatus.PlayerXWins;
                    }
                    
                }
                if(dict.Count() == 9)
                {
                    MessageBox.Show("Jullie hebben gelijk gespeeld");
                    Status = GameStatus.Equal;
                    
                }
            }
        }

        public void Reset()
        {
            Status = GameStatus.PlayerXPlays;
            dict.Clear();
        }
    }
}
