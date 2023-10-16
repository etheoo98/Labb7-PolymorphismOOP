namespace PolymorphismOOP.Interfaces;

// Interface for geometries.
public interface IGeometry
{
    // Implement the property Name. The return value should be the shape's name.
    public string Name { get; }
    // Implement the property Area. The return value should be the shape's area.
    public double Area { get; }
}