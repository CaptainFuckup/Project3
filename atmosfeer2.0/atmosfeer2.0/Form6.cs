using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace atmosfeer2._0
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection("Data Source=DESKTOP-IJQTUQ2\\SQLEXPRESS;Initial Catalog=Festival;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            if (comboBox1.SelectedIndex > -1)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0: //Januari
                        chart1.Titles["Title1"].Text = "Januari";
                        cmd.CommandText = "SELECT TOP (25) Spotify.artiest, Spotify.nummer, MAX(Spotify.geluisterd) AS max_geluisterd, AVG(Weather.tempmax), MAX(Weather.tempmax), MIN(Weather.tempmin), AVG(Weather.neerslag) FROM Weather, Spotify WHERE Weather.datum BETWEEN '20170101' AND '20170131' AND Spotify.datum BETWEEN '20170101' AND '20170131' GROUP BY Spotify.artiest, Spotify.nummer ORDER BY max_geluisterd DESC";
                        break;
                    case 1: //Februari
                        chart1.Titles["Title1"].Text = "Februari";
                        cmd.CommandText = "SELECT TOP (25) Spotify.artiest, Spotify.nummer, MAX(Spotify.geluisterd) AS max_geluisterd, AVG(Weather.tempmax), MAX(Weather.tempmax), MIN(Weather.tempmin), AVG(Weather.neerslag) FROM Weather, Spotify WHERE Weather.datum BETWEEN '20170201' AND '20170228' AND Spotify.datum BETWEEN '20170201' AND '20170228' GROUP BY Spotify.artiest, Spotify.nummer ORDER BY max_geluisterd DESC";
                        break;
                    case 2: //Maart
                        chart1.Titles["Title1"].Text = "Maart";
                        cmd.CommandText = "SELECT TOP (25) Spotify.artiest, Spotify.nummer, MAX(Spotify.geluisterd) AS max_geluisterd, AVG(Weather.tempmax), MAX(Weather.tempmax), MIN(Weather.tempmin), AVG(Weather.neerslag) FROM Weather, Spotify WHERE Weather.datum BETWEEN '20170301' AND '20170331' AND Spotify.datum BETWEEN '20170301' AND '20170331' GROUP BY Spotify.artiest, Spotify.nummer ORDER BY max_geluisterd DESC";
                        break;
                    case 3: //April
                        chart1.Titles["Title1"].Text = "April";
                        cmd.CommandText = "SELECT TOP (25) Spotify.artiest, Spotify.nummer, MAX(Spotify.geluisterd) AS max_geluisterd, AVG(Weather.tempmax), MAX(Weather.tempmax), MIN(Weather.tempmin), AVG(Weather.neerslag) FROM Weather, Spotify WHERE Weather.datum BETWEEN '20170401' AND '20170430' AND Spotify.datum BETWEEN '20170401' AND '20170430' GROUP BY Spotify.artiest, Spotify.nummer ORDER BY max_geluisterd DESC";
                        break;
                    case 4: //Mei
                        chart1.Titles["Title1"].Text = "Mei";
                        cmd.CommandText = "SELECT TOP (25) Spotify.artiest, Spotify.nummer, MAX(Spotify.geluisterd) AS max_geluisterd, AVG(Weather.tempmax), MAX(Weather.tempmax), MIN(Weather.tempmin), AVG(Weather.neerslag) FROM Weather, Spotify WHERE Weather.datum BETWEEN '20170501' AND '20170531' AND Spotify.datum BETWEEN '20170501' AND '20170531' GROUP BY Spotify.artiest, Spotify.nummer ORDER BY max_geluisterd DESC";
                        break;
                    case 5: //Juni
                        chart1.Titles["Title1"].Text = "Juni";
                        cmd.CommandText = "SELECT TOP (25) Spotify.artiest, Spotify.nummer, MAX(Spotify.geluisterd) AS max_geluisterd, AVG(Weather.tempmax), MAX(Weather.tempmax), MIN(Weather.tempmin), AVG(Weather.neerslag) FROM Weather, Spotify WHERE Weather.datum BETWEEN '20170601' AND '20170630' AND Spotify.datum BETWEEN '20170601' AND '20170630' GROUP BY Spotify.artiest, Spotify.nummer ORDER BY max_geluisterd DESC";
                        break;
                    case 6: //Juli
                        chart1.Titles["Title1"].Text = "Juli";
                        cmd.CommandText = "SELECT TOP (25) Spotify.artiest, Spotify.nummer, MAX(Spotify.geluisterd) AS max_geluisterd, AVG(Weather.tempmax), MAX(Weather.tempmax), MIN(Weather.tempmin), AVG(Weather.neerslag) FROM Weather, Spotify WHERE Weather.datum BETWEEN '20170701' AND '20170731' AND Spotify.datum BETWEEN '20170615' AND '20170630' GROUP BY Spotify.artiest, Spotify.nummer ORDER BY max_geluisterd DESC";
                        break;
                    case 7: //Augustus
                        chart1.Titles["Title1"].Text = "Augustus";
                        cmd.CommandText = "SELECT TOP (25) Spotify.artiest, Spotify.nummer, MAX(Spotify.geluisterd) AS max_geluisterd, AVG(Weather.tempmax), MAX(Weather.tempmax), MIN(Weather.tempmin), AVG(Weather.neerslag) FROM Weather, Spotify WHERE Weather.datum BETWEEN '20170801' AND '20170831' AND Spotify.datum BETWEEN '20170801' AND '20170831' GROUP BY Spotify.artiest, Spotify.nummer ORDER BY max_geluisterd DESC";
                        break;
                    case 8: //September
                        chart1.Titles["Title1"].Text = "September";
                        cmd.CommandText = "SELECT TOP (25) Spotify.artiest, Spotify.nummer, MAX(Spotify.geluisterd) AS max_geluisterd, AVG(Weather.tempmax), MAX(Weather.tempmax), MIN(Weather.tempmin), AVG(Weather.neerslag) FROM Weather, Spotify WHERE Weather.datum BETWEEN '20170901' AND '20170930' AND Spotify.datum BETWEEN '20170901' AND '20170930' GROUP BY Spotify.artiest, Spotify.nummer ORDER BY max_geluisterd DESC";
                        break;
                    case 9: //Oktober
                        chart1.Titles["Title1"].Text = "Oktober";
                        cmd.CommandText = "SELECT TOP (25) Spotify.artiest, Spotify.nummer, MAX(Spotify.geluisterd) AS max_geluisterd, AVG(Weather.tempmax), MAX(Weather.tempmax), MIN(Weather.tempmin), AVG(Weather.neerslag) FROM Weather, Spotify WHERE Weather.datum BETWEEN '20171001' AND '20171031' AND Spotify.datum BETWEEN '20171001' AND '20171031' GROUP BY Spotify.artiest, Spotify.nummer ORDER BY max_geluisterd DESC";
                        break;
                    case 10: //November
                        chart1.Titles["Title1"].Text = "November";
                        cmd.CommandText = "SELECT TOP (25) Spotify.artiest, Spotify.nummer, MAX(Spotify.geluisterd) AS max_geluisterd, AVG(Weather.tempmax), MAX(Weather.tempmax), MIN(Weather.tempmin), AVG(Weather.neerslag) FROM Weather, Spotify WHERE Weather.datum BETWEEN '20171101' AND '20171130' AND Spotify.datum BETWEEN '20171101' AND '20171130' GROUP BY Spotify.artiest, Spotify.nummer ORDER BY max_geluisterd DESC";
                        break;
                    case 11: //December
                        chart1.Titles["Title1"].Text = "December";
                        cmd.CommandText = "SELECT TOP (25) Spotify.artiest, Spotify.nummer, MAX(Spotify.geluisterd) AS max_geluisterd, AVG(Weather.tempmax), MAX(Weather.tempmax), MIN(Weather.tempmin), AVG(Weather.neerslag) FROM Weather, Spotify WHERE Weather.datum BETWEEN '20171201' AND '20171231' AND Spotify.datum BETWEEN '20171201' AND '20171231' GROUP BY Spotify.artiest, Spotify.nummer ORDER BY max_geluisterd DESC";
                        break;
                }
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();

                reader = cmd.ExecuteReader();

                //Chart leegmaken
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }

                //DataTable dt = new DataTable();

                //dt.Columns.Add("Artiest");
                //dt.Columns.Add("Nummer");
                //dt.Columns.Add("Geluisterd");
                //dt.Columns.Add("Gemiddelde Temperatuur");
                // Data is accessible through the DataReader object here.
                if (reader.HasRows)
                {
                    while (reader.Read() && !reader.IsDBNull(0))
                    {
                        //Console.WriteLine(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
                        //Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                        //  reader.GetString(1));
                        //dt.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
                        chart1.Series["Geluisterd"].Points.AddXY(reader.GetString(1), reader.GetInt32(2));
                        label5.Text = (reader.GetInt32(3) / 10.0).ToString() + " °C";
                        label7.Text = (reader.GetInt32(4) / 10.0).ToString() + " °C";
                        label9.Text = (reader.GetInt32(5) / 10.0).ToString() + " °C";
                        label11.Text = (reader.GetInt32(6) / 10.0).ToString() + " mm";
                        //label1.Text = (reader.GetInt32(3) / 10.0).ToString() + " °C";

                        //listView1.Items.Add(reader.GetString(0)); //Nummer
                        //listView1.Items.Add(reader.GetString(1)); //Artiest
                        //listView1.Items.Add(reader.GetInt32(2).ToString());
                        //listView1.Items.Add(reader.GetInt32(3).ToString());
                        //listView1.Columns.Add("Nummer", -2, HorizontalAlignment.Center);
                        //listView1.Columns.Add("Artiest", -2, HorizontalAlignment.Center);
                        //listView1.Columns.Add("Geluisterd", -2, HorizontalAlignment.Center);
                        //listView1.Columns.Add("Temperatuur", -2, HorizontalAlignment.Center);
                    }
                }
                //taGridView1.DataSource = dt;
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 90;
                chart1.ChartAreas[0].AxisX.Interval = 1;


            }

            sqlConnection1.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
