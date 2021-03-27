using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _6_10_RoolDie
{
    public partial class Form1 : Form
    {
        int Min = 1;
        int Max = 7;
        int Total = 0;
        Dictionary<int, int> Counter = new Dictionary<int, int>()
        {
            { 1, 0 },
            { 2, 0 },
            { 3, 0 },
            { 4, 0 },
            { 5, 0 },
            { 6, 0 },
        };

        Random randomGenerator = new Random();
        List<Label> labels;

        public Form1()
        {
            InitializeComponent();
            labels = new List<Label>()
            {
                lbl_die_1,
                lbl_die_2,
                lbl_die_3,
                lbl_die_4
            };
        }

        public void DisplayDie(Label dieLabel)
        {
            int face = randomGenerator.Next(Min, Max);
            Counter[face]++;
            Total++;
            dieLabel.Text = Convert.ToString(face);
        }

        private void DisplayStatistics()
        {
            string messageText = "Face\tFrequency\tPercent\n";
            foreach (KeyValuePair<int, int> row in Counter)
            {
                double frequency = Math.Round((row.Value / (double)Total) * 100, 2);
                messageText += $"{row.Key}\t{frequency}\t\t{frequency}%\n";
            }

            txtStatistics.Text = messageText;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            foreach(Label label in labels)
            {
                DisplayDie(label);
                DisplayStatistics();
            }
        }
    }
}
