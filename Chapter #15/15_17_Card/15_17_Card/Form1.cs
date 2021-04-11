using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_17_Card
{
    public partial class frmDeck : Form
    {
        private Card[] deck = new Card[52];
        private int currentCard;

        public frmDeck()
        {
            InitializeComponent();
        }

        private void frmDeck_Load(object sender, EventArgs e)
        {
            string[] faces =
            {
                "Ace", "Deuce", "Three", "Four",
                "Five", "Six", "Seven", "Eight",
                "Nine", "Ten", "Jack", "Queen", "King"
            };
            string[] suits =
            {
                "Hearts", "Diamonds", "Clubs", "Spades"
            };

            currentCard = -1;

            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = new Card(faces[i % 13], suits[i % 4]);
            }
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            Card dealt = DealCard();
            if (dealt != null)
            {
                lblCard.Text = dealt.ToString();
                lblStatus.Text = $"Card #: {currentCard}";
            } else
            {
                lblCard.Text = "No more cards to deal";
                lblStatus.Text = "Shuffle cards to continue";
            }
        }

        private Card DealCard()
        {
            if (currentCard + 1 < deck.Length)
            {
                currentCard++;
                return deck[currentCard];
            }

            btnDeal.Enabled = false;
            return null;
        }

        private void Shuffle()
        {
            Random randomNumber = new Random();
            Card tempValue;

            currentCard = -1;
            for (int i = 0; i < deck.Length; i++)
            {
                int j = randomNumber.Next(52);
                tempValue = deck[i];
                deck[i] = deck[j];
                deck[j] = tempValue;
            }

            btnDeal.Enabled = true;
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "SHUFFLING....";
            Shuffle();
            lblStatus.Text = "DECK IS SHUFFLED";
        }
    }
}
