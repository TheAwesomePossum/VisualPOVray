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
        public string height;
        public string width;
        public string name;
        public string type;
        public string gamma;
        public static List<String> writer1 = new List<string>();
        Camera cam;
        Frame frame;
        Sphere s;
        Light l;
        float alias;
        int quality;

        public Form1()
        {
            InitializeComponent();
            cam = new Camera(new Point3(0, 2, -3), new Point3(0, 1, 2));
            frame = new Frame(cam, "Cyan");
            frame.addInclude("colors.inc");
            l = Light.pointLight(new Point3(2, 4, -3));
            frame.add(l);
            Event e = f.event1(2, eve);
            frame.addEvent(e);
            frame.addEvent(f.event1(2, add));
            frame.add(f.sphere(f.p3(0, 1, 2, reactive: true), rrad: f.integral(f.lift0(1f), .5f), reactive: true));
            frame.start(30, 20);
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
            gammaUpdater.Text = "Gamma: " + imageGammaBar.Value / 100.0;
            alias = aliasingTrackBar.Value / 10.0f;
            aliasLabel.Text = "Alias: " + alias;
            label9.Text = "Quality: " + qualityTrackBar.Value;
            quality = qualityTrackBar.Value;
            Console.WriteLine(alias);
            renderBox.Refresh();
        }
        private void renderButt_Click(object sender, EventArgs e)
        {
            writer1.Add("width=" + imageWidthTB.Text);
            writer1.Add(Environment.NewLine);
            writer1.Add("height=" + imageHeightTB.Text);
            writer1.Add(Environment.NewLine);
            writer1.Add("Display_Gamma=" + imageGammaBar.Value / 100.0);
            writer1.Add(Environment.NewLine);
            writer1.Add("+Q" + quality);
            writer1.Add(Environment.NewLine);
            writer1.Add("Antialias=On");
            writer1.Add(Environment.NewLine);
            writer1.Add("Antialias_Threshold=" + alias);
            Point3 camLoc = new Point3((Convert.ToInt32(xPosTB.Text)), (Convert.ToInt32(yPosTB.Text)), (Convert.ToInt32(zPosTB.Text)));
            Point3 camLook = new Point3((Convert.ToInt32(xDirTB.Text)), (Convert.ToInt32(yDirTB.Text)), (Convert.ToInt32(zDirTB.Text)));
            camXPosLab.Text = " " + camLoc.x;
            camYPosLab.Text = " " + camLoc.y;
            camZPosLab.Text = " " + camLoc.z;
            camXDirLab.Text = " " + camLook.x;
            camXDirLab.Text = " " + camLook.y;
            camXDirLab.Text = " " + camLook.z;
            frame.remove(cam);
            cam = new Camera(location: camLoc, look_at: camLook);
            frame.add(cam);
            frame.render();
        }

        private void imageHeightTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void imageWidthTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void imageQualityTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
    }
}
