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
    public partial class Form2 : Form
    {
        public LocationStruct[] locations;

        public Form2()
        {
            InitializeComponent();
        }

        private float StringToFloat(string s)
        {
            try
            {
                return float.Parse(s);
            }
            catch
            {
                return 0;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            locations[0] = new LocationStruct(StringToFloat(textBoxX1.Text), StringToFloat(textBoxY1.Text));
            locations[1] = new LocationStruct(StringToFloat(textBoxX2.Text), StringToFloat(textBoxY2.Text));
            locations[2] = new LocationStruct(StringToFloat(textBoxX3.Text), StringToFloat(textBoxY3.Text));

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxX1.Text = locations[0].x.ToString();
            textBoxY1.Text = locations[0].y.ToString();
            textBoxX2.Text = locations[1].x.ToString();
            textBoxY2.Text = locations[1].y.ToString();
            textBoxX3.Text = locations[2].x.ToString();
            textBoxY3.Text = locations[2].y.ToString();

        }
    }
}
