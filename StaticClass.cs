

namespace CsharpIntro
{
    public class StaticClass
    {
        static float pi;
        int radius;

        static StaticClass()
        {
            Console.WriteLine( "static constructor");
            StaticClass.pi = 3.141f;
        }
        public StaticClass(int r)
        {
            Console.WriteLine("instace constructor");
            this.radius = r;
        }

        public float CalculateArea ()
        {
            return pi * this.radius  * this.radius;
        }
    }

}
