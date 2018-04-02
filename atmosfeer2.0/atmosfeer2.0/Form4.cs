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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            String connectionString = "Data Source=DESKTOP-IJQTUQ2\\SQLEXPRESS;Initial Catalog=Festival;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            SqlCommand festival = new SqlCommand("SELECT Artiest, Festival, Locatie, Datum FROM dbo.lilkleine$ WHERE EXISTS(SELECT Festival, Datum FROM dbo.datafestival WHERE dbo.datafestival.Festival = dbo.lilkleine$.Festival); ; ", conn);

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

        private void button2_Click(object sender, EventArgs e)
        {
            Spotify.Series["Spotify"].Points.Add(0);
            Spotify.Series["Spotify"].Points[0].Color = Color.Red;
            Spotify.Series["Spotify"].Points[0].AxisLabel = "Januari";
            Spotify.Series["Spotify"].Points[0].Label = "0";

            Spotify.Series["Spotify"].Points.Add(420405);
            Spotify.Series["Spotify"].Points[1].Color = Color.Red;
            Spotify.Series["Spotify"].Points[1].AxisLabel = "Februari";
            Spotify.Series["Spotify"].Points[1].Label = "420405";

            Spotify.Series["Spotify"].Points.Add(1451224);
            Spotify.Series["Spotify"].Points[2].Color = Color.Red;
            Spotify.Series["Spotify"].Points[2].AxisLabel = "Maart";
            Spotify.Series["Spotify"].Points[2].Label = "1451224";

            Spotify.Series["Spotify"].Points.Add(4370507);
            Spotify.Series["Spotify"].Points[3].Color = Color.Red;
            Spotify.Series["Spotify"].Points[3].AxisLabel = "April";
            Spotify.Series["Spotify"].Points[3].Label = "4370507";

            Spotify.Series["Spotify"].Points.Add(14115965);
            Spotify.Series["Spotify"].Points[4].Color = Color.Red;
            Spotify.Series["Spotify"].Points[4].AxisLabel = "Mei";
            Spotify.Series["Spotify"].Points[4].Label = "14115965";

            Spotify.Series["Spotify"].Points.Add(43750193);
            Spotify.Series["Spotify"].Points[5].Color = Color.Green;
            Spotify.Series["Spotify"].Points[5].AxisLabel = "Juni";
            Spotify.Series["Spotify"].Points[5].Label = "43750193";

            Spotify.Series["Spotify"].Points.Add(36477691);
            Spotify.Series["Spotify"].Points[6].Color = Color.Green;
            Spotify.Series["Spotify"].Points[6].AxisLabel = "Juli";
            Spotify.Series["Spotify"].Points[6].Label = "36477691";

            Spotify.Series["Spotify"].Points.Add(22468329);
            Spotify.Series["Spotify"].Points[7].Color = Color.Green;
            Spotify.Series["Spotify"].Points[7].AxisLabel = "Augustus";
            Spotify.Series["Spotify"].Points[7].Label = "22468329";

            Spotify.Series["Spotify"].Points.Add(16072437);
            Spotify.Series["Spotify"].Points[8].Color = Color.Red;
            Spotify.Series["Spotify"].Points[8].AxisLabel = "September";
            Spotify.Series["Spotify"].Points[8].Label = "16072437";

            Spotify.Series["Spotify"].Points.Add(12437964);
            Spotify.Series["Spotify"].Points[9].Color = Color.Red;
            Spotify.Series["Spotify"].Points[9].AxisLabel = "Oktober";
            Spotify.Series["Spotify"].Points[9].Label = "12437964";

            Spotify.Series["Spotify"].Points.Add(10766542);
            Spotify.Series["Spotify"].Points[10].Color = Color.Red;
            Spotify.Series["Spotify"].Points[10].AxisLabel = "November";
            Spotify.Series["Spotify"].Points[10].Label = "10766542";

            Spotify.Series["Spotify"].Points.Add(8287419);
            Spotify.Series["Spotify"].Points[11].Color = Color.Red;
            Spotify.Series["Spotify"].Points[11].AxisLabel = "December";
            Spotify.Series["Spotify"].Points[11].Label = "8287419";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            SqlConnection conn;
            String connectionString = "Data Source=DESKTOP-IJQTUQ2\\SQLEXPRESS;Initial Catalog=Festival;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            SqlCommand kleine1 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Lil Kleine' AND Datum BETWEEN '2017-01-01' AND '2017-01-31' ORDER BY Datum; ", conn);
            SqlCommand kleine2 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Lil Kleine' AND Datum BETWEEN '2017-02-01' AND '2017-02-28' ORDER BY Datum; ", conn);
            SqlCommand kleine3 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Lil Kleine' AND Datum BETWEEN '2017-03-01' AND '2017-03-31' ORDER BY Datum; ", conn);
            SqlCommand kleine4 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Lil Kleine' AND Datum BETWEEN '2017-04-01' AND '2017-04-30' ORDER BY Datum; ", conn);
            SqlCommand kleine5 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Lil Kleine' AND Datum BETWEEN '2017-05-01' AND '2017-05-31' ORDER BY Datum; ", conn);
            SqlCommand kleine6 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Lil Kleine' AND Datum BETWEEN '2017-06-01' AND '2017-06-30' ORDER BY Datum; ", conn);
            SqlCommand kleine7 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Lil Kleine' AND Datum BETWEEN '2017-07-01' AND '2017-07-31' ORDER BY Datum; ", conn);
            SqlCommand kleine8 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Lil Kleine' AND Datum BETWEEN '2017-08-01' AND '2017-08-31' ORDER BY Datum; ", conn);
            SqlCommand kleine9 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Lil Kleine' AND Datum BETWEEN '2017-09-01' AND '2017-09-30' ORDER BY Datum; ", conn);
            SqlCommand kleine10 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Lil Kleine' AND Datum BETWEEN '2017-10-01' AND '2017-10-31' ORDER BY Datum; ", conn);
            SqlCommand kleine11 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Lil Kleine' AND Datum BETWEEN '2017-11-01' AND '2017-11-30' ORDER BY Datum; ", conn);
            SqlCommand kleine12 = new SqlCommand("SELECT Artiest, Nummer, Geluisterd, Datum FROM dbo.NLTop200 WHERE Artiest = 'Lil Kleine' AND Datum BETWEEN '2017-12-01' AND '2017-12-31' ORDER BY Datum; ", conn);

            switch (trackBar1.Value)
            {
                case 1:
                    months.Text = "Jan";
                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = kleine1;
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
                        sda.SelectCommand = kleine2;
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
                        sda.SelectCommand = kleine3;
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
                        sda.SelectCommand = kleine4;
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
                        sda.SelectCommand = kleine5;
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
                        sda.SelectCommand = kleine6;
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
                        sda.SelectCommand = kleine7;
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
                        sda.SelectCommand = kleine8;
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
                        sda.SelectCommand = kleine9;
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
                        sda.SelectCommand = kleine10;
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
                        sda.SelectCommand = kleine11;
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
                        sda.SelectCommand = kleine12;
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Spotify.Series["Spotify"].Points.Add(0);
            Spotify.Series["Spotify"].Points[0].Color = Color.Red;
            Spotify.Series["Spotify"].Points[0].AxisLabel = "Januari";
            Spotify.Series["Spotify"].Points[0].Label = "0";

            Spotify.Series["Spotify"].Points.Add(420405);
            Spotify.Series["Spotify"].Points[1].Color = Color.Red;
            Spotify.Series["Spotify"].Points[1].AxisLabel = "Februari";
            Spotify.Series["Spotify"].Points[1].Label = "420405";

            Spotify.Series["Spotify"].Points.Add(1451224);
            Spotify.Series["Spotify"].Points[2].Color = Color.Red;
            Spotify.Series["Spotify"].Points[2].AxisLabel = "Maart";
            Spotify.Series["Spotify"].Points[2].Label = "1451224";

            Spotify.Series["Spotify"].Points.Add(4370507);
            Spotify.Series["Spotify"].Points[3].Color = Color.Red;
            Spotify.Series["Spotify"].Points[3].AxisLabel = "April";
            Spotify.Series["Spotify"].Points[3].Label = "4370507";

            Spotify.Series["Spotify"].Points.Add(14115965);
            Spotify.Series["Spotify"].Points[4].Color = Color.Red;
            Spotify.Series["Spotify"].Points[4].AxisLabel = "Mei";
            Spotify.Series["Spotify"].Points[4].Label = "14115965";

            Spotify.Series["Spotify"].Points.Add(43750193);
            Spotify.Series["Spotify"].Points[5].Color = Color.Green;
            Spotify.Series["Spotify"].Points[5].AxisLabel = "Juni";
            Spotify.Series["Spotify"].Points[5].Label = "43750193";

            Spotify.Series["Spotify"].Points.Add(36477691);
            Spotify.Series["Spotify"].Points[6].Color = Color.Green;
            Spotify.Series["Spotify"].Points[6].AxisLabel = "Juli";
            Spotify.Series["Spotify"].Points[6].Label = "36477691";

            Spotify.Series["Spotify"].Points.Add(22468329);
            Spotify.Series["Spotify"].Points[7].Color = Color.Green;
            Spotify.Series["Spotify"].Points[7].AxisLabel = "Augustus";
            Spotify.Series["Spotify"].Points[7].Label = "22468329";

            Spotify.Series["Spotify"].Points.Add(16072437);
            Spotify.Series["Spotify"].Points[8].Color = Color.Red;
            Spotify.Series["Spotify"].Points[8].AxisLabel = "September";
            Spotify.Series["Spotify"].Points[8].Label = "16072437";

            Spotify.Series["Spotify"].Points.Add(12437964);
            Spotify.Series["Spotify"].Points[9].Color = Color.Red;
            Spotify.Series["Spotify"].Points[9].AxisLabel = "Oktober";
            Spotify.Series["Spotify"].Points[9].Label = "12437964";

            Spotify.Series["Spotify"].Points.Add(10766542);
            Spotify.Series["Spotify"].Points[10].Color = Color.Red;
            Spotify.Series["Spotify"].Points[10].AxisLabel = "November";
            Spotify.Series["Spotify"].Points[10].Label = "10766542";

            Spotify.Series["Spotify"].Points.Add(8287419);
            Spotify.Series["Spotify"].Points[11].Color = Color.Red;
            Spotify.Series["Spotify"].Points[11].AxisLabel = "December";
            Spotify.Series["Spotify"].Points[11].Label = "8287419";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            String connectionString = "Data Source=DESKTOP-IJQTUQ2\\SQLEXPRESS;Initial Catalog=Festival;Integrated Security=True";
            conn = new SqlConnection(connectionString);
            SqlCommand festival = new SqlCommand("SELECT Artiest, Festival, Locatie, Datum FROM dbo.lilkleine$ WHERE EXISTS(SELECT Festival, Datum FROM dbo.datafestival WHERE dbo.datafestival.Festival = dbo.lilkleine$.Festival); ; ", conn);

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

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Spotify_Click(object sender, EventArgs e)
        {

        }
    }
}
