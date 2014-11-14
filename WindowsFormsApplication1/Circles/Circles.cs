using Ellipses;
using Figures;
using System;

namespace Circles
{
    public class Circle : Ellipse
    {
        public Circle(PointStruct centerPoint, PointStruct endPoint)
        {
            StartPoint = centerPoint;
            setCircleParameters(endPoint);
        }

        public void setCircleParameters(PointStruct endPoint)
        {
            Radius = Math.Sqrt(Math.Pow(endPoint.x - StartPoint.x, 2) + Math.Pow(endPoint.y - StartPoint.y, 2));
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                PointStruct endPoint;
                endPoint.x = StartPoint.x + (int)radius;
                endPoint.y = StartPoint.y + (int)radius;
                setEllipseParameters(endPoint);
            }
        }

        private double radius;
    }
}
