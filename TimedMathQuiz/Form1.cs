using System;
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
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
        private void startButton_Click(object sender, EventArgs e)
        {
 Random random = new Random();
            int leftInt = random.Next(51);
            int rightInt = random.Next(51);

            plusLeftLabel.Text = leftInt.ToString();
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
