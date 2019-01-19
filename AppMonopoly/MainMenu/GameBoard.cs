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

        private int Move = 0;
        private int stopMove = 0;


        private int[] xcoordinate = { 1044, 928, 870, 812, 754, 694, 636, 578, 520, 462, 404, 404, 404, 404, 404, 404, 404, 404, 404, 404, 404, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int[] ycoordinate = { 766, 766, 766, 766, 766, 766, 766, 766, 766, 766, 766, }


        string[] playermoney = PlayerInfo.getPlayerMoney();
        string[] playersprits = PlayerInfo.getPlayerSprit();
        string[] playernames = PlayerInfo.getplayernames();

        public GameBoard()
        {
            InitializeComponent();
            Display();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDice_Click(object sender, EventArgs e)
        {

            Dice();
            Display();


        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
        }

        private void TestCaseButton_Click(object sender, EventArgs e)
        {
            
            if(stopMove == 0)
            {
                PlayerMove();
                MoveSprte();
                Display();
                stopMove = 1;
            }
            else if(Move == 0)
            {
                MessageBox.Show("RollDice ");
            }
            else
            {
                MessageBox.Show("Cheater Can not Move more than one time! ");
                stopMove = 0;
                Move = 0;
                PlayerTurn++; if (PlayerTurn > 3) { PlayerTurn = 0; }
                Display();
               
            }
          

        }

        public int Dice()
        {
            //show the dice
            Random rdm = new Random();

            //Run the dice
            int Dice1 = rdm.Next(1, 7);
            int Dice2 = rdm.Next(1, 7);
             Move = Dice1 + Dice2;
            return Move;
        }

        public string Display()
        {
            

            DCVaule.Text = Move.ToString();
            PLVaule.Text = Ploc[PlayerTurn].ToString();
            NEVaule.Text = playernames[PlayerTurn];
            MVaule.Text = playermoney[PlayerTurn];
            SNVaule.Text = playersprits[PlayerTurn];
            TrVaule.Text = (PlayerTurn + 1).ToString();
            
            return "";
        }

        public string PlayerMove()
        {
            Ploc[PlayerTurn] = Ploc[PlayerTurn] + Move;
            //make sure not to go beyond the board
            if (Ploc[PlayerTurn] > 39) { Ploc[PlayerTurn] = Ploc[PlayerTurn] - 40; }
             
            return "";
        }
        public string MoveSprte()
        {
            int XValue = 923; 
            int YValue = 788;

            HatSprite.Location = new Point(XValue, YValue);
            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Move == 0)
            {
                MessageBox.Show("RollDice ");
            }
            else if(stopMove == 0)
            {
                MessageBox.Show("Move First");
            }
            else
            {
                PlayerTurn++; if (PlayerTurn > 3) { PlayerTurn = 0; }
                Move = 0;
                Display();
            }
        }
    }
}
