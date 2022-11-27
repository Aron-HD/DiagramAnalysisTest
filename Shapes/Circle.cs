using System;

namespace DiagramAnalysisTest.Shapes
{
    public class Circle : Shape
    {
        private float radius;

        public virtual float Radius
        {
            get => radius;
            set
            {
                radius = value;
                var val = value * 2;
                base.Width = val;
                base.Height = val;
            }
        }

        public override float Height
        {
            get => base.Height;
            set
            {
                base.Height = value;
                base.Width = value;
                radius = value / 2;
            }
        }

        public override float Width
        {
            get => base.Width;
            set
            {
                base.Height = value;
                base.Width = value;
                radius = value / 2;
            }
        }

        public override float Area => (float)Math.PI * radius * radius;
    }
}
