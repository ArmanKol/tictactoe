using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TicTacToeEngine t = new TicTacToeEngine();
        bool result;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            t.dict.Add(btn.TabIndex, t.cellstatus);
            result = t.ChooseCell(btn.TabIndex);
            btn.Text = t.DrawCell(t.cellstatus);
            Console.WriteLine(t.Board(btn.TabIndex));
            t.Checkwin();

            if(t.Status == TicTacToeEngine.GameStatus.PlayerOWins || t.Status == TicTacToeEngine.GameStatus.PlayerXWins)
            {
                t.Reset();
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

            }

            t.PlayerChange(result);

        }
    }
}
