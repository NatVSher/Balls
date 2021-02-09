using BallsCommon;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        List<MoveBall> moveBalls;
        int countBalls = 10;
        public MainForm()
        {
            InitializeComponent();
        }

        private void startBallButton_Click(object sender, EventArgs e)
        {
            moveBalls = new List<MoveBall>();
            for (int i = 0; i < countBalls; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }
        private void catchBallButton_Click(object sender, EventArgs e)
        {
            int caughtBalls = 0;
            for (int i = 0; i < countBalls; i++)
            {
                moveBalls[i].Stop();
                if (moveBalls[i].OnForm(this))
                {
                    caughtBalls++;
                }
            }
            caughtBallsLabel.Text = caughtBalls.ToString();
            MessageBox.Show("Вы поймали " + caughtBalls + " мячика(ов).");
            Graphics field = this.CreateGraphics();
            field.Clear(Color.PeachPuff);
            caughtBallsLabel.Text = "0";
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < countBalls; i++)
            {
                if (moveBalls[i].IsMovable() && moveBalls[i].Exists(e.X, e.Y)  )
                {
                    moveBalls[i].Stop();
                    caughtBallsLabel.Text = (Convert.ToInt32(caughtBallsLabel.Text) + 1).ToString();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
