using BallsCommon;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AngryBirdsWindowsFormsApp
{
    public class BirdBall : Ball
    {
        private float g = 0.2f;
        private float elastic =0.6f;
        public BirdBall(Form form) : base(form)
        {
            radius = 20;
            centerX = LeftSide();
            centerY = DownSide();
            color = Brushes.Yellow;           
        }
        protected override void Go()
        {
            base.Go();            
            if (centerY >= DownSide())
            {                
                vy = -vy;
                vy = vy * elastic;
                vx = vx * elastic;
                centerY = DownSide();
            }
            if (vy <= 0.1 && vx <=0.1)
            {                                
                Stop();               
            }
            vy += g;
        }
        
        public bool IsOutSide()
        {
            return centerX > RightSide();
        }
        public void SetVelocity(int x, int y)
        {
            vx = (x - centerX) / 20;
            vy = (y - centerY) / 20;
        }
        
    }
}
