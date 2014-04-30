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
            if (fadeDist != 0)
            l.Add("    " + "fade_distance " + fadeDist);
            if (fadePower != 0)
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
            if (type.Equals("area_light"))
                l.Add("    orient");
            l.Add("}");
            return l;
        }

        public override string ToString()
        {
            return this.type;
        }

        private class AreaLight : Light
        {
            public int widthLight, heightLight;
            Point3 vector1, vector2;

            public AreaLight(Point3 loc, Point3 color, Point3 vector1, Point3 vector2, int widthLight, int heightLight, float fadeDist, float fadePower, Boolean shadows, Boolean interaction, Boolean atmosphere)
                : base(loc, color, fadeDist, fadePower, shadows, interaction, atmosphere, type: "area_light")
            {
                this.vector1 = vector1;
                this.vector2 = vector2;
                this.widthLight = widthLight;
                this.heightLight = heightLight;
            }
            public override List<string> render()
            {
                List<string> l = base.render();
                l.Remove("    area_light");
                l.Insert(2, "    area_light " + vector1.render()[0] + ", " + vector2.render()[0] + "," + widthLight + "," + heightLight);
                
                return l;
            }
        }//AreaLight

        private class SpotLight : Light
        {
            public float radius, falloff, tightness;
            Point3 pointAt;

            public SpotLight(Point3 loc, Point3 color, float radius, float falloff, float tightness, Point3 pointAt, float fadeDist, float fadePower, Boolean shadows, Boolean interaction, Boolean atmosphere)
                : base(loc, color, fadeDist, fadePower, shadows, interaction, atmosphere, type: "spotlight")
            {
                this.radius = radius;
                this.falloff = falloff;
                this.tightness = tightness;
                this.pointAt = pointAt;
            }
            public override List<string> render()
            {
                List<string> l = base.render();
                if (tightness != 0f)
                    l.Insert(3, "    " + "tightness " + tightness);
                if (falloff != 0f)
                    l.Insert(3, "    " + "falloff " + falloff);
                if (radius != 0f)
                    l.Insert(3, "    " + "radius " + radius);
                if (pointAt != null)
                    l.Add("    " + "pointAt " + this.pointAt.render()[0]);
                return l;
            }
        }//SpotLight

        public static Light pointLight(Point3 loc, Point3 color = null, float fadeDist = 0.0f, float fadePower = 0.0f, Boolean shadows = true, Boolean interaction = true, Boolean atmosphere = false)
        {
            return new Light(loc, color, fadeDist, fadePower, shadows, interaction, atmosphere, "");
        }
        public static Light parallelLight(Point3 loc, Point3 color = null, float fadeDist = 0.0f, float fadePower = 0.0f, Boolean shadows = true, Boolean interaction = true, Boolean atmosphere = false)
        {
            return new Light(loc, color, fadeDist, fadePower, shadows, interaction, atmosphere, "parallel");
        }
        public static Light spotLight(Point3 loc, float radius = 0f, float falloff = 0f, float tightness = 0f, Point3 pointAt = null, Point3 color = null, float fadeDist = 0.0f, float fadePower = 0.0f, Boolean shadows = true, Boolean interaction = true, Boolean atmosphere = false)
        {
            return new SpotLight(loc, color, radius, falloff, tightness, pointAt, fadeDist, fadePower, shadows, interaction, atmosphere);
        }
        public static Light cylindricalLight(Point3 loc, Point3 color = null, float fadeDist = 0.0f, float fadePower = 0.0f, Boolean shadows = true, Boolean interaction = true, Boolean atmosphere = false)
        {
            return new Light(loc, color, fadeDist, fadePower, shadows, interaction, atmosphere, "cylinder");
        }
        public static Light areaLight(Point3 loc, Point3 vector1, Point3 vector2, int widthLight, int heightLight, Point3 color = null, float fadeDist = 0.0f, float fadePower = 0.0f, Boolean shadows = true, Boolean interaction = true, Boolean atmosphere = false)
        {
            return new AreaLight(loc, color, vector1, vector2, widthLight, heightLight, fadeDist, fadePower, shadows, interaction, atmosphere);
        }

        public void update(float time)
        {
            
        }
    }
}
