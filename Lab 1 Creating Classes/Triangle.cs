using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesD.Shapes
{
    internal class Triangle
    {
        public const int NUMBER_OF_EDGES = 3;

        private double angle1; //Double is decimal, alternative is float. Int is whole number
        private double angle2;
        private double angle3;

        private double @base; //Has @ because base is a reserved word
        private double height; //Private meaning access is only possible in this file/class

        private string color;

        public double Angle1
        {
            get // When "Angle1" property called, it will GET below
            {
                return this.angle1; //"this" because we are talking about this object. Talking about this instance
            }
            set // After getting the desired, it will SET the below. Also possible to stop it from being set a certain value. 
            {
                if (value > 0 && value < 180) // If statement that ensures the value from Progam.CS is greater than 0 AND less than 180
                {
                    this.angle1 = value;
                }
            }
        }

        public double Angle2
        {
            get
            {
                return this.angle2;
            }
            set
            {
                if (value > 0 && value < 180)
                {
                    this.angle2 = value;
                }
            }
        }

        public double Angle3
        {
            get
            {
                return this.angle3;
            }
            set
            {
                if (value > 0 && value < 180)
                {
                    this.angle3 = value;
                }
            }
        }

        public double Base
        {
            get
            {
                return this.@base;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
        }

        /// <summary>
        /// Checks that the angles add up to 180
        /// </summary>
        public bool IsAnglesValid
        {
            get
            {
                double sum;

                sum = this.angle1 + this.angle2 + this.angle3;

                /*bool isValid;

                if (sum == 180)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }

                return isValid;*/

                return sum == 180 ? true : false;
            }
        }

    public double Area
        {
            get
            {
                double area;

                area = this.Base * this.Height / 2;
                return area;
            }
        }

//property is a mix of a method and field

/// <summary>
/// Represents a triangle
/// </summary>
/// <param name="angle1"></param>
/// <param name="angle2"></param>
/// <param name="angle3"></param>
/// <param name="baseLength"></param>
/// <param name="height"></param>
/// <param name="color"></param>
public Triangle(double angle1, double angle2, double angle3, double baseLength, double height, string color)
        {
            this.angle1 = angle1;
            this.angle2 = angle2;
            this.angle3 = angle3;
            @base = baseLength;
            this.height = height;
            this.color = color;
        }
    }
}
