using LearningInterfaces2.Enums;

namespace LearningInterfaces2.Entities;
public abstract class AbstractShape : IShape
{
    public ShapeColor Color { get; set; }

    public abstract double Area();

}

