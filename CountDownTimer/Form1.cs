using System;
using System.Windows.Forms;
using NAudio.Wave;


namespace CountDownTimer
{
    public partial class CountDownTimer : Form
    {
        private IWavePlayer waveOut;
        private AudioFileReader audioFileReader;
        public CountDownTimer()
        {
            InitializeComponent();
            waveOut = new WaveOut();
            audioFileReader = new AudioFileReader("Everybody.mp3");
            waveOut.Init(audioFileReader);
        }
        int timeleft = 60;
        
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                timerlabel.Text = timeleft + "seconds";

            }
            else
            {
                waveOut.Play();
                timer.Stop();
                timerlabel.Text = "Time is up";
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timeleft = 60;
            timerlabel.Text = timeleft + "seconds";

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeleft = timeleft + 5;
            timerlabel.Text = timeleft.ToString() + "seconds";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timeleft = timeleft - 5;
            timerlabel.Text = timeleft.ToString() + "seconds";
        }
    }
}
