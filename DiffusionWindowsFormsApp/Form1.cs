using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BallsCommon;


namespace DiffusionWindowsFormsApp
{
    public partial class Form1 : Form
    {
        private int countBalls = 10;
        private Timer timerStop;
        private int countBlue;
        private int countRed;
        List<DiffusionBallRed> ballsRed = new List<DiffusionBallRed>();
        List<DiffusionBallBlue> ballsBlue = new List<DiffusionBallBlue>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            for (int i = 0; i < countBalls; i++)
            {
                var ballRed = new DiffusionBallRed(this);
                ballsRed.Add(ballRed);
                ballRed.OnHited += BallRed_OnHited;
                ballRed.Start();
            }
            
            for (int i = 0; i < countBalls; i++)
            {
                var ballBlue = new DiffusionBallBlue(this);
                ballsBlue.Add(ballBlue);
                ballBlue.OnHited += BallBlue_OnHited;
                ballBlue.Start();
            }
            timerStop = new Timer();
            timerStop.Interval = 60;
            timerStop.Start();
            timerStop.Tick += TimerStop_Tick;
                       
            
        }
        private void TimerStop_Tick(object sender, EventArgs e)
        {
            countBlue = 0;
            countRed = 0;
            int radius = ballsRed[0].Rudius();
            for (int i = 0; i < countBalls; i++)
            {
                if (ballsRed[i].CenterX() >= this.ClientSize.Width / 2 + radius) countRed++;
                if (ballsBlue[i].CenterX() >= this.ClientSize.Width / 2 + radius) countBlue++;
            }
            if (countRed == countBlue && countBlue != 0)
            {
                for (int i = 0; i < countBalls; i++)
                {
                    ballsRed[i].Stop();
                    ballsBlue[i].Stop();
                }
                timerStop.Stop();
            }
        }
        private void BallBlue_OnHited(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftBlueLabel.Text = (Convert.ToInt32(leftBlueLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightBlueLabel.Text = (Convert.ToInt32(rightBlueLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topBlueLabel.Text = (Convert.ToInt32(topBlueLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downBlueLabel.Text = (Convert.ToInt32(downBlueLabel.Text) + 1).ToString();
                    break;
            }
        }

        private void BallRed_OnHited(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftRedLabel.Text = (Convert.ToInt32(leftRedLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightRedLabel.Text = (Convert.ToInt32(rightRedLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topRedLabel.Text = (Convert.ToInt32(topRedLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downRedLabel.Text = (Convert.ToInt32(downRedLabel.Text) + 1).ToString();
                    break;
            }
        }
    }
}
