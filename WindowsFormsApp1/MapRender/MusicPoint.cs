using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.MapRender
{
    public class MusicPoint
    {

        private Label tlabel;
        private PictureBox box;

        public MusicPoint( MusicIcon ico, Point xypoint, PictureBox pbParent, ImageList images)
        {

            box = new PictureBox();
            box.Parent = pbParent;
            box.Image = images.Images[(int)ico];
            xypoint.X = xypoint.X + 10;
            xypoint.Y = xypoint.Y + 10;
            box.Location = xypoint;
            box.BackColor = Color.Transparent;
            box.BringToFront();
            box.Show();

        }
    }
}
