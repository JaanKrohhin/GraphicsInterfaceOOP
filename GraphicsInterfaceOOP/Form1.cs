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
            listView1.Items.Clear();
            //textA.Text = textB.Text = textC.Text = textH.Text = "0";
            double a, b, c;
            if (textB.Text=="" || textA.Text=="" || textC.Text=="")
            {
                a = b = c = 0;
            }
            else
            {
                a = Convert.ToDouble(textA.Text); 
                b = Convert.ToDouble(textB.Text);
                c = Convert.ToDouble(textC.Text);
            }
            Triangle triangle = new Triangle(a,b,c);
            listView1.Items.Add("Side A");
            listView1.Items.Add("Side B");
            listView1.Items.Add("Side C");
            listView1.Items.Add("Perimeter");
            listView1.Items.Add("Surface Area");
            listView1.Items.Add("Existense?");
            listView1.Items.Add("Equal Triangle?");
            listView1.Items[0].SubItems.Add(triangle.output(triangle.a));
            listView1.Items[1].SubItems.Add(triangle.output(triangle.b));
            listView1.Items[2].SubItems.Add(triangle.output(triangle.c));
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriange) { listView1.Items[6].SubItems.Add("Exists"); }
            else listView1.Items[5].SubItems.Add("Doesn't exist");
            if (triangle.EqualTriangle){ listView1.Items[6].SubItems.Add("Yes"); }
            else listView1.Items[6].SubItems.Add("No");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
