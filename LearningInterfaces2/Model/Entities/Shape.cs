using LearningInterfaces2.Enums;

namespace LearningInterfaces2.Entities;

//Replaced by AbstractShape
public abstract class Shape
{
    public ShapeColor Color { get; set; }
    public abstract double Area();
}