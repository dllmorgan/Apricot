namespace ApricotEditor
{
    class Map
    {
        public MapCell[] Cells;
        public int Height { get; }
        public int Width { get; }

        public Map(int Height, int Width)
        {
            this.Height = Height;
            this.Width = Width;
            this.Cells = new MapCell[Height * Width];
        }

    }
}
