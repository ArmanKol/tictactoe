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

            t.list.Add(button1);
            t.list.Add(button2);
            t.list.Add(button3);
            t.list.Add(button4);
            t.list.Add(button5);
            t.list.Add(button6);
            t.list.Add(button7);
            t.list.Add(button8);
            t.list.Add(button9);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            t.Button = btn;

            result = t.ChooseCell(btn.TabIndex);
            t.Checkwin();
            t.PlayerChange(result);





        }
    }
}
