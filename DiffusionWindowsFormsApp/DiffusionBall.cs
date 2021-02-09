using BallsCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffusionWindowsFormsApp 
{    
    public class DiffusionBall : BillyardBall
    {         
        public DiffusionBall(Form form) : base(form)
        {
        }
        public float CenterX()
        {
            return centerX;
        }

        public float CenterY()
        {
            return centerY;
        }
        public int Rudius()
        {
            return radius;
        }

    }
}
