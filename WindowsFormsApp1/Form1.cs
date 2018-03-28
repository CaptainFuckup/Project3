using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using WindowsFormsApp1.MapRender;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
     

    public partial class Form1 : Form
    {

        private List<WeatherPoint> weatherpoints;
        private List<PictureBox> pictures;
        private List<Province> provinces;

        public Form1()
        {
            InitializeComponent();
            weatherpoints = new List<WeatherPoint>();
            pictures = new List<PictureBox>();
            provinces = new List<Province>();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            string value = trackBar1.Value.ToString();
            day_value.Text = value;
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
