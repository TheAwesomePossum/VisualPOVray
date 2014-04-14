using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VisualPOVray
{
    public partial class Form1 : Form
    {

        Camera cam;
        Frame f;
        Sphere s;
        Light l;
        int frame = 0;

        public Form1()
        {
            InitializeComponent();
            cam = new Camera(new Point3(0, 2, -3), new Point3(0, 1, 2));
            f = new Frame(cam, "Cyan");
            s = new Sphere(new Point3(0, 1, 2), 2, "Yellow");
            l = new Light(new Point3(2, 4, -3));
            f.add(s);
            f.add(l);
        }

        private void renderBox_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("repaint" + f.getFrame());
            try
            {
                Image i = Image.FromFile("frame" + f.getFrame() + ".png");
                renderBox.Size = i.Size;
                e.Graphics.DrawImage(i, 0, 0);
            }
            catch (FileNotFoundException ex)
            {
                
            }
        }

        private void lightBar_Scroll(object sender, EventArgs e)
        {
            l.loc.y = lightBar.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.render();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            renderBox.Refresh();
        }
    }
}
