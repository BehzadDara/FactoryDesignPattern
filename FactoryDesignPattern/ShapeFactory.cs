namespace FactoryDesignPattern
{
    public class ShapeFactory
    {
        public static IShape CreateShape(string? shapeType)
        {
            if (shapeType is null)
            {
                throw new ArgumentNullException(nameof(shapeType));
            }

            var type = Type.GetType(shapeType);
            if (type is null || !typeof(IShape).IsAssignableFrom(type))
            {
                throw new ArgumentException("Invalid shape type");
            }

            return (IShape)Activator.CreateInstance(type)!;
        }
    }
}
