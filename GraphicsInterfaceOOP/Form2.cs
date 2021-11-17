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
    public partial class Form2 : Form
    {
        bool help = true;
        public Form2()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Run_Button_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Triangle triangle;
            double a, h, b;
            int beta;
            if (help)
            {
                if (txtA.Text == "" || txtH.Text == "")
                {
                    a = h = 0;
                }
                else
                {
                    a = Convert.ToDouble(txtA.Text);
                    h = Convert.ToDouble(txtH.Text);
                }
                triangle = new Triangle(a,h);
            }
            else
            {
                if (txtA2.Text == "" || txtSin.Text == "" || txtB.Text=="")
                {
                    a = b = beta = 0;
                }
                else
                {
                    a = Convert.ToDouble(txtA2.Text);
                    b = Convert.ToDouble(txtB.Text);
                    beta = Convert.ToInt32(txtSin.Text);
                    if (!(beta<178 && beta>1))
                    {
                        beta = 0;
                    }
                }
                triangle = new Triangle(a, b, beta);
            }
            listView1.Items.Add("Surface Area");
            listView1.Items.Add("Side A");
            if (help)
            {
                listView1.Items.Add("Side H");
                listView1.Items[0].SubItems.Add(triangle.output(triangle.a));
                listView1.Items[2].SubItems.Add(triangle.output(triangle.h));
                listView1.Items[1].SubItems.Add(Convert.ToString(triangle.Surface_H()));
            }
            else
            { 
                listView1.Items.Add("Side B");
                listView1.Items.Add("beta");
                listView1.Items[0].SubItems.Add(Convert.ToString(triangle.Surface_Sin()));
                listView1.Items[1].SubItems.Add(triangle.output(triangle.a));
                listView1.Items[2].SubItems.Add(triangle.output(triangle.b));
                listView1.Items[3].SubItems.Add(triangle.output(triangle.beta));
            }
        }


        private void Switch_Click(object sender, EventArgs e)
        {
            if (help)
            {
                txtA.Enabled = false;
                txtA2.Enabled = true;
                txtH.Enabled = false;
                txtSin.Enabled = true;
                txtB.Enabled = true;
            }
            else
            {
                txtA.Enabled = true;
                txtA2.Enabled = false;
                txtB.Enabled = false;
                txtH.Enabled = true;
                txtSin.Enabled = false;
            }
            help = !help;
        }

    }
}
