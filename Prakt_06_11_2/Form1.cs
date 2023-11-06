using System;

namespace Prakt_06_11_2
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer; 
        int progress = 0;
        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateStatusBarTime();
        }
        private void UpdateStatusBarTime()
        {
            toolStripStatusLabel1.Text = "Поточна дата: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            progress = 0; 
            progressBarTimer.Value = 0; 
            timer = new System.Windows.Forms.Timer(); 
            timer.Interval = 100; 
            timer.Tick += ProgressBarTimer_Tick;
            timer.Start();
        }
        private void ProgressBarTimer_Tick(object sender, EventArgs e)
        {
            progress++;
            if (progress <= 100)
            {
                progressBarTimer.Value = progress;
            }
            else
            {
                timer.Stop();
                MessageBox.Show("ProgressBar заповнений!");
            }
        }
    }


}