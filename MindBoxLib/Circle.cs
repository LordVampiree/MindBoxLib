namespace MindBoxLib
{
    public class Circle : IFigure
    {
        private readonly double _radius;
        
        public Circle(double radius)
        {
            _radius = radius;
            
            if (!IsValid())
                throw new Exception("Такого круга не существует, неккоректный радиус");
        }
        
        public double GetSquare() => Math.Round(_radius * _radius * Math.PI, 2);

        public bool IsValid() => _radius > 0d;
    }
}
