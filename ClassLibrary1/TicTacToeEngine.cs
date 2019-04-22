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

        public TicTacToeEngine()
        {
            Status = 0;
        }

        public ArrayList list = new ArrayList();

        public Button Button { get; set; }

        public enum GameStatus
        {
            PlayerOPlays, PlayerXPlays, Equal, PlayerOWins, PlayerXWins
        }

        public GameStatus Status { get; private set; }

        public bool ChooseCell(int x)
        {
            if(Button.TabIndex == x && Button.Text.Equals("") && Status == GameStatus.PlayerOPlays)
            {
                Button.Text = "O";
                return true;
            }
            else if(Button.TabIndex == x && Button.Text.Equals("") && Status == GameStatus.PlayerXPlays)
            {
                Button.Text = "X";
                return true;
            }

            return false;
        }

        public void PlayerChange(bool result)
        {
            if(result)
            {
                if (Status == GameStatus.PlayerOPlays)
                {
                    Status = GameStatus.PlayerXPlays;
                }
                else
                {
                    Status = GameStatus.PlayerOPlays;
                }
            }
        }

        public void Checkwin()
        {
            string player = "";
            Button button1 = (Button)list[0];
            Button button2 = (Button)list[8];
            Button button3 = (Button)list[7];
            Button button4 = (Button)list[3];
            Button button5 = (Button)list[5];
            Button button6 = (Button)list[4];
            Button button7 = (Button)list[6];
            Button button8 = (Button)list[2];
            Button button9 = (Button)list[1];

            if (Status == GameStatus.PlayerOPlays)
            {
                player = "O";
            }
            if(Status == GameStatus.PlayerXPlays)
            {
                player = "X";
            }

            if ((button1.Text.Equals(player) && button2.Text.Equals(player)) && (button2.Text.Equals(player) && button3.Text.Equals(player)))
            {
                MessageBox.Show("Hoera speler " + Status + " heeft gewonnen");
                Reset();
            }

            if ((button4.Text.Equals(player) && button5.Text.Equals(player)) && (button5.Text.Equals(player) && button6.Text.Equals(player)))
            {
                MessageBox.Show("Hoera speler " + Status + " heeft gewonnen");
                Reset();
            }

            if ((button7.Text.Equals(player) && button8.Text.Equals(player)) && (button8.Text.Equals(player) && button9.Text.Equals(player)))
            {
                MessageBox.Show("Hoera speler " + Status + " heeft gewonnen");
                Reset();
            }

            if ((button1.Text.Equals(player) && button4.Text.Equals(player)) && (button4.Text.Equals(player) && button7.Text.Equals(player)))
            {
                MessageBox.Show("Hoera speler " + Status + " heeft gewonnen");
                Reset();
            }

            if ((button2.Text.Equals(player) && button5.Text.Equals(player)) && (button5.Text.Equals(player) && button8.Text.Equals(player)))
            {
                MessageBox.Show("Hoera speler " + Status + " heeft gewonnen");
                Reset();
            }

            if ((button3.Text.Equals(player) && button6.Text.Equals(player)) && (button6.Text.Equals(player) && button9.Text.Equals(player)))
            {
                MessageBox.Show("Hoera speler " + Status + " heeft gewonnen");
                Reset();
            }

            if ((button1.Text.Equals(player) && button5.Text.Equals(player)) && (button5.Text.Equals(player) && button9.Text.Equals(player)))
            {
                MessageBox.Show("Hoera speler " + Status + " heeft gewonnen");
                Reset();
            }

            if ((button3.Text.Equals(player) && button5.Text.Equals(player)) && (button5.Text.Equals(player) && button7.Text.Equals(player)))
            {
                MessageBox.Show("Hoera speler " + Status + " heeft gewonnen");
                Reset();
            }

            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("Jullie hebben " + GameStatus.Equal + " gespeeld");
                Reset();
            }

        }

        public void Reset()
        {
           foreach(Button btn in list)
            {
                btn.Text = "";
                Status = GameStatus.PlayerOPlays;
            }
        }
    }
}
