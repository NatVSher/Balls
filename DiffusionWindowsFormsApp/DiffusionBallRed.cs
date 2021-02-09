using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffusionWindowsFormsApp
{
    class DiffusionBallRed : DiffusionBall
    {
        public DiffusionBallRed(Form form) : base(form)
        {
            centerX = random.Next(LeftSide(), form.ClientSize.Width / 2 + radius);
            centerY = random.Next(TopSide(), DownSide());            
        }        
    }
}
