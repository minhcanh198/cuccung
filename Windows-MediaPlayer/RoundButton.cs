using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Windows_MediaPlayer
{
    public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(5, 5, ClientSize.Width-10, ClientSize.Height-10);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}
