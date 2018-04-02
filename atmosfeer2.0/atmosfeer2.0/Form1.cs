using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            SqlConnection conn;
            String connectionString = "Data Source=DESKTOP-IJQTUQ2\\SQLEXPRESS;Initial Catalog=Festival;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            SqlCommand boef1 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Boef' AND Datum BETWEEN '2017-01-01' AND '2017-01-31' ORDER BY Datum; ", conn);
            SqlCommand boef2 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Boef' AND Datum BETWEEN '2017-02-01' AND '2017-02-28' ORDER BY Datum; ", conn);
            SqlCommand boef3 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Boef' AND Datum BETWEEN '2017-03-01' AND '2017-03-31' ORDER BY Datum; ", conn);
            SqlCommand boef4 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Boef' AND Datum BETWEEN '2017-04-01' AND '2017-04-30' ORDER BY Datum; ", conn);
            SqlCommand boef5 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Boef' AND Datum BETWEEN '2017-05-01' AND '2017-05-31' ORDER BY Datum; ", conn);
            SqlCommand boef6 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Boef' AND Datum BETWEEN '2017-06-01' AND '2017-06-30' ORDER BY Datum; ", conn);
            SqlCommand boef7 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Boef' AND Datum BETWEEN '2017-07-01' AND '2017-07-31' ORDER BY Datum; ", conn);
            SqlCommand boef8 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Boef' AND Datum BETWEEN '2017-08-01' AND '2017-08-31' ORDER BY Datum; ", conn);
            SqlCommand boef9 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Boef' AND Datum BETWEEN '2017-09-01' AND '2017-09-30' ORDER BY Datum; ", conn);
            SqlCommand boef10 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Boef' AND Datum BETWEEN '2017-10-01' AND '2017-10-31' ORDER BY Datum; ", conn);
            SqlCommand boef11 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Boef' AND Datum BETWEEN '2017-11-01' AND '2017-11-30' ORDER BY Datum; ", conn);
            SqlCommand boef12 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Boef' AND Datum BETWEEN '2017-12-01' AND '2017-12-31' ORDER BY Datum; ", conn);

            switch (trackBar1.Value)
            {
                case 1:
                    months.Text = "Jan";
                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = boef1;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bSource = new BindingSource();

                        bSource.DataSource = dbdataset;
                        dataGridView1.DataSource = bSource;
                        sda.Update(dbdataset);
                        //conn.Open();
                        //MessageBox.Show("Connection Open");

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    };
                   
                    break;

                    case 2:
                    months.Text = "Feb";
                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = boef2;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bSource = new BindingSource();

                        bSource.DataSource = dbdataset;
                        dataGridView1.DataSource = bSource;
                        sda.Update(dbdataset);
                        //conn.Open();
                        //MessageBox.Show("Connection Open");

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    };

                    break;
                case 3:
                    months.Text = "Mar";
                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = boef3;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bSource = new BindingSource();

                        bSource.DataSource = dbdataset;
                        dataGridView1.DataSource = bSource;
                        sda.Update(dbdataset);
                        //conn.Open();
                        //MessageBox.Show("Connection Open");

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    };
                    break;
                case 4:
                    months.Text = "Apr";
                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = boef4;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bSource = new BindingSource();

                        bSource.DataSource = dbdataset;
                        dataGridView1.DataSource = bSource;
                        sda.Update(dbdataset);
                        //conn.Open();
                        //MessageBox.Show("Connection Open");

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    };
                    break;
                case 5:
                    months.Text = "Mei";
                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = boef5;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bSource = new BindingSource();

                        bSource.DataSource = dbdataset;
                        dataGridView1.DataSource = bSource;
                        sda.Update(dbdataset);
                        //conn.Open();
                        //MessageBox.Show("Connection Open");

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    };
                    break;
                case 6:
                    months.Text = "Jun";
                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = boef6;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bSource = new BindingSource();

                        bSource.DataSource = dbdataset;
                        dataGridView1.DataSource = bSource;
                        sda.Update(dbdataset);
                        //conn.Open();
                        //MessageBox.Show("Connection Open");

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    };
                    break;
                case 7:
                    months.Text = "Jul";
                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = boef7;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bSource = new BindingSource();

                        bSource.DataSource = dbdataset;
                        dataGridView1.DataSource = bSource;
                        sda.Update(dbdataset);
                        //conn.Open();
                        //MessageBox.Show("Connection Open");

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    };
                    break;
                case 8:
                    months.Text = "Aug";
                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = boef8;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bSource = new BindingSource();

                        bSource.DataSource = dbdataset;
                        dataGridView1.DataSource = bSource;
                        sda.Update(dbdataset);
                        //conn.Open();
                        //MessageBox.Show("Connection Open");

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    };
                    break;
                case 9:
                    months.Text = "Sep";
                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = boef9;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bSource = new BindingSource();

                        bSource.DataSource = dbdataset;
                        dataGridView1.DataSource = bSource;
                        sda.Update(dbdataset);
                        //conn.Open();
                        //MessageBox.Show("Connection Open");

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    };
                    break;
                case 10:
                    months.Text = "Okt";
                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = boef10;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bSource = new BindingSource();

                        bSource.DataSource = dbdataset;
                        dataGridView1.DataSource = bSource;
                        sda.Update(dbdataset);
                        //conn.Open();
                        //MessageBox.Show("Connection Open");

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    };
                    break;
                case 11:
                    months.Text = "Nov";
                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = boef11;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bSource = new BindingSource();

                        bSource.DataSource = dbdataset;
                        dataGridView1.DataSource = bSource;
                        sda.Update(dbdataset);
                        //conn.Open();
                        //MessageBox.Show("Connection Open");

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    };
                    break;
                default:
                    months.Text = "Dec";
                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = boef12;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        BindingSource bSource = new BindingSource();

                        bSource.DataSource = dbdataset;
                        dataGridView1.DataSource = bSource;
                        sda.Update(dbdataset);
                        //conn.Open();
                        //MessageBox.Show("Connection Open");

                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    };
                    break;
            }
                
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

            Form3 form = new Form3();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            String connectionString = "Data Source=DESKTOP-IJQTUQ2\\SQLEXPRESS;Initial Catalog=Festival;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            SqlCommand festival = new SqlCommand("SELECT Artiest, Festival, Locatie, Datum FROM dbo.Boef WHERE EXISTS(SELECT Festival, Datum FROM dbo.datafestival WHERE dbo.datafestival.Festival = dbo.Boef.Festival); ; ", conn);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = festival;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
                //conn.Open();
                //MessageBox.Show("Connection Open");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Spotify.Series["Spotify"].Points.Add(1411569);
            Spotify.Series["Spotify"].Points[0].Color = Color.Red;
            Spotify.Series["Spotify"].Points[0].AxisLabel = "Januari";
            Spotify.Series["Spotify"].Points[0].Label = "1411569";

            Spotify.Series["Spotify"].Points.Add(1189728);
            Spotify.Series["Spotify"].Points[1].Color = Color.Red;
            Spotify.Series["Spotify"].Points[1].AxisLabel = "Februari";
            Spotify.Series["Spotify"].Points[1].Label = "1189728";

            Spotify.Series["Spotify"].Points.Add(42765615);
            Spotify.Series["Spotify"].Points[2].Color = Color.Green;
            Spotify.Series["Spotify"].Points[2].AxisLabel = "Maart";
            Spotify.Series["Spotify"].Points[2].Label = "42765615";

            Spotify.Series["Spotify"].Points.Add(34336932);
            Spotify.Series["Spotify"].Points[3].Color = Color.Green;
            Spotify.Series["Spotify"].Points[3].AxisLabel = "April";
            Spotify.Series["Spotify"].Points[3].Label = "34336932";

            Spotify.Series["Spotify"].Points.Add(14210676);
            Spotify.Series["Spotify"].Points[4].Color = Color.Green;
            Spotify.Series["Spotify"].Points[4].AxisLabel = "Mei";
            Spotify.Series["Spotify"].Points[4].Label = "14210676";

            Spotify.Series["Spotify"].Points.Add(8947547);
            Spotify.Series["Spotify"].Points[5].Color = Color.Red;
            Spotify.Series["Spotify"].Points[5].AxisLabel = "Juni";
            Spotify.Series["Spotify"].Points[5].Label = "8947547";

            Spotify.Series["Spotify"].Points.Add(6092501);
            Spotify.Series["Spotify"].Points[6].Color = Color.Red;
            Spotify.Series["Spotify"].Points[6].AxisLabel = "Juli";
            Spotify.Series["Spotify"].Points[6].Label = "6092501";

            Spotify.Series["Spotify"].Points.Add(4042745);
            Spotify.Series["Spotify"].Points[7].Color = Color.Red;
            Spotify.Series["Spotify"].Points[7].AxisLabel = "Augustus";
            Spotify.Series["Spotify"].Points[7].Label = "4042745";

            Spotify.Series["Spotify"].Points.Add(3341391);
            Spotify.Series["Spotify"].Points[8].Color = Color.Red;
            Spotify.Series["Spotify"].Points[8].AxisLabel = "September";
            Spotify.Series["Spotify"].Points[8].Label = "3341391";

            Spotify.Series["Spotify"].Points.Add(2373805);
            Spotify.Series["Spotify"].Points[9].Color = Color.Red;
            Spotify.Series["Spotify"].Points[9].AxisLabel = "Oktober";
            Spotify.Series["Spotify"].Points[9].Label = "2373805";

            Spotify.Series["Spotify"].Points.Add(1862738);
            Spotify.Series["Spotify"].Points[10].Color = Color.Red;
            Spotify.Series["Spotify"].Points[10].AxisLabel = "November";
            Spotify.Series["Spotify"].Points[10].Label = "1862738";

            Spotify.Series["Spotify"].Points.Add(3670453);
            Spotify.Series["Spotify"].Points[11].Color = Color.Red;
            Spotify.Series["Spotify"].Points[11].AxisLabel = "December";
            Spotify.Series["Spotify"].Points[11].Label = "3670453";
            //Spotify.Series["Spotify"].Points.AddXY("Januari", 1411569);
            //Spotify.Series["Spotify"].Points.AddXY("Februari", 1189728);
            //Spotify.Series["Spotify"].Points.AddXY("Maart", 42765615);
            //Spotify.Series["Spotify"].Points.AddXY("April", 34336932);
            //Spotify.Series["Spotify"].Points.AddXY("Mei", 14210676);
            //Spotify.Series["Spotify"].Points.AddXY("Juni", 8947547);
            //Spotify.Series["Spotify"].Points.AddXY("Juli", 6092501);
            //Spotify.Series["Spotify"].Points.AddXY("Augustus", 4042745);
            //Spotify.Series["Spotify"].Points.AddXY("September", 3341391);
            //Spotify.Series["Spotify"].Points.AddXY("Oktober", 2373805);
            //Spotify.Series["Spotify"].Points.AddXY("November", 1862738);
            //Spotify.Series["Spotify"].Points.AddXY("December", 3670453);
        }

        private void Spotify_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            String connectionString = "Data Source=DESKTOP-IJQTUQ2\\SQLEXPRESS;Initial Catalog=Festival;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            SqlCommand festival = new SqlCommand("SELECT Artiest, Festival, Locatie, Datum FROM dbo.Boef WHERE EXISTS(SELECT Festival, Datum FROM dbo.datafestival WHERE dbo.datafestival.Festival = dbo.Boef.Festival); ; ", conn);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = festival;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
                //conn.Open();
                //MessageBox.Show("Connection Open");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Spotify.Series["Spotify"].Points.Add(1411569);
            Spotify.Series["Spotify"].Points[0].Color = Color.Red;
            Spotify.Series["Spotify"].Points[0].AxisLabel = "Januari";
            Spotify.Series["Spotify"].Points[0].Label = "1411569";

            Spotify.Series["Spotify"].Points.Add(1189728);
            Spotify.Series["Spotify"].Points[1].Color = Color.Red;
            Spotify.Series["Spotify"].Points[1].AxisLabel = "Februari";
            Spotify.Series["Spotify"].Points[1].Label = "1189728";

            Spotify.Series["Spotify"].Points.Add(42765615);
            Spotify.Series["Spotify"].Points[2].Color = Color.Green;
            Spotify.Series["Spotify"].Points[2].AxisLabel = "Maart";
            Spotify.Series["Spotify"].Points[2].Label = "42765615";

            Spotify.Series["Spotify"].Points.Add(34336932);
            Spotify.Series["Spotify"].Points[3].Color = Color.Green;
            Spotify.Series["Spotify"].Points[3].AxisLabel = "April";
            Spotify.Series["Spotify"].Points[3].Label = "34336932";

            Spotify.Series["Spotify"].Points.Add(14210676);
            Spotify.Series["Spotify"].Points[4].Color = Color.Green;
            Spotify.Series["Spotify"].Points[4].AxisLabel = "Mei";
            Spotify.Series["Spotify"].Points[4].Label = "14210676";

            Spotify.Series["Spotify"].Points.Add(8947547);
            Spotify.Series["Spotify"].Points[5].Color = Color.Red;
            Spotify.Series["Spotify"].Points[5].AxisLabel = "Juni";
            Spotify.Series["Spotify"].Points[5].Label = "8947547";

            Spotify.Series["Spotify"].Points.Add(6092501);
            Spotify.Series["Spotify"].Points[6].Color = Color.Red;
            Spotify.Series["Spotify"].Points[6].AxisLabel = "Juli";
            Spotify.Series["Spotify"].Points[6].Label = "6092501";

            Spotify.Series["Spotify"].Points.Add(4042745);
            Spotify.Series["Spotify"].Points[7].Color = Color.Red;
            Spotify.Series["Spotify"].Points[7].AxisLabel = "Augustus";
            Spotify.Series["Spotify"].Points[7].Label = "4042745";

            Spotify.Series["Spotify"].Points.Add(3341391);
            Spotify.Series["Spotify"].Points[8].Color = Color.Red;
            Spotify.Series["Spotify"].Points[8].AxisLabel = "September";
            Spotify.Series["Spotify"].Points[8].Label = "3341391";

            Spotify.Series["Spotify"].Points.Add(2373805);
            Spotify.Series["Spotify"].Points[9].Color = Color.Red;
            Spotify.Series["Spotify"].Points[9].AxisLabel = "Oktober";
            Spotify.Series["Spotify"].Points[9].Label = "2373805";

            Spotify.Series["Spotify"].Points.Add(1862738);
            Spotify.Series["Spotify"].Points[10].Color = Color.Red;
            Spotify.Series["Spotify"].Points[10].AxisLabel = "November";
            Spotify.Series["Spotify"].Points[10].Label = "1862738";

            Spotify.Series["Spotify"].Points.Add(3670453);
            Spotify.Series["Spotify"].Points[11].Color = Color.Red;
            Spotify.Series["Spotify"].Points[11].AxisLabel = "December";
            Spotify.Series["Spotify"].Points[11].Label = "3670453";
            //Spotify.Series["Spotify"].Points.AddXY("Januari", 1411569);
            //Spotify.Series["Spotify"].Points.AddXY("Februari", 1189728);
            //Spotify.Series["Spotify"].Points.AddXY("Maart", 42765615);
            //Spotify.Series["Spotify"].Points.AddXY("April", 34336932);
            //Spotify.Series["Spotify"].Points.AddXY("Mei", 14210676);
            //Spotify.Series["Spotify"].Points.AddXY("Juni", 8947547);
            //Spotify.Series["Spotify"].Points.AddXY("Juli", 6092501);
            //Spotify.Series["Spotify"].Points.AddXY("Augustus", 4042745);
            //Spotify.Series["Spotify"].Points.AddXY("September", 3341391);
            //Spotify.Series["Spotify"].Points.AddXY("Oktober", 2373805);
            //Spotify.Series["Spotify"].Points.AddXY("November", 1862738);
            //Spotify.Series["Spotify"].Points.AddXY("December", 3670453);
        }
    }
}
