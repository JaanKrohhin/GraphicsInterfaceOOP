using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsInterfaceOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Run_Button_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(textA.Text);
            b = Convert.ToDouble(textB.Text);
            c = Convert.ToDouble(textC.Text);
            Triangle triangle = new Triangle(a, b, c);
            listView1.Items.Add("Side A");
            listView1.Items.Add("Side B");
            listView1.Items.Add("Side C");
            listView1.Items.Add("Perimeter");
            listView1.Items.Add("Surface Area");
            listView1.Items.Add("Existense");
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriange) { listView1.Items[5].SubItems.Add("Exists"); }
            else listView1.Items[5].SubItems.Add("Doesn't exist");
        }
    }
}
