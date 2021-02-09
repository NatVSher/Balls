using System.Drawing;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp
{
    public class BombBall : FruitBall
    {
        public BombBall(Form form) : base(form)
        {
            color = Brushes.Black;
            radius = 25;
            vy = -15;            
        }
    }
}
