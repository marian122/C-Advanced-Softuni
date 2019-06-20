using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_09._Rectangle_Intersection
{
   public class Rectangle
    {
        private string id;
        private double width;
        private double heigth;
        private double topLeftX;
        private double topLeftY;

        public Rectangle(string id, double width, double heigth, double topLeftX, double topLeftY)
        {
            this.id = id;
            this.width = width;
            this.heigth = heigth;
            this.topLeftX = topLeftX;
            this.topLeftY = topLeftY;
        }
        public string Id { get { return this.id; } }

        public bool IsThereIntersection(Rectangle rectangle)
        {
            return rectangle.topLeftX + rectangle.width >= this.topLeftX &&
                rectangle.topLeftX <= this.topLeftX + this.width &&
                rectangle.topLeftY >= this.topLeftY - this.heigth &&
                rectangle.topLeftY - rectangle.heigth <= this.topLeftY;
        }

    }
}
