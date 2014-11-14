﻿using System;
using Figures;
using Ellipses;

namespace Circles
{
    public class Circle : Ellipse
    {
        public Circle()
        {
            endPointOfDiagonalForTransformToCircle.x = endPointOfDiagonalForTransformToCircle.y = 0;
            writeCircleParametersOnDiagonal(endPointOfDiagonalForTransformToCircle, endPointOfDiagonalForTransformToCircle);
        }
        public Circle(Point center, Point endPointOfDiagonal)
        {
            writeCircleParametersOnDiagonal(center, endPointOfDiagonal);
        }

        public void writeCircleParametersOnDiagonal(Point center, Point endPointOfDiagonal)
        {
            centerPoint = center;
            endPointOfDiagonalForTransformToCircle = endPointOfDiagonal;
            correctDiagonalForConversionToSquare();
            writeEllipseParametersOnDiagonal(center, endPointOfDiagonalForTransformToCircle);
        }

        public double radius
        {
            get
            {
                return radiusOfCircle;
            }
        }

        private double radiusOfCircle;
        private Point centerPoint;
        private Point endPointOfDiagonalForTransformToCircle;

        private void correctDiagonalForConversionToSquare()
        {
            radiusOfCircle = Math.Sqrt(Math.Pow(endPointOfDiagonalForTransformToCircle.x - centerPoint.x, 2) +
                                       Math.Pow(endPointOfDiagonalForTransformToCircle.y - centerPoint.y, 2));
            endPointOfDiagonalForTransformToCircle.x = centerPoint.x + (int)radiusOfCircle;
            endPointOfDiagonalForTransformToCircle.y = centerPoint.y + (int)radiusOfCircle;
        }
    }
}
