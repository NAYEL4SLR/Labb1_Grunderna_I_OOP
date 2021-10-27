using System;

namespace Labb1_Grunderna_I_OOP
{
    class Program
    {
        class Circile
        {
            protected float _pi = 3.141f;
            protected float Radius { get; set; }
            public Circile(float radius)
            {
                Radius = radius;
            }
            public virtual float GetArea()
            {
                float area = Radius * Radius * _pi;
                return area;
            }
        }
        class Ball : Circile
        {
            public Ball(float radius) : base(radius)
            {

            }
            public override float GetArea()
            {
                float area = 4 * Radius * Radius * _pi;
                return area;
            }
            public float GetVolume()
            {
                float volume = (4 / 3f) * _pi * Radius * Radius * Radius;
                return volume;
            }
        }
        class Triangle
        {
            protected float _pi = 3.141f;
            protected float Base { get; set; }
            protected float Hight { get; set; }
            public Triangle(float _base, float hight )
            {
                Base = _base;
                Hight = hight;

            }
            public virtual float GetArea()
            {
                float area = (Hight * Base) / 2;
                return area;
            }
        }
        static void Main(string[] args)
        {
            Circile Circle_1 = new Circile(5);
            Circile Circle_2 = new Circile(6);
            Ball ball_1 = new Ball(5);
            Ball ball_2 = new Ball(6);
            Triangle triangle_1 = new Triangle(5, 5);
            Triangle triangle_2 = new Triangle(6, 6);

            Console.WriteLine(
                $"\n\n\tFörsta cirkelns area:\t{Circle_1.GetArea()}" +
                $"\n\n\tAndra cirkelns area:\t{Circle_2.GetArea()} ");
            Console.WriteLine( 
                $"\n\n\n\tFörsta boll:\t[area] {ball_1.GetArea()}" +
                $"\t[Volume]  { ball_1.GetVolume()} "+
                $"\n\n\tAndra boll:\t[area]{ball_2.GetArea()} " +
                $"\t[Volume]  { ball_2.GetVolume()} ");
            Console.WriteLine(
                $"\n\n\tFörsta triangelns area [h = 5 & b = 5]:" +
                $"\t{triangle_1.GetArea()}" +
                $"\n\n\tAndra triangelns area [h = 6 & b = 6]:" +
                $"\t{triangle_2.GetArea()} ");

            Console.ReadLine() ;
        }
    }
}
