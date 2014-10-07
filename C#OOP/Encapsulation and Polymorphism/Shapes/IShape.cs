using System.Security.Cryptography.X509Certificates;

namespace Shapes
{
    public interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }
}
