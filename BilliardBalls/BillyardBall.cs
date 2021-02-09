using BallsCommon;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillyardBallsWindowsFormsApp
{
    public class BillyardBall : MoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;        
        public BillyardBall(MainForm form) : base(form)
        {
        }
        protected override void Go()
        {
            base.Go();
            if (centerX <= LeftSide())
            {
                vx = -vx;
                СhangeColor();
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (centerX >= RightSide())
            {
                vx = -vx;
                СhangeColor();
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (centerY <= TopSide())
            {
                vy = -vy;
                СhangeColor();
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (centerY >= DownSide())
            {
                vy = -vy;
                СhangeColor();
                OnHited.Invoke(this, new HitEventArgs(Side.Down));
            }
        }

        private void СhangeColor()
        {
            color = new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
        }                
    }
}
