using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallsCommon
{
    public class Ball
    {
        protected Form form;
        private Timer timer;
        protected float vx = 10;
        protected float vy = 10;
        protected float centerX = 10;
        protected float centerY = 10;
        protected int radius = 10;
        protected Brush color = Brushes.Red;

        public Ball(Form form)
        {
            this.form = form;
            timer = new Timer();
            timer.Interval = 60;
            timer.Tick += Timer_Tick;
        }
        public void Show()
        {           
            Draw(color);
        }
        public void Clear()
        {            
            var brush = new SolidBrush(form.BackColor);
            Draw(brush);
        }
        public void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();            
            var rectangle = new RectangleF(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }
        public void Move()
        {
            Clear();
            Go();
            Show();
        }
        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }
        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }
        public int LeftSide()
        {
            return radius;
        }
        public int TopSide()
        {
            return radius;
        }
        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }
        public bool OnForm(Form form)
        {
            return centerX >= LeftSide() && centerX <= RightSide() && centerY >= TopSide() && centerY <= DownSide();
        }
        public bool Exists(int pointX, int pointY)
        {            
            var dx = pointX - centerX;
            var dy = pointY - centerY;

            return dx * dx + dy * dy <= radius * radius;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }
        public bool IsMovable()
        {
            return timer.Enabled;
        }
        public float GetCenterX()
        {
            return centerX;
        }

        public float GetCenterY()
        {
            return centerY;
        }
        public bool Intersect(Ball other)
        {
            var dx = centerX - other.centerX;
            var dy = centerY - other.centerY;
            return dx * dx + dy * dy <= (radius + other.radius) * (radius + other.radius);
        }
    }
}
