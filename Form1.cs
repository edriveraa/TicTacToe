using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void button_click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (turn)
                bt.Text = "X";
            else
                bt.Text = "O";

            turn = !turn;
            bt.Enabled = false;
            turn_count++;

            WinDeclare();
        }
        private void WinDeclare()
        {
            bool winner = false;
            //verticals
            if ((Tab1.Text == Tab2.Text) && (Tab2.Text == Tab3.Text) && (!Tab1.Enabled))
                winner = true;
            else if ((Tab4.Text == Tab5.Text) && (Tab5.Text == Tab6.Text) && (!Tab4.Enabled))
                winner = true;
            else if ((Tab7.Text == Tab8.Text) && (Tab8.Text == Tab9.Text) && (!Tab7.Enabled))
                winner = true;

            //verticals
            else if ((Tab1.Text == Tab4.Text) && (Tab4.Text == Tab7.Text) && (!Tab1.Enabled))
                winner = true;
            else if ((Tab2.Text == Tab5.Text) && (Tab5.Text == Tab8.Text) && (!Tab2.Enabled))
                winner = true;
            else if ((Tab3.Text == Tab6.Text) && (Tab6.Text == Tab9.Text) && (!Tab3.Enabled))
                winner = true;

            //diagonals 
            else if ((Tab1.Text == Tab5.Text) && (Tab5.Text == Tab9.Text) && (!Tab1.Enabled))
                winner = true;
            else if ((Tab3.Text == Tab5.Text) && (Tab5.Text == Tab7.Text) && (!Tab3.Enabled))
                winner = true;

            if (winner)
            {
                String win = "";
                if (turn)
                    win = "0";
                else
                    win = "X";

                MessageBox.Show(win + ", Congratulations" + " Lodicakes!", "Winner has Ascended");
            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("It is a draw!", "Draw!");
            }
        }
    }
}