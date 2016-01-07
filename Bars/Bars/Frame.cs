namespace Bars
{
    internal class Frame
    {
        HorzBar h1;
        VertBar v;
        HorzBar h2;

        public int Width
        {
            get
            {
                return h1.Width;
            }
        }

        public int Height
        {
            get
            {
                return v.Height;
            }
        }

        public Frame(int v1, int v2)
        {
            h1 = new HorzBar(v1);
            v = new VertBar(v2);
            h2 = new HorzBar(v1);
        }
    }
}