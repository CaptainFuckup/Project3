using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.MapRender
{
    public class WeatherPoint
    {
        private int temperature;
        private WeatherIcon icon;
        private Point point;
        private Label tlabel;
        private PictureBox box;

        public WeatherPoint(int temperature, WeatherIcon ico , Point xypoint, PictureBox pbParent, ImageList images)
        {
            tlabel = new Label();
            tlabel.Parent = pbParent;
            tlabel.Text =  temperature.ToString() + "c";
            tlabel.Visible = true;
            tlabel.Location = xypoint;
            tlabel.BackColor = Color.Transparent;
            tlabel.BringToFront();
            tlabel.Show();

            box = new PictureBox();
            box.Parent = pbParent;
            box.Image = images.Images[(int)ico];
            xypoint.X = xypoint.X + 10;
            xypoint.Y = xypoint.Y + 10;
            box.Location = xypoint;
            box.Size = new Size(16, 16);
            box.BackColor = Color.Transparent;
            box.BringToFront();
            box.Show();
            
        }
    }
}
