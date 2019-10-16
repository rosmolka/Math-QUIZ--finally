using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_QUIZ
{
    public partial class Form1 : Form
    {
      
        //dzieki JAN
            // Create a Random object called randomizer 
            // to generate random numbers.
            Random randomizer = new Random();
           // These integer variables store the numbers 
           // for the addition problem. 
        int addend1;
        int addend2;

        // Start the quiz by filling in all of the problems
        // and starting the timer.
        int minuend;
        int subtrahend;
        // the variables for the substraction problem  
        int multiplicand;
        int multiplier;

        int dividend;
        int divisor;

       

        //This integer variable keeps track of the remaining time.
        int timeLeft;
        
        /// Check the answer to see if the user got everything right.
        /// True if the answer's correct, false otherwise.
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == subtraction.Value )
                  && (multiplicand*multiplier == multiplication.Value)
                    &&(dividend / divisor == division.Value))

                return true;
            else
                return false;
        }
        public void StartTheQuiz()
        {
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

        

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            sum.Value = 0;

            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);

            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();

            subtraction.Value = 0;

            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
  
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();

            multiplication.Value = 0;

            dividend = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
           

            
           

            // Start the timer.
            timeLeft = 30;
            TimeLabel.Text = "30 seconds";
            timer1.Start();

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
                StartTheQuiz();
                startButton.Enabled = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
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
                // If CheckTheAnswer() return false, keep counting
                // down. Decrease the time left by one second and 
                // display the new time left by updating the 
                // Time Left label.
                timeLeft--;
                TimeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show 
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                TimeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                subtraction.Value = minuend - subtrahend;
                multiplication.Value = multiplicand * multiplier;
                division.Value = dividend / divisor;

               
                startButton.Enabled = true;
            }
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {
            TimeLabel.BackColor = Color.Red;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void subtraction_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void multiplication_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void timesLeftLabel_Click(object sender, EventArgs e)
        {

        }

        private void TimeLeft_Click(object sender, EventArgs e)
        {

        }
    }
}
