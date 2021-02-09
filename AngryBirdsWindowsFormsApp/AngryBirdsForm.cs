using System;
using System.Windows.Forms;

namespace AngryBirdsWindowsFormsApp
{
    public partial class AngryBirdsForm : Form
    {
        BirdBall birdBall;
        PigBall pigBall;

        Timer timer= new Timer();

        public AngryBirdsForm()
        {            
            InitializeComponent();
            timer.Interval = 60;
            timer.Tick += Timer_Tick; 
        }        

        private void AngryBirdsForm_Shown(object sender, EventArgs e)
        { 
            scoreLabel.Text = "0";

            CreateNewBird();
            CreateNewPig();
        }

        private void AngryBirdsForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (!birdBall.IsMovable())
            {
                birdBall.SetVelocity(e.X, e.Y);
                timer.Start();
                birdBall.Start();
            }            
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (birdBall.Intersect(pigBall))
            {

                scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text)+1).ToString();
                CreateNewPig();
                CreateNewBird();
            }
            if (!birdBall.IsMovable())
            {
                CreateNewBird();
            }
            if (birdBall.IsOutSide())
            {
                CreateNewBird();
            }
        }
        void CreateNewBird()
        {
            timer.Stop();
            if (birdBall!= null)
            {
                birdBall.Stop();
                birdBall.Clear();
            }
            birdBall = new BirdBall(this);
            birdBall.Show();
        }
        void CreateNewPig()
        {            
            if (pigBall != null)
            {
                pigBall.Clear();
            }
            pigBall = new PigBall(this);
            pigBall.Show();
        }

        private void AngryBirdsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
