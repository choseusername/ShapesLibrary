namespace ShapesLibrary
{
    public interface ICanvas
    {
        void DrawLine(Point from, Point to);
        void DrawRect(Point p1, Point p2);
        void DrawCircle(Point position, double radius);
    }
}
