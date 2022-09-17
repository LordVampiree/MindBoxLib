namespace MindBoxLib
{
    public class Triangle : IFigure
    {
        private readonly double _edgeA, _edgeB, _edgeC;

        public Triangle(double a, double b, double c)
        {
            _edgeA = a;
            _edgeB = b;
            _edgeC = c;
            
            if (!IsValid())
                throw new Exception("Такого треугольника не существует, проверьте значения сторон");
        }

        public double GetSquare()
        {
            double p = (_edgeA + _edgeB + _edgeC) / 2d;
            double square = Math.Sqrt(p * (p - _edgeA) * (p - _edgeB) * (p - _edgeC));

            return Math.Round(square, 2);
        }

        public bool IsValid()
        {
            if(_edgeA <= 0d || _edgeB <= 0d || _edgeC <= 0d)
                return false;
            else if(_edgeA >= (_edgeB + _edgeC) || _edgeB >= (_edgeA + _edgeC) || _edgeC >= (_edgeA + _edgeB))
                return false;

            return true;
        }

        public bool IsRight()
        {
            List<double> edges = new() { _edgeA, _edgeB, _edgeC };
            double maxEdge = edges.Max();
            double catetsSquaredSum = 0d;

            edges.Remove(maxEdge);

            foreach (double edge in edges)
                catetsSquaredSum += edge * edge;

            return catetsSquaredSum == maxEdge * maxEdge;
        }
    }
}
