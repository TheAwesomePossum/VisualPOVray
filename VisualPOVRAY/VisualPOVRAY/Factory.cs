using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fn = VisualPOVRAY.Functions;

namespace VisualPOVRAY
{
    static class Factory
    {
        //Reactive Signals
        public static Point2 p2(Signal<float> xs, Signal<float> ys)
        {
            return new Point2(xs, ys);
        }

        public static Point2 p2(float x, float y, bool reactive = true)
        {
            return new Point2(x, y, reactive: reactive);
        }

        public static Point3 p3(Signal<float> xs, Signal<float> ys, Signal<float> zs)
        {
            return new Point3(xs, ys, zs);
        }

        public static Point3 p3(float x, float y, float z, bool reactive = true)
        {
            return new Point3(x, y, z, reactive: reactive);
        }

        public static Lift0b lift0(bool value)
        {
            return new Lift0b(value);
        }

        public static Lift0f lift0(float value)
        {
            return new Lift0f(value);
        }

        public static Lift0s lift0(string value)
        {
            return new Lift0s(value);
        }

        public static Liftf lift(Signal<float> value, Liftf.SigUp sigUp)
        {
            return new Liftf(value, sigUp);
        }


        //Lifted Functions
        public static Liftf plus(Signal<float> value, float initalValue)
        {
            return new Liftf(value, plus, initalValue);
        }
        public static float plus(float currentTime, float currentValue, Signal<float> value)
        {
            return currentValue + value.now(currentTime);
        }

        public static Liftf integral(Signal<float> value, float initValue = 0f)
        {
            return new Liftf(value, integral, initValue);
        }
        private static float integral(float currentTime, float currentValue, Signal<float> value)
        {
            return currentValue + value.now(currentTime) * currentTime;
        }
        public static Liftf sin(Signal<float> value, float initValue = 0f)
        {
            return new Liftf(value, sin, initValue);
        }
        public static float sin(float currentTime, float currentValue, Signal<float> value)
        {
            return (float)value.now(currentTime) * (float) Math.Sin(currentTime);
        }
        public static Liftf cos(Signal<float> value, float initValue = 0f)
        {
            return new Liftf(value, cos, initValue);
        }
        public static float cos(float currentTime, float currentValue, Signal<float> value)
        {
            return (float) value.now(currentTime) * (float) Math.Cos(currentTime);
        }
        //Simple Reactive Objects
        public static Sphere sphere(Point3 location = null, float radius = 1.0f, Signal<float> rrad = null, Point3 translate = null, Point3 rotation = null, PovTexture texture = null, string finish = null, bool reactive = true)
        {
            return new Sphere(location, radius, rrad, translate, rotation, texture, finish, reactive);
        }

        public static Box box(Point3 lowerleftcorner = null, Point3 upperrightcorner = null, Point3 translate = null, Point3 rotation = null, PovTexture texture = null, string finish = null, bool reactive = true)
        {
            return new Box(lowerleftcorner, upperrightcorner, translate, rotation, texture, finish, reactive);
        }

        public static Cone cone(Point3 bottompoint = null, float bottomradius = 1.0f, Signal<float> bottomradiusr = null, Point3 toppoint = null, float topradius = 0.0f,Signal<float> topradiusr = null, Point3 translate = null, Point3 rotation = null, string finish = null, PovTexture texture = null, bool reactive =true)
        {
            return new Cone(bottompoint, bottomradius, bottomradiusr, toppoint, topradius, topradiusr, translate, rotation, texture, finish, reactive);
        }

        public static Prism prism(String spline_type, float height1, float height2, int numPoints, Point2[] p, Point3 loc = null,
                        bool reactive = false, Signal<float> rh1 = null, Signal<float> rh2 = null, Signal<float> nps = null)
        {
            return new Prism(spline_type, height1, height2, numPoints, p, loc, reactive, rh1, rh2, nps);
        }

        //Complex Reactive Objects
        public static Blob blob(float threshold = .06f, Point3 rotate = null, Point3 translate = null, List<PovObj> blob = null, bool reactive = false, Signal<float> rthresh = null)
        {
            return new Blob(threshold, rotate, translate, blob, reactive, rthresh);
        }

        public static Merge merge(PovObj o1, PovObj o2, bool reactive = true)
        {
            return new Merge(o1, o2, reactive);
        }

        public static Merge merge(PovObj o1, PovObj[] o2, bool reactive = true)
        {
            return new Merge(o1, o2, reactive);
        }

        public static Union union(PovObj o1, PovObj o2, bool reactive = true)
        {
            return new Union(o1, o2, reactive);
        }

        public static Union union(PovObj o1, PovObj[] o2, bool reactive = true)
        {
            return new Union(o1, o2, reactive);
        }

        public static Difference diff(PovObj o1, PovObj o2, bool reactive = true)
        {
            return new Difference(o1, o2, reactive);
        }

        public static Difference diff(PovObj o1, PovObj[] o2, bool reactive = true)
        {
            return new Difference(o1, o2, reactive);
        }

        public static Intersection Intersect(PovObj o1, PovObj o2, bool reactive = true)
        {
            return new Intersection(o1, o2, reactive);
        }

        public static Intersection Intersect(PovObj o1, PovObj[] o2, bool reactive = true)
        {
            return new Intersection(o1, o2, reactive);
        }

        //Events
        public static Event event1(int time, fn.EventFunc func)
        {
            return new TimedEvent(time, func);
        }
        public static Event everntfunc(fn.ReactFunc rf, fn.EventFunc func)
        {
            return new ReactEvent(rf, func);
        }
        //Textures
        public static LeopardTexture leopardTexture(String color1, String color2, String color3, float scale = .3f, Signal<float> rscale = null, float turbulence = .5f, Signal<float> rturbulence = null, bool reactive = true)
        {
            return new LeopardTexture(color1, color2, color3, scale, rscale, turbulence, rturbulence, reactive);
        }

        public static BlueSkyTexture blueSkyTexture(float turbulence = 1f, Signal<float> rturbulencee = null, bool reactive = true)
        {
            return new BlueSkyTexture(turbulence, rturbulencee, reactive);
        }

        public static MarbleTexture marbleTexture(String color1, String color2, float turbulence = 100f, Signal<float> rturbulence = null, float scale = 100f, Signal<float> rscale = null, Boolean reactive = true)
        {e
            return new MarbleTexture(color1, color2, turbulence, rturbulence, scale, rscale, reactive);
        }

        public static WaveTexture waveTexture(String color1, String color2, float scale = .1f, Signal<float> rscale = null, bool reactive = true)
        {
            return new WaveTexture(color1, color2, scale, rscale, reactive);
        }
    }
}
