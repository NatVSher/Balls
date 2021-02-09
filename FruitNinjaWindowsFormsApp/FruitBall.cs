using BallsCommon;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp
{
    public class FruitBall : ProjectileBall
    {
        private float g = 0.3f;        
        public FruitBall(Form form) : base(form)
        {
            radius = 20;
            vy = -random.Next(10, 17);
            color = new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
        }
        protected override void Go()
        {
            base.Go();
            vy += g;
        }
        public void SlowDown()
        {
            vy = vy / 3;
            g = 0.05f;
        }

    }
}
