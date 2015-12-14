using System;
using System.Text;

struct DC
{
    private ushort zi, luna, an;

    public DC(string v) 
    {

        this.zi = this.luna = this.an = 0;

        char[] seps = new char[] {'.', '-'};

        try
        {
            string[] tokens = v.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length == 3)
            {
                zi = ushort.Parse(tokens[0]);
                luna = ushort.Parse(tokens[1]);
                an = ushort.Parse(tokens[2]);
            }
            else if (tokens.Length == 2)
            {
                zi = ushort.Parse(tokens[0]);
                luna = ushort.Parse(tokens[1]);
                an = (ushort)DateTime.Now.Year;
            }
            else if (tokens.Length == 1)
            {
                zi = ushort.Parse(tokens[0]);
                luna = (ushort)DateTime.Now.Month;
                an = (ushort)DateTime.Now.Year;
            }
            else if(tokens.Length == 0)
            {
                DateTime azi = DateTime.Now;
                zi = (ushort)azi.Day;
                luna = (ushort)azi.Month;
                an = (ushort)azi.Year;
            }
            
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public DC(ushort zi, ushort luna, ushort an)
    {
        this.zi = zi;
        this.luna = luna;
        this.an = an;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();


        // return zi.ToString() + "-" + luna.ToString() + "-" + an.ToString();

        // return string.Format("{0}-{1}-{2}", zi, luna, an);


        sb.Append(zi);
        sb.Append("-");
        sb.Append(luna);
        sb.Append("-");
        sb.Append(an);

        return sb.ToString();

    }

    public static int DiferentaZile(DC d1, DC d2)
    {
        DC aux;
        if (d1.GreaterThan(d2))
        {
            aux = d1;
            d1 = d2;
            d2 = aux;
        }

        int contor = 0;
        while (!d1.Egal(d2))
        {
            d2.ScadOZi();
            contor++;
        }
        return contor;
    }

    private void ScadOZi()
    {
        if (zi > 1)
            zi--;
        else
        {
            switch (luna)
            {
                case 1:
                    zi = 31;
                    luna = 12;
                    an--;
                    break;
                case 2: case 4: case 6: case 8: case 9: case 11:
                    zi = 31;
                    luna--;
                    break;
                case 5: case 7: case 10: case 12:
                    zi = 30;
                    luna--;
                    break;
                case 3:
                    if ((an % 4 == 0 && an % 100 != 0) || (an % 400 == 0))
                        zi = 29;
                    else
                        zi = 28;
                    luna--;
                    break;
            }
        }
    }

    private bool Egal(DC d2)
    {
        if ((zi == d2.zi) && (luna == d2.luna) && (an == d2.an))
            return true;
        else
            return false;
    }

    private bool GreaterThan(DC d2)
    {
        if (an > d2.an)
            return true;
        else if (an < d2.an)
            return false;
        else if (luna > d2.luna)
            return true;
        else if (luna < d2.luna)
            return false;
        else if (zi > d2.zi)
            return true;
        else
            return false;
    }
}