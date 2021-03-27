using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrapsGame
{
    public partial class Form1 : Form
    {
        public enum DiceNames
        {
            SNAKE_EYES = 2,
            TREY = 3,
            YO_LEVEN = 11,
            BOX_CARS = 12
        }
        int myPoint;
        int myDie1;
        int myDie2;

        public Form1()
        {
            InitializeComponent();
        }

        private void displayDie(Label die, int face)
        {
            die.Text = Convert.ToString(face);
        }

        private int rollDice()
        {
            int die1, die2;
            Random randomNumber = new Random();

            die1 = randomNumber.Next(1, 7);
            die2 = randomNumber.Next(1, 7);

            displayDie(lbl_die1, die1);
            displayDie(lbl_die2, die2);

            return die1 + die2;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            myPoint = 0;
            int sum = rollDice();
            switch (sum)
            {
                case 7:
                case (int)DiceNames.YO_LEVEN:
                    btnRoll.Enabled = false;
                    lblResult.Text = "You Win!!!";
                    break;
                case (int)DiceNames.SNAKE_EYES:
                case (int)DiceNames.TREY:
                case (int)DiceNames.BOX_CARS:
                    btnRoll.Enabled = false;
                    lblResult.Text = "You Lose!!!";
                    break;
                default:
                    myPoint = sum;
                    lblPoints.Text = $"Points: {Convert.ToString(myPoint)}";
                    lblResult.Text = "Roll Again";
                    displayDie(lbl_die1, myDie1);
                    displayDie(lbl_die2, myDie2);
                    btnPlay.Enabled = false;
                    btnRoll.Enabled = true;
                    break;
            }
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int sum = rollDice();

            if (sum == myPoint)
            {
                lblResult.Text = "You Win!!!";
                btnRoll.Enabled = false;
                btnPlay.Enabled = true;
            } else if (sum == 7)
            {
                lblResult.Text = "You Lose!!!";
                btnRoll.Enabled = false;
                btnPlay.Enabled = true;
            }
        }
    }
}
