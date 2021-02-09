using BallsCommon;
using System.Drawing;
using System.Windows.Forms;

namespace AngryBirdsWindowsFormsApp
{
    public class PigBall : RandomPointBall
    {
        public PigBall(Form form) : base(form)
        {
            radius = 30;            
            color = Brushes.Pink;           
        }
        
    }
}
