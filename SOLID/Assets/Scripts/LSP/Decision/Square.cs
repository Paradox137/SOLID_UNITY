namespace Core.LSP.Decision
{
    public class Square : IShape
    {
        public int SideLength { get; set; }

        public int Area()
        {
            return SideLength * SideLength;
        }
    }
}