using LearningInterfaces2.Entities;
using LearningInterfaces2.Enums;

IShape s1 = new Circle(){Radius = 2.0, Color = ShapeColor.White };
IShape s2 = new Rectangle() {Width = 3.5, Height = 4.2,  Color = ShapeColor.Black };
Console.WriteLine(s1);
Console.WriteLine(s2);