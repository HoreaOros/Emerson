namespace Bars
{
    internal class VertBar
    {
        private readonly int v;

        public VertBar(int v)
        {
            this.v = v;
            for (int i = 0; i < v; i++)
            {
                System.Console.WriteLine("|");
            }
        }

        public int Height
        {
            get
            {
                return v;
            }
        }
    }
}