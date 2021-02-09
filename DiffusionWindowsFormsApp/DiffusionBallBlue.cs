using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffusionWindowsFormsApp
{
    class DiffusionBallBlue : DiffusionBall
    {        
        public DiffusionBallBlue(Form form) : base(form)
        {
            centerX = random.Next(form.ClientSize.Width / 2 + radius, RightSide());
            centerY = random.Next(TopSide(), DownSide());  
            color = Brushes.Blue;         
        }
    }
}
