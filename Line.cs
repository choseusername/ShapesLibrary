namespace ShapesLibrary
{
    public class Line: IFigure
    {
        Point From { get; set; }
        Point To { get; set; }

        public Line(Point from, Point to)
        {
            From = from;
            To = to;
        }

        public void Draw(ICanvas canvas)
        {
            canvas.DrawLine(From, To);
        }
    }
}
