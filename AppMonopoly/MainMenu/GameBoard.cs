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

        private int[] Ploc = new int[4];
        private int PlayerTurn = 0;
        private int[] xcoordinate = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int[] ycoordinate = new int[39];



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

            //Run the dice
            int Dice1 = rdm.Next(1, 7);
            int Dice2 = rdm.Next(1, 7);
            int Move = Dice1 + Dice2;
          
            //show the dice
            MessageBox.Show("Dice result:" + Move.ToString() + " for " + "player " + PlayerTurn +1);

            //calcualte the location
            Ploc[PlayerTurn] = Ploc[PlayerTurn] + Move;

            //make sure not to go beyond the board
            if (Ploc[PlayerTurn] > 39) { Ploc[PlayerTurn] = Ploc[PlayerTurn] - 40; }

            //move the player token
            MessageBox.Show(Ploc[PlayerTurn].ToString() + " for " + "player " + PlayerTurn+1);

            //next player turn
            PlayerTurn++; if (PlayerTurn > 3) { PlayerTurn = 0; }
           
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

        private void TestCaseButton_Click(object sender, EventArgs e)
        {


            string[] playernames = new string[4];
            int[] playerMoney = { 1500, 1500, 1500, 1500 };
            playernames = PlayerInfo.getplayernames();


            string[] playersprits = new string[4];
            playersprits = PlayerInfo.getPlayerSprit();

            string[] playermoney = new string[4];
            playermoney = PlayerInfo.getPlayerMoney();
            for (int i = 0; i < 4; i++)
            {

                MessageBox.Show(" Your Name is " + playernames[i] + " You Have a " + playersprits[i] + " Sprite." + " You Blance is $" + playermoney[i]);
            }


                
        }


    }
}
