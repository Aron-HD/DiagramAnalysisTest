namespace DiagramAnalysisTest.Shapes
{
    public class Square : Shape
    {
        public override float Height
        {
            get => base.Height; 
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
        public override float Width
        {
            get => base.Width;
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
    }
}
