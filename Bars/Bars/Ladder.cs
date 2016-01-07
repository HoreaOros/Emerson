namespace Bars
{
    internal class Ladder
    {
        Frame f1;
        VertBar v;
        Frame f2;

        public Ladder(int v1, int v2)
        {
            f1 = new Frame(v1, v2);
            v = new VertBar(v2);
            f2 = new Frame(v1, v2);
        }
    }
}