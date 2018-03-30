using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atmosfeer2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            switch (trackBar1.Value)
            {
                case 1:
                    months.Text = "Jan";
                    break;
                case 2:
                    months.Text = "Feb";
                    break;
                case 3:
                    months.Text = "Mar";
                    break;
                case 4:
                    months.Text = "Apr";
                    break;
                case 5:
                    months.Text = "Mei";
                    break;
                case 6:
                    months.Text = "Jun";
                    break;
                case 7:
                    months.Text = "Jul";
                    break;
                case 8:
                    months.Text = "Aug";
                    break;
                case 9:
                    months.Text = "Sep";
                    break;
                case 10:
                    months.Text = "Okt";
                    break;
                case 11:
                    months.Text = "Nov";
                    break;
                default:
                    months.Text = "Dec";
                    break;
            }
                
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
