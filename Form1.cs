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
        bool turn = true; //true = X turn; false = Y turn
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
        }

        private void WinDeclare()
        {
            bool winner = false;

            //for horizontal win
            if ((Tab1.Text == Tab2.Text) && (Tab2.Text == Tab3.Text) && (!Tab1.Enabled))
                winner = true;
            if ((Tab4.Text == Tab5.Text) && (Tab5.Text == Tab6.Text) && (!Tab4.Enabled))
                winner = true;
            if ((Tab7.Text == Tab8.Text) && (Tab8.Text == Tab9.Text) && (!Tab7.Enabled))
                winner = true;

            if (winner)
            {
                String win = "";
                if (turn)
                    win = "0";
                else
                    win = "X";

                MessageBox.Show(win + "Congratulations", "Lodicakes");
            }
                
        }
    }
}
