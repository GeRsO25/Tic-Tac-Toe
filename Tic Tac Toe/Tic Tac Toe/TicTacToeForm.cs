using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class TicTacToeForm : Form
    {
        bool isWinner = false; // gamarjvebulis gamovlena
        bool isTic = false; // visi jeria True - X , False - 0
        int turnCounter = 0;

        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Am Tamashis Shemqmnelia Saba Gersamia");
        }

        private void c3_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isTic)
                button.Text = "X";
            else
                button.Text = "O";

            turnCounter++;
            isTic = !isTic;
            button.Enabled = false;

            CheckWinner();
        }

        private void CheckWinner()
        {
            // Horizontal Checker 
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
                isWinner = true;
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
                isWinner = true;
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
                isWinner = true;

            // Vertical Checker 
            if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
                isWinner = true;
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
                isWinner = true;
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
                isWinner = true;

            // Diagonal Checker
            if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
                isWinner = true;
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!c1.Enabled))
                isWinner = true;


            // Winner 

            if (isWinner)
            {
                string winner = "";

                if (isTic)
                    winner = "O";
                else 
                    winner = "X";

                MessageBox.Show($"გამარჯვებულია {winner} !!!");

                DisableAfterGame();
                
            }

            // Draw

            if (turnCounter == 9 && !isWinner)
                MessageBox.Show("თამაში მორჩა ფრედ !!!");

            if (isWinner || turnCounter == 9)
            {
                AskForRestart();
            }

        }

        private void AskForRestart()
        {
            DialogResult = MessageBox.Show("გსურთ თამაშის თავიდან დაწყება ?","თამაში დასრულდა", MessageBoxButtons.OKCancel);
            if (DialogResult == DialogResult.OK)
            {
                RestartGame();
            }
        }

        private void RestartGame()
        {
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Enabled = true;
                    button.Text = "";
                }
            }
            isWinner = false;
            isTic = false;
            turnCounter = 0;
        }

        private void DisableAfterGame ()
        {
            foreach (Control control in Controls)
            {
                control.Enabled = false;
            }
        }

    }
}
