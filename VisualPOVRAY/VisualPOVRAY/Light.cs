using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{

    public class Light : PovObj
    {
        public Point3 loc, color;
        public String type;
        public Boolean shadows, interaction, atmosphere;
        public float fadeDist, fadePower;
        private Light(Point3 loc, Point3 color, float fadeDist, float fadePower, Boolean shadows, Boolean interaction, Boolean atmosphere, String type = " ")
        {
            this.loc = loc;
            this.color = color ?? new Point3(1,1,1);
            this.type = type;
            this.fadeDist = fadeDist;
            this.fadePower = fadePower;
        }

        public void move(Point3 loc)
        {
            this.loc = loc;
        }

        public virtual List<string> render()
        {
            List<string> l = new List<string>();
            l.Add("light_source {");
            l.Add("    " + this.loc.render()[0] + " , rgb " + this.color.render()[0]);
            l.Add("    " + type);
            l.Add("    " + "fade_distance " + fadeDist);
            l.Add("    " + "fade_power " + fadePower);
            if (shadows)
            {
                l.Add("    " + "shadowless");
            }
            if (!interaction)
            {
                l.Add("    " + "media_interaction on");
            }
            else
            {
                l.Add("    " + "media_interaction off");
            }
            if (atmosphere)
            {
                l.Add("    " + "media_attenuation on");
            }
            else
            {
                l.Add("    " + "media_attenuation off");
            }
            l.Add("}");
            return l;
        }

        public override string ToString()
        {
            return this.type;
        }

        private class AreaLight : Light
        {
            public int width, height, widthLight, heightLight;

            public AreaLight(Point3 loc, Point3 color, int width, int height, int widthLight, int heightLight, float fadeDist, float fadePower, Boolean shadows, Boolean interaction, Boolean atmosphere)
                : base(loc, color, fadeDist, fadePower, shadows, interaction, atmosphere, type: "area_Light")
            {
                this.width = width;
                this.height = height;
                this.widthLight = widthLight;
                this.heightLight = heightLight;
            }
            public override List<string> render()
            {
                List<string> l = base.render();
                l.Insert(3, "    " + width + "," + height + "," + widthLight + "," + heightLight);
                return l;
            }
        }

        public static Light pointLight(Point3 loc, Point3 color = null, float fadeDist = 1.0f, float fadePower = 1.0f, Boolean shadows = true, Boolean interaction = true, Boolean atmosphere = false)
        {
            return new Light(loc, color, fadeDist, fadePower, shadows, interaction, atmosphere, "");
        }
        public static Light parallelLight(Point3 loc, Point3 color = null, float fadeDist = 1.0f, float fadePower = 1.0f, Boolean shadows = true, Boolean interaction = true, Boolean atmosphere = false)
        {
            return new Light(loc, color, fadeDist, fadePower, shadows, interaction, atmosphere, "parallel");
        }
        public static Light spotLight(Point3 loc, Point3 color = null, float fadeDist = 1.0f, float fadePower = 1.0f, Boolean shadows = true, Boolean interaction = true, Boolean atmosphere = false)
        {
            return new Light(loc, color, fadeDist, fadePower, shadows, interaction, atmosphere, "spotlight");
        }
        public static Light cylindricalLight(Point3 loc, Point3 color = null, float fadeDist = 1.0f, float fadePower = 1.0f, Boolean shadows = true, Boolean interaction = true, Boolean atmosphere = false)
        {
            return new Light(loc, color, fadeDist, fadePower, shadows, interaction, atmosphere, "cylinder");
        }
        public static Light areaLight(Point3 loc, int width, int height, int widthLight, int heightLight, Point3 color = null, float fadeDist = 1.0f, float fadePower = 1.0f, Boolean shadows = true, Boolean interaction = true, Boolean atmosphere = false)
        {
            return new AreaLight(loc, color, width, height, widthLight, heightLight, fadeDist, fadePower, shadows, interaction, atmosphere);
        }

        public void update(float time)
        {
            
        }
    }
}
