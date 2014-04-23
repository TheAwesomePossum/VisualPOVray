using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VisualPOVRAY
{
    class Frame
    {

        private List<PovObj> world;
        private List<String> includes = new List<string>();
        private int frameCount;
        private string color;
        private bool animated;

        public Frame(Camera cam, String color = "Black", bool animated = false)
        {
            this.frameCount = 0;
            this.color = color;
            this.world = new List<PovObj>();
            this.world.Add(cam);
            this.animated = animated;
        }

        public void addInclude(String include)
        {
            this.includes.Add(include);
        }

        public void add(PovObj o)
        {
            world.Add(o);
        }

        public int getFrame()
        {
            return this.frameCount;
        }

        public void remove(PovObj o)
        {
            world.Remove(o);
        }

        public void render()
        {
            this.frameCount++;
            StreamWriter write = new StreamWriter("frame" + this.frameCount + ".pov");
            foreach (String s in this.includes)
            {
                write.WriteLine("#include \"" + s + "\"");
            }
            foreach (PovObj o in world)
            {
                foreach (string line in o.render())
                {
                    write.WriteLine("    " + line);
                }
            }
            write.Close();
            if (animated)
            {
                write = new StreamWriter("animation.ini");
                write.WriteLine("Antialias=Off");
                write.WriteLine("Antialias_Threshold=0.1");
                write.WriteLine("Antialias_Depth=2");
                write.WriteLine("Input_File_Name=\"frame" + this.frameCount + ".pov\"");
                write.WriteLine("Initial_Frame=1");
                write.WriteLine("Final_Frame=10");
                write.WriteLine("Initial_Clock=0");
                write.WriteLine("Final_Clock=1");
                write.WriteLine("Cyclic_Animation=on");
                write.WriteLine("Pause_when_Done=off");
                write.Close();
            }
            string strCmdText;
            if (animated)
            {
                strCmdText = "/RENDER \"animation.ini" + "\"";
            }
            else
            {
                strCmdText = "/RENDER \"frame" + this.frameCount + ".pov" + "\"";
            }
            Console.WriteLine(strCmdText);
            //System.Diagnostics.Process.Start("C:\\Program Files\\POV-Ray\\v3.7\\bin\\pvengine32-sse2.exe", strCmdText);
        }
    }
}
