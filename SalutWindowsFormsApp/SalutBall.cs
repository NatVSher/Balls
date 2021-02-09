using BallsCommon;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalutWindowsFormsApp
{
    public class SalutBall : MoveBall
    {
        private float g = 0.2f;
        
        public SalutBall(Form form, float centerX, float centerY) : base(form)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            vy = -Math.Abs(vy);
            color = new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
        }
        protected override void Go()
        {
            base.Go();
            vy += g;
        }
    }
}
