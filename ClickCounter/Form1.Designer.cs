namespace ClickCounter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainBt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLeftTxt = new System.Windows.Forms.Label();
            this.timeLeftSec = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.HScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainBt
            // 
            this.mainBt.Location = new System.Drawing.Point(109, 177);
            this.mainBt.Name = "mainBt";
            this.mainBt.Size = new System.Drawing.Size(201, 96);
            this.mainBt.TabIndex = 1;
            this.mainBt.Text = "Start";
            this.mainBt.UseVisualStyleBackColor = true;
            this.mainBt.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLeftTxt
            // 
            this.timeLeftTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.timeLeftTxt.Location = new System.Drawing.Point(58, 48);
            this.timeLeftTxt.Name = "timeLeftTxt";
            this.timeLeftTxt.Size = new System.Drawing.Size(134, 43);
            this.timeLeftTxt.TabIndex = 2;
            this.timeLeftTxt.Text = "10s";
            // 
            // timeLeftSec
            // 
            this.timeLeftSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.timeLeftSec.Location = new System.Drawing.Point(198, 48);
            this.timeLeftSec.Name = "timeLeftSec";
            this.timeLeftSec.Size = new System.Drawing.Size(160, 43);
            this.timeLeftSec.TabIndex = 3;
            this.timeLeftSec.Text = "0 : Clicks";
            // 
            // resetButton
            // 
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.resetButton.Enabled = false;
            this.resetButton.Location = new System.Drawing.Point(109, 299);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(201, 49);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // HScore
            // 
            this.HScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.HScore.Location = new System.Drawing.Point(97, 101);
            this.HScore.Name = "HScore";
            this.HScore.Size = new System.Drawing.Size(261, 43);
            this.HScore.TabIndex = 5;
            this.HScore.Text = "Record: n/a";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(413, 360);
            this.Controls.Add(this.HScore);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.timeLeftSec);
            this.Controls.Add(this.timeLeftTxt);
            this.Controls.Add(this.mainBt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button mainBt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLeftTxt;
        private System.Windows.Forms.Label timeLeftSec;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label HScore;
    }
}

