namespace ShapesLibrary
{
    public class Rectangle: IFigure
    {
        public Point Position { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public double Area { get => Width * Height; }

        public Rectangle(Point position, double width, double height)
        {
            Position = position;
            Width = width;
            Height = height;
        }

        public void Draw(ICanvas canvas)
        {
            canvas.DrawRect(Position, new Point(Position.X + Width, Position.Y + Height));
        }
    }
}
