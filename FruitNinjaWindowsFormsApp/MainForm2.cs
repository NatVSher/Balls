using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp
{
    public partial class MainForm2 : Form
    {
        private Timer timerStart;
        private Timer timerBomb;
        private Timer timerSlowDown;
        private bool startSlowDown = false;
        private Random random = new Random();
        List<FruitBall> ballsFruit = new List<FruitBall>();
        private BombBall ballBomb;
        private BananBall ballBanan;
        public MainForm2()
        {
            InitializeComponent();
        }

        private void MainForm2_Load(object sender, EventArgs e)
        {
            timerStart = new Timer();
            timerStart.Interval = 100;
            timerStart.Tick += TimerStart_Tick;
            timerStart.Start();
            timerBomb = new Timer();
            timerBomb.Interval = 5000;
            timerBomb.Tick += TimerBomb_Tick;
            timerBomb.Start();
        }

        private void TimerBomb_Tick(object sender, EventArgs e)
        {
            ballBomb = new BombBall(this);
            ballBanan = new BananBall(this);
            int bombORbanan = random.Next(1, 3);
            if (bombORbanan == 1)
            {
                ballBomb.Start();
            }
            else
            {
                ballBanan.Start();
            }
            timerBomb.Interval = random.Next(7000, 10000);
        }

        private void TimerStart_Tick(object sender, EventArgs e)
        {
            var ballFruit = new FruitBall(this);
            ballsFruit.Add(ballFruit);
            ballFruit.Start();
            if (startSlowDown)
            {
                ballFruit.SlowDown();
            }
            timerStart.Interval = random.Next(300, 800);
        }


        private void MainForm2_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < ballsFruit.Count; i++)
            {
                if (ballsFruit[i].IsMovable() && ballsFruit[i].Exists(e.X, e.Y))
                {
                    ballsFruit[i].Stop();
                    ballsFruit[i].Clear();
                    caughtBallsLabel.Text = (Convert.ToInt32(caughtBallsLabel.Text) + 1).ToString();
                    ballsFruit.RemoveAt(i);
                    continue;
                }
                if (ballsFruit[i].CenterY() > this.ClientSize.Height)
                {
                    ballsFruit[i].Stop();
                    ballsFruit[i].Clear();
                    ballsFruit.RemoveAt(i);
                }

            }
            if (ballBomb != null)
            {
                if (ballBomb.Exists(e.X, e.Y))
                {
                    ballBomb.Stop();
                    ballBomb.Clear();
                    timerStart.Stop();
                    timerBomb.Stop();
                    MessageBox.Show("Конец игры");
                    Close();
                }
            }
            if (ballBanan != null)
            {
                if (ballBanan.Exists(e.X, e.Y))
                {
                    foreach (FruitBall fruit in ballsFruit)
                    {
                        fruit.SlowDown();
                    }
                    ballBanan.Stop();
                    ballBanan.Clear();
                    startSlowDown = true;
                    timerSlowDown = new Timer();
                    timerSlowDown.Interval = 10000;
                    timerSlowDown.Start();
                    timerSlowDown.Tick += TimerSlowDown_Tick;
                }
            }
        }

        private void TimerSlowDown_Tick(object sender, EventArgs e)
        {
                timerSlowDown.Stop(); 
                startSlowDown = false;          
        }
    }
}
