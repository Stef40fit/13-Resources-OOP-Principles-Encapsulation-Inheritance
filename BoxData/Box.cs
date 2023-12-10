﻿using System;
using System.Text;

namespace BoxData;

public class Box
{
//c – double, should not be zero or negative number.
//Width – double, should not be zero or negative number.
//Height – double, should not be zero or negative number.
//If one of the properties IS a zero or negative number throw an ArgumentException with the message: 
//"{propertyName} cannot be zero or negative." 

    private double _length;
    private double _width;
    private double _height;
    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }
   
    public double Length
    {
        get { return this._length; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Length cannot be zero or negative.");
            }
            this._length = value;
        }
    }
    public double Width
    {
        get { return this._width; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Width cannot be zero or negative.");
            }
            this._width = value;
        }
    }
    public double Height
    {
        get { return this._height; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Height cannot be zero or negative.");
            }
            this._height = value;
        }
    }

    public double SurfaceArea()
    {
        //(2*L*W + 2*L*H + 2*W*H)
        return 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;
    }
//  
    public double Volume()
    {
        return this.Length * this.Width * this.Height;
    }
    public override string ToString()
    {
        return $"Surface Area – {this.SurfaceArea():f2}{Environment.NewLine}Volume – {this.Volume():f2}";
    }

}
