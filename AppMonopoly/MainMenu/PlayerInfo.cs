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
    public partial class PlayerInfo : Form
    {
        private static string[] playerNames = new string[4];
        private static string[] PlayerSprit = new string[4];
        private static string[] PlayerMoney = new string[4];
        private int ToExit = 0;
        private int NextPlayer = 0;

        public PlayerInfo()
        {
            InitializeComponent();
            //GetUserInputs();

        }
     

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu  mm = new MainMenu();
            mm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (PlayerBox1.Text == "")
            {
                MessageBox.Show("Enter Somethink");
            }
            else if (!(CheckBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked))
            {
                MessageBox.Show("Pick a Sprit");
            }
            else if(CheckBox1.Checked & checkBox2.Checked & checkBox3.Checked & checkBox4.Checked || CheckBox1.Checked & checkBox4.Checked || CheckBox1.Checked & checkBox3.Checked || checkBox2.Checked & checkBox3.Checked || checkBox2.Checked & checkBox4.Checked || CheckBox1.Checked & checkBox2.Checked || checkBox3.Checked & checkBox4.Checked)
            {
                MessageBox.Show("Pick Just one Sprte");
            }
            else if (ToExit < 3)
            {

                GetUserInputs();
                NextPlayer++;
                ToExit++;

            }
            else
            {
               
                GetUserInputs();
                this.Hide();
                GameBoard gb = new GameBoard();
                gb.ShowDialog();

            }
           

        }

        public  string GetUserInputs()
        {

           int LoopNum = 0;

           LoopNum = (NextPlayer + 2);
           playerNames[NextPlayer] = PlayerBox1.Text;
           PlayerBox1.Text = null;
           lblWhatPlayer.Text = LoopNum.ToString();

            if (CheckBox1.Checked)
            {
                PlayerSprit[NextPlayer] = CheckBox1.Text;
                CheckBox1.Visible = false;
                CheckBox1.Checked = false;
            }
            else if (checkBox2.Checked)
            {
                PlayerSprit[NextPlayer] = checkBox2.Text;
                checkBox2.Visible = false;
                checkBox2.Checked = false;
            }
            else if (checkBox3.Checked)
            {
                PlayerSprit[NextPlayer] = checkBox3.Text;
                checkBox3.Visible = false;
                checkBox3.Checked = false;
            }
            else if (checkBox4.Checked)
            {
                PlayerSprit[NextPlayer] = checkBox4.Text;
                checkBox4.Visible = false;
                checkBox4.Checked = false;
            }

            PlayerMoney[NextPlayer] = "1500";

            return "";
          
            
        }


        public static string[] getplayernames()
        {
            
            return playerNames;



        }

        public static string[] getPlayerSprit()
        {

            return PlayerSprit;



        }

        public static string[] getPlayerMoney()
        {

            return PlayerMoney;



        }

    }
}


