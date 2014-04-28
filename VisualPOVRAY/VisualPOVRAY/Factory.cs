using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualPOVRAY
{
    static class Factory
    {
        //Reactive Signals
        public static Point2 p2(Signal<float> xs, Signal<float> ys)
        {
            return new Point2(xs, ys);
        }

        public static Point2 p2(float x, float y, bool reactive = false)
        {
            return new Point2(x, y, reactive: reactive);
        }

        public static Point3 p3(Signal<float> xs, Signal<float> ys, Signal<float> zs)
        {
            return new Point3(xs, ys, zs);
        }

        public static Point3 p3(float x, float y, float z, bool reactive = false)
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

        public static Liftf integral(Signal<float> value, int initValue = 0)
        {
            return new Liftf(value, integral, initValue);
        }
        private static float integral(float currentTime, float currentValue, Signal<float> value)
        {
            return currentValue + value.now(currentTime) * currentTime;
        }

        //Simple Reactive Objects
        public static Sphere sphere(Point3 location = null, float radius = 1.0f, Signal<float> rrad = null, Point3 translate = null, Point3 rotation = null, PovTexture texture = null, bool reactive = false)
        {
            return new Sphere(location, radius, rrad, translate, rotation, texture, reactive);
        }

        public static Box box(Point3 lowerleftcorner = null, Point3 upperrightcorner = null, Point3 translate = null, Point3 rotation = null, PovTexture texture = null, bool reactive = false)
        {
            return new Box(lowerleftcorner, upperrightcorner, translate, rotation, texture, reactive);
        }

        public static Cone cone(Point3 bottompoint = null, float bottomradius = 1.0f, Point3 toppoint = null, float topradius = 0.0f, Point3 translate = null, Point3 rotation = null, PovTexture texture = null)
        {
            return new Cone(bottompoint, bottomradius, toppoint, topradius, translate, rotation, texture);
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

        public static Merge merge(PovObj o1, PovObj o2, bool reactive = false)
        {
            return new Merge(o1, o2, reactive);
        }

        public static Merge merge(PovObj o1, PovObj[] o2, bool reactive = false)
        {
            return new Merge(o1, o2, reactive);
        }

        public static Union union(PovObj o1, PovObj o2, bool reactive = false)
        {
            return new Union(o1, o2, reactive);
        }

        public static Union union(PovObj o1, PovObj[] o2, bool reactive = false)
        {
            return new Union(o1, o2, reactive);
        }

        public static Difference diff(PovObj o1, PovObj o2, bool reactive = false)
        {
            return new Difference(o1, o2, reactive);
        }

        public static Difference diff(PovObj o1, PovObj[] o2, bool reactive = false)
        {
            return new Difference(o1, o2, reactive);
        }

        public static Intersection Intersect(PovObj o1, PovObj o2, bool reactive = false)
        {
            return new Intersection(o1, o2, reactive);
        }

        public static Intersection Intersect(PovObj o1, PovObj[] o2, bool reactive = false)
        {
            return new Intersection(o1, o2, reactive);
        }

        //Events
        public static Event event1(int time, Event.EventFunc func)
        {
            return new Event(time, func);
        }
    }
}
