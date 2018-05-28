using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using WindowsForms.Interfaces;
namespace WindowsForms
{
    public class Circle:IShape
    {
        public Point Centre { get; set; }
        public Point Edge { get; set; }
        public Color Color { get; set; }
        public int ArgbColor { get; set; }
        public string Name { get; set; }

        public Circle()
        {
            Centre = new Point();
            Edge = new Point();
            Color = Color.Red;
            Name = "Color[RED]";
    }
        public Circle(Point center, Point edge)
        {
            Centre = center;
            this.Edge = edge;
            Color = Color.Red;
            Name = "Color[RED]";
        }


        static public double calculate_distance(Point First, Point Edge)
        {
            return Math.Pow((First.X - Edge.X) * (First.X - Edge.X) + (First.Y - Edge.Y) * (First.Y - Edge.Y), 0.5);
        }

        public double radius()
        {
            return calculate_distance(Centre, Edge);
        }
        
        public Point get_corner()
        {
            return new Point(Centre.X - Convert.ToInt32((radius())), Centre.Y - Convert.ToInt32((radius())));
        }
        
        public void  Move(Point new_centre)
        {
            Point prev_center = this.Centre;
            int points_x = prev_center.X - new_centre.X;
            int points_y = prev_center.Y - new_centre.Y;
            this.Centre = new_centre;
            this.Edge = new Point(this.Edge.X - points_x, this.Edge.Y - points_y);
        }

        public void Draw(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(this.Color), this.get_corner().X, this.get_corner().Y, (float)this.radius() * 2, (float)this.radius() * 2);
        }
    }
}
