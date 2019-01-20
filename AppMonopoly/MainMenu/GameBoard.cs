using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MainMenu
{
    public partial class GameBoard : Form
    {
        //____________________Just a Lot of Arrays_________________________________________________:)
        private int[] Ploc = new int[4]; // Store the Loction of the Player in a Array
        //private string[,] PlayersBlock= new string[];
        private int PlayerTurn = 0; // What Player we are on. 

        private int Move = 0; // How mush to move
        private int stopMove = 0; //Stop the Player form moveing agin.
        private PictureBox[] pictures = new PictureBox[4];
        

        //Array of Coordinates
        private int[] xcoordinate = { 1044, 928, 870, 812, 754, 694, 636, 578, 520, 462, 404, 404, 404, 404, 404, 404, 404, 404, 404, 404, 404, 462, 520, 578, 636, 694, 754, 812, 870, 928, 1044, 1044, 1044, 1044, 1044, 1044, 1044, 1044, 1044, 1044, 1044};
        private int[] ycoordinate = { 766, 766, 766, 766, 766, 766, 766, 766, 766, 766, 766, 686, 625, 560, 498, 433, 368, 303, 238, 173, 108, 108, 108, 108, 108, 108, 108, 108, 108, 108, 108, 173, 238, 303, 368, 433, 498, 560, 625, 686, 766 };

        //Get Player Name from the Methods
        string[] playermoney = PlayerInfo.getPlayerMoney();
        string[] playersprits = PlayerInfo.getPlayerSprit();
        string[] playernames = PlayerInfo.getplayernames();


        string[] BlockId = getBlockId();
        string[] BlockRent = getBlockRent();

        
        //_______________________________________________________________________________________________________________
        public GameBoard()
        {
            InitializeComponent();
            InitializeSpritesArray();
            getBlockId();
            Display();
            btnYes.Hide();
            btnNo.Hide();
        }
        private void InitializeSpritesArray() 
        {
            string spritename;
            for (int i = 0; i <4; i++) //aessing PlayersSprits array to Objget Pictures Array 
            {
                spritename = playersprits[i];
                switch (spritename) {
                    case "Car":                
                    pictures[i] = SpriteCar; break;
                    case "Hat": 
                    pictures[i] = SpriteHat; break;
                    case "WeelCart":
                    pictures[i] = SpritCart; break;
                    case "Dog":
                    pictures[i] = SpriteShoe; break;

                }
            }

        }

        public int Dice() //The Dice function 
        {
            //show the dice
            Random rdm = new Random();

            //Run the dice
            int Dice1 = rdm.Next(1, 7);
            int Dice2 = rdm.Next(1, 7);
             Move = Dice1 + Dice2;
            return Move;
        }

        public string Display() //Change the Text
        {
            int WVaule = Convert.ToInt16(Ploc[PlayerTurn]);
            DCVaule.Text = Move.ToString();
            PLVaule.Text = Ploc[PlayerTurn].ToString();
            NEVaule.Text = playernames[PlayerTurn];
            MVaule.Text = playermoney[PlayerTurn];
            SNVaule.Text = playersprits[PlayerTurn];
            TrVaule.Text = (PlayerTurn + 1).ToString();
            BLVaule.Text = BlockId[WVaule];

            
            return "";
        }

        public string PlayerMove() //Moves the Player
        {
            Ploc[PlayerTurn] = Ploc[PlayerTurn] + Move;
            //make sure not to go beyond the board
            if (Ploc[PlayerTurn] > 39) { Ploc[PlayerTurn] = Ploc[PlayerTurn] - 40; }
             
            return "";
        }

        public string MoveSprte()
        {
            int MVaule = Convert.ToInt16(Ploc[PlayerTurn]);
            int XValue = xcoordinate[MVaule];
            int YValue = ycoordinate[MVaule]; 
            
            pictures[PlayerTurn].Location = new Point(XValue, YValue); 
            return "";
        }

        public string DoBlock() //Does the acction of the Block
        {
            int MVaule = Convert.ToInt16(Ploc[PlayerTurn]);
            int PLM = Convert.ToInt16(playermoney[PlayerTurn]);
            if (!(Convert.ToInt16(BlockRent[MVaule]) == 0))
            {
                PLM = Convert.ToInt16(playermoney[PlayerTurn]) - Convert.ToInt16(BlockRent[MVaule]);
                playermoney[PlayerTurn] = Convert.ToString(PLM);
                Display();
            }
            
            
            return "";
        }

        public string CheckBlock() //Check were Current Player is 
        {
            int MVaule = Convert.ToInt16(Ploc[PlayerTurn]);
            int PLM = Convert.ToInt16(playermoney[PlayerTurn]);
            if (!(Convert.ToInt16(BlockRent[MVaule]) == 0))
            {
                btnYes.Show();
                btnNo.Show();
                
            }

            return "";
        }


        public static string[] getBlockId() //Method to call the array PlayerMoney
        {
            StreamReader sr = new StreamReader(@"BlockID.txt");
            int Length = Convert.ToInt16(sr.ReadLine());
            string[] BlockID = new string[Length];
            for(int i = 0; i < Length; i++)
            {
                BlockID[i] = sr.ReadLine(); 
            }
            sr.Close();
            return BlockID;

        }

        public static string[] getBlockRent() //Method to call the array to Get RentPrice from Text File
        {
            StreamReader sr = new StreamReader("BlockRent.txt");
            int Length = Convert.ToInt16(sr.ReadLine());
            string[] BlockRent = new string[Length];
            for (int i = 0; i < Length; i++)
            {
                BlockRent[i] = sr.ReadLine();
            }
            sr.Close();
            return BlockRent;

        }

      //Buttons_________________________________________________________________________________________________________________________:)

        private void button1_Click_1(object sender, EventArgs e) //Debug Button 
        {
            for(int i = 0; i < 40; i++ )
            {
                MessageBox.Show("Here are # " +i +": "+ BlockId[i]);
            }
           // MessageBox.Show("Here are #: " + BlockId[0]);
        }

        private void btnNext_Click(object sender, EventArgs e) //Next Button
        {
            if (Move == 0)
            {
                MessageBox.Show("RollDice ");
            }
            else
            {
                PlayerTurn++; if (PlayerTurn > 3) { PlayerTurn = 0; }
                Move = 0;
                stopMove = 0;
                Display();
            }
        }

        private void btnDice_Click(object sender, EventArgs e) //Dice and Move Button 
        {
            if(stopMove == 0)
            {
                stopMove = 1;
                Dice(); //Calls Dice Function 
                PlayerMove();
                MoveSprte();
                CheckBlock();
                Display(); //Calls the Display Function
                
            }
            else if(stopMove == 1)
            {
                MessageBox.Show("Cheater You can not Roll Dice");
            }
           
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e) //Goes back to MainMenu
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) //Close Button Menu strip
        {
            Close();

        }

        private void btnYes_Click(object sender, EventArgs e) //Yes Button
        {
            DoBlock();
            int MVaule = Convert.ToInt16(Ploc[PlayerTurn]);
            MessageBox.Show("You Have Been Charched $" + BlockRent[MVaule]);
            btnYes.Hide();
            btnNo.Hide();
        }

        private void btnNo_Click(object sender, EventArgs e) //No Button
        {
            MessageBox.Show("Allright");
            btnYes.Hide();
            btnNo.Hide();
        }
    }
}
