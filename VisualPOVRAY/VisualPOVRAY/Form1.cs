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
using f = VisualPOVRAY.Factory;

namespace VisualPOVRAY
{
    public partial class Form1 : Form
    {

        Camera cam;
        Frame frame;
        Sphere s;
        Light l;

        public Form1()
        {
            InitializeComponent();
            cam = new Camera(new Point3(0, 2, -3), new Point3(0, 1, 2));
            frame = new Frame(cam, "Cyan");
            frame.addInclude("colors.inc");
            l = Light.pointLight(new Point3(2, 4, -3));
            frame.add(l);
            Event e = f.event1(3, eve);
            frame.addEvent(e);
            frame.addEvent(f.event1(2, add));
            frame.add(f.sphere(f.p3(0, 1, 2, reactive: true), rrad: f.integral(f.lift0(1f), 3), reactive: true));
            frame.start(30, 2.2);
        }

        public void add()
        {
            frame.add(new Sphere(new Point3(0,0,0)));
        }

        public void eve()
        {
            frame.remove(l);
            frame.add(Light.cylindricalLight(new Point3(2, 4, -3)));
        }

        private void renderBox_Paint(object sender, PaintEventArgs e)
        {
            //Console.WriteLine("repaint" + f.getFrame());
            try
            {
                Image i = Image.FromFile("frame" + frame.getFrame() + ".png");
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
            frame.render();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            renderBox.Refresh();
        }
    }
}
