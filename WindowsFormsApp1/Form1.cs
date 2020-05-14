using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static LocationStruct[] locations;
        static BorderLine[] borders;

        public Form1()
        {
            InitializeComponent();
            locations = new LocationStruct[3];
            borders = new BorderLine[3];
            int i;
            for( i=0; i<3; i++)
            {
                locations[i].x = 0;
                locations[i].y = 0;
            }
        }

        private void buttonSetBLE_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.locations = locations;
            if ( form.ShowDialog() == DialogResult.OK)
            {
                locations = form.locations;
                Redraw_locations();

            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Redraw_locations();
        }

        private void Redraw_locations()
        {
            // 受信位置の表示
            labelLocation1.Text = locations[0].LocationString();
            labelLocation2.Text = locations[1].LocationString();
            labelLocation3.Text = locations[2].LocationString();
            textBoxRSSI1.Text = locations[0].rssi.ToString();
            textBoxRSSI2.Text = locations[1].rssi.ToString();
            textBoxRSSI3.Text = locations[2].rssi.ToString();
        }

        private int StringToInt(string s)
        {
            try
            {
                return int.Parse(s);
            }
            catch
            {
                return 0;
            }
        }

        private void DrawMap()
        {
            var g = map.CreateGraphics();
            g.Clear(Color.White);
            int i;
            for( i=0; i<3; i++)
            {
                // 受信機の位置
                float x = locations[i].x, y = locations[i].y;
                g.FillEllipse(Brushes.Blue, x - 10, y - 10, 20, 20);
            }
            for (i = 0; i < 3; i++)
            {
                BorderLine b = borders[i];
                // 境界
                if (!b.isReady) continue;
                if (b.isLine)
                {
                    // 線
                    if (b.vy == 0)
                    {
                        // x軸に平行
                        g.DrawLine(Pens.Black, 0, b.y, map.Width, b.y);
                    }
                    else
                    {
                        float t = -b.x / b.vx;
                        float line_b = b.y + t * b.vy;   // y軸切片
                        float line_a = (b.y - line_b) / b.x;   // 傾き
                        float left_y = line_a * map.Width + line_b;
                        g.DrawLine(Pens.Black, 0, line_b, map.Width, left_y);
                    }
                }
                else
                {
                    // 円
                    g.DrawEllipse(Pens.Black, b.x - b.r, b.y - b.r, b.r * 2, b.r * 2);
                }                
            }
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            locations[0].rssi = StringToInt(textBoxRSSI1.Text);
            locations[1].rssi = StringToInt(textBoxRSSI2.Text);
            locations[2].rssi = StringToInt(textBoxRSSI3.Text);
            int i;
            for( i=0; i<3; i++)
            {
                borders[i] = new BorderLine(locations[i%3], locations[(i+1)%3]);
            }
            DrawMap();
        }
    }
}
