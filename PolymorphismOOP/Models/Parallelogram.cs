﻿namespace PolymorphismOOP.Models;

public class Parallelogram : Rectangle
{
    public override string Name => "Parallelogram";

    /*
     * Constructor with default values that performs a base call to its parent class and passes the local doubles to
     * its constructor. This is done because parallelograms also have two unique lengths, just like rectangles.
     */
    public Parallelogram(double width = 10, double height = 5) :base(width, height)
    {
    }
}