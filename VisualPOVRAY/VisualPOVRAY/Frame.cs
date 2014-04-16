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

        public Frame(Camera cam)
        {
            this.frameCount = 0;
            this.color = "Black";
            this.world = new List<PovObj>();
            this.world.Add(cam);
        }

        public Frame(Camera cam, String color)
        {
            this.frameCount = 0;
            this.color = color;
            this.world = new List<PovObj>();
            this.world.Add(cam);
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
            string strCmdText;
            strCmdText = "/EXIT /RENDER \"frame" + this.frameCount + ".pov" + "\"";
            Console.WriteLine(strCmdText);
            //System.Diagnostics.Process.Start("C:\\Program Files\\POV-Ray\\v3.7\\bin\\pvengine32-sse2.exe", strCmdText);
        }
    }
}
