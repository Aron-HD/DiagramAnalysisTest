namespace DiagramAnalysisTest.Shapes
{
    public abstract class Shape
    {
        private float height;
        private float width;

        public virtual float Height
        {
            get => height;
            set => height = value;
        }
        public virtual float Width
        {
            get => width;
            set => width = value;
        }

        public virtual float Area => height * width;
    }
}