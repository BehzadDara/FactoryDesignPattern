namespace FactoryDesignPattern
{
    public class Square : IShape
    {
        public void Move()
            => Console.WriteLine("square moved");
    }
}
