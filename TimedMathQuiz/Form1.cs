﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimedMathQuiz
{
    public partial class Form1 : Form
    {
        int leftInt, rightInt, leftInt2, rightInt2, leftInt3, rightInt3, leftInt4, rightInt4;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        int timeLeft;

        public void StartTheQuiz()
        {
            timeLabel.BackColor = Color.FromArgb(255, 255, 255);
            sum.BackColor = Color.FromArgb(255, 255, 255);
            difference.BackColor = Color.FromArgb(255, 255, 255);
            product.BackColor = Color.FromArgb(255, 255, 255);
            quotient.BackColor = Color.FromArgb(255, 255, 255);

            Random random = new Random();
            leftInt = random.Next(51);
            rightInt = random.Next(51);

            plusLeftLabel.Text = leftInt.ToString();
            plusRightLabel.Text = rightInt.ToString();



            leftInt2 = random.Next(51);
            rightInt2 = random.Next(51);

            subLeftLabel.Text = leftInt2.ToString();
            subRightLabel.Text = rightInt2.ToString();


            leftInt3 = random.Next(12);
            rightInt3 = random.Next(12);

            multLeftLabel.Text = leftInt3.ToString();
            multRightLabel.Text = rightInt3.ToString();



            leftInt4 = random.Next(12);
            rightInt4 = random.Next(12);

            divLeftLabel.Text = leftInt4.ToString();
            divRightLabel.Text = rightInt4.ToString();

            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();



        }
        public int checkAnswers()
        {
            int totalRight = 0;
            if (leftInt + rightInt == sum.Value)
            {
                sum.BackColor = Color.FromArgb(0, 255, 0);
                totalRight++;
            }
            if (leftInt2 - rightInt2 == difference.Value) { 
                difference.BackColor = Color.FromArgb(0, 255, 0);
                totalRight++;
            }
            if (leftInt3* rightInt3 == product.Value){
                product.BackColor = Color.FromArgb(0, 255, 0);
                totalRight++;
            }
            if (leftInt4 / rightInt4 == quotient.Value){
                quotient.BackColor = Color.FromArgb(0, 255, 0);
                totalRight++;
            }


            return totalRight;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkAnswers() == 4)
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
                if(timeLeft < 6)
                {
                    timeLabel.BackColor = Color.FromArgb(255, 0, 0);
                }
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time. You only got: "+checkAnswers()+" answers right", "Sorry!");
                //sum.Value = addend1 + addend2;

                startButton.Enabled = true;
            }
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
       
        private void plusLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void plusLabel_Click(object sender, EventArgs e)
        {

        }

        private void equalsLabel_Click(object sender, EventArgs e)
        {

        }

        private void plusRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void Sum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
