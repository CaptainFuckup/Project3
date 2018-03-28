using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.MapRender
{
    public class Province
    {
        public PictureBox Box { get; set; }

        public Province(ProvinceIcon ico, PictureBox pbParent, ImageList images)
        {
 
            Box = new PictureBox();
            Point point = new Point();
            switch (ico)
            {
                case ProvinceIcon.ZuidHolland:
                    point.X = 130;
                    point.Y = 456;
                    Box.Size = new Size(233, 191);
                    break;
                case ProvinceIcon.NoordHolland:
                    point.X = 600;
                    point.Y = 600;
                    break;
                default:
                    break;
            }


            Box.Parent = pbParent;
            Box.Image = images.Images[(int)ico];
            
            Box.Location = point;
            Box.SizeMode = PictureBoxSizeMode.StretchImage;
            Box.BackColor = Color.Transparent;
            Box.BringToFront();
            Box.Show();

        }
    }
}
