namespace Solution1.session1;

public class Fraction
{
    private int ts, ms;

    public Fraction()
    {
    }

    public Fraction(int ts, int ms)
    {this.ts = ts; this.ms = ms;}
    
    public int getTs()
    {
        return ts;
    }
    public void setTs(int ts)
    {this.ts = ts;}
    
    public int getMs()
    {
        return ms;
    }
    public void setMs(int ms)
    {this.ms = ms;}

    public void printFraction()
    {
        Console.WriteLine(getMs() + "/" + getTs());
    }

    public void rutgonFraction()
    {
        int ucln = 1;
        for (int i = getMs(); i > 1; i--)
        {
            if (ts % i == 0 && ms % i == 0)
            {
                ucln=1;
                break;
            }
        }
        setTs(ts/ucln);
        setMs(ms/ucln);
    }

    public void nghichdaoFraction()
    {
        int tmp = getTs();
        if (tmp != 0)
        {
            setTs(ms);
            setMs(tmp);
        }
    }
    public Fraction add(Fraction f){
        Fraction t = new Fraction();
        t.setMs(this.getMs()*f.getMs());
        t.setTs(this.getTs()*f.getMs() + this.getMs()*f.getTs());
        t.rutgonFraction();
        return t;
    }
    public Fraction sub(Fraction f){
        Fraction t = new Fraction();
        t.setMs(this.getMs()*f.getMs());
        t.setTs(this.getTs()*f.getMs() - this.getMs()*f.getTs());
        t.rutgonFraction();
        return t;
    }
    public Fraction mul(Fraction f){

        return new Fraction(this.getTs()*f.getTs(),this.getMs()*f.getMs());
    }

    public Fraction div(Fraction f){
        f.nghichdaoFraction();
        return this.mul(f);
    }
}