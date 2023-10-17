using PolymorphismOOP.Interfaces;

namespace PolymorphismOOP.Models;

public class Square : IGeometry
{ 
    public virtual string Name => "Square";
    public virtual double Area => Math.Pow(Side, 2);
    /*
     * We check the value of side sent to the constructor, to ensure that it is a positive value, since sides aren't
     * expected to be zero or negative, before we assign the value to the _side field. If it is not a positive value an
     * exception is thrown.
     */
    public double Side
    {
        get => _side;
        set
        {
            if (value <= 0)
                throw new Exception("Attempted to assign non-positive value to _side");
            _side = value;
        }
    }
    
    public Square(double side = 6)
    {
        Side = side;
    }
    
    private double _side;
}