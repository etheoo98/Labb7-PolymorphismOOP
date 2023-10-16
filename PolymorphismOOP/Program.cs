/*
 * Author: Theodor Hägg (.NET23)
 * Website: https://www.github.com/etheoo98/PolymorphismOOP
 * Date: October 16, 2023
 */

using PolymorphismOOP.Interfaces;
using PolymorphismOOP.Models;

namespace PolymorphismOOP;

internal static class Program
{
    public static void Main()
    {
        // Create an array of IGeometry objects.
        IGeometry[] geometries = {
            new Circle(),
            new Cube(),
            new Ellipse(),
            new Parallelogram(),
            new Rectangle(),
            new Rhombus(),
            new Sphere(),
            new Square(),
            new Triangle(),
        };
        
        // Iterate over each element in the array and output the return values of Name and Area.
        foreach (var geometry in geometries)
        {
            Console.WriteLine($"{geometry.Name} area: {Math.Round(geometry.Area, 2)}");
        }
    }
}