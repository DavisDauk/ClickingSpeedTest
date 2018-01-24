using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickCounter
{
    public partial class Form1 : Form {

        int timeLeft, _totalClicks = 0;
        bool testOn = false;
        private int Record = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (testOn == false)
            {
                timer1.Start();
                timeLeft = 10;
                testOn = true;
                resetButton.Enabled = false;
            }
            else
            {
                _totalClicks++;
                timeLeftSec.Text = _totalClicks + @" :Clicks";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            testOn = false;
            timeLeft = 10;
            mainBt.Enabled = true;
            _totalClicks = 0;
            timeLeftTxt.Text = "10s";
            resetButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 1)
            {
                timeLeft = timeLeft - 1;
                timeLeftTxt.Text = timeLeft + "s";
            }
            else
            {
                timeLeft = timeLeft - 1;
                timeLeftTxt.Text = timeLeft + "s";


                testOn = false;
                mainBt.Enabled = false;
                timer1.Stop();
                resetButton.Enabled = true;

                if (Record < _totalClicks)
                {
                    Record = _totalClicks;
                    HScore.Text = "Record: " + Record;
                }
            }

           
        }


    }
}
