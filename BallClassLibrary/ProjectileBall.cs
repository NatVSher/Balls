using BallsCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsCommon
{
    public class ProjectileBall : MoveBall
    {        
        public ProjectileBall(Form form) : base(form)
        {
            vx = 0;
            vy = -10;            
            centerY =  DownSide();
            radius = 15;
        }
        public float CenterY()
        {
            return centerY;
        }
        public float CenterX()
        {
            return centerX;
        }
    }
}
