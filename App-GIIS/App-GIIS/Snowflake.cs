using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace App_GIIS
{
    class Snowflake
    {
        public Point Coordinate { set; get; }
        public Color Color { private set; get; }
        public Point Speed { private set; get; }
        public int Health { private set; get; }
        public int Size { private set; get; }
        private int earth;
        private Random random = new Random();
        public Snowflake(Point startCoordinate, Color color, int size, int earth)
        {
            this.Coordinate = startCoordinate;
            this.Color = color;
            this.Size = size;
            this.Health = random.Next(0, 800);
            this.Speed = new Point(3, 2);
            this.earth = earth - size;
        }
        public void Move()
        {
            if (Coordinate.Y < earth && Health > 0)
            {
                Speed = new Point(random.Next(-3, 3), 2);
                Coordinate = new Point(Coordinate.X + Speed.X, Coordinate.Y + Speed.Y);
                Health--;
            }
            else if(Coordinate.Y >= earth)
            {
                Health--;
                Coordinate = new Point(Coordinate.X, earth);
            }
            else Speed = new Point(0, 0);
        }
    }
}