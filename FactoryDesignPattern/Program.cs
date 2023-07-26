using FactoryDesignPattern;

var square = ShapeFactory.CreateShape(typeof(Square).FullName);
var circle = ShapeFactory.CreateShape(typeof(Circle).FullName);

square.Move();
circle.Move();