using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class GameBoard : Form
    {
        public GameBoard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDice_Click(object sender, EventArgs e)
        {
            
            Random rdm = new Random();
            int Dice1 = rdm.Next(1, 7);
            int Dice2 = rdm.Next(1, 7);
            int Move = Dice1 + Dice2;
            
            int XValue = 1164;
            int YValue = 814;

            if (Move == 8)
            {

                XValue = 748;
                YValue = 809;
            }
            Sprit1.Location = new Point( XValue, YValue);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu  mm = new MainMenu();
            mm.ShowDialog();
        }
    }
}
