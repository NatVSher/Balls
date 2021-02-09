using BallsCommon;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SalutWindowsFormsApp
{
    public partial class MainForm1 : Form
    {
        private Timer timerStart;
        private Random random = new Random();
        List<ProjectileBall> ballsSalut = new List<ProjectileBall>();
        int numberSalut = 0;
        int countBallsSalut = 7;
        public MainForm1()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var random = new Random();
            var count = random.Next(1, 11);
            for (int i = 0; i < count; i++)
            {
                var salut = new SalutBall(this, e.X, e.Y);
                salut.Start();
            }

        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
            timerStart = new Timer();
            timerStart.Interval = 100;
            timerStart.Start();
            timerStart.Tick += TimerStart_Tick;
        }

        private void TimerStart_Tick(object sender, EventArgs e)
        {
            var ballSalut = new ProjectileBall(this);
            ballsSalut.Add(ballSalut);
            numberSalut++;
            ballSalut.Start();

            if (numberSalut > 19)
            {
                var y = ballsSalut[0].CenterY();
                var x = ballsSalut[0].CenterX();
                ballsSalut[0].Stop();
                ballsSalut[0].Clear();
                ballsSalut.RemoveAt(0);
                for (int i = 0; i < countBallsSalut; i++)
                {
                    var salutBam = new SalutBall(this, x, y);
                    salutBam.Start();
                }
                numberSalut--;
            }
        }
    }
}
