using System.Drawing;
using System.Windows.Forms;

namespace FruitNinjaWindowsFormsApp
{
    public class BananBall : BombBall
    {
        public BananBall(Form form) : base(form)
        {
            color = Brushes.Yellow;
        }
    }
}
