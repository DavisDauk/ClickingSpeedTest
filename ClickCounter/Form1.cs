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

        int timeLeft, totalClicks = 0;
        bool testOn = false;

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
            }
            else
            {
                totalClicks++;
                timeLeftSec.Text = totalClicks + " :Clicks";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLeftTxt.Text = timeLeft + "s";
            }
            else
            {
                testOn = false;
                mainBt.Enabled = false;
            }

           
        }


    }
}
