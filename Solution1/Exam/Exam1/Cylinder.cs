namespace Solution1.Exam;

public class Cylinder
{
    public double Radius { get; set; }
    public double Height { get; set; }
    private double BaseArea { get; set; }
    private double LateralArea { get; set; }
    private double TotalArea { get; set; }
    private double Volume { get; set; }

    public Cylinder(double radius, double height)
    {
        Radius = radius;
        Height = height;
    }

    public void Process()
    {
        BaseArea = Radius * Radius * Math.PI;
        LateralArea = 2 * Math.PI * Radius * Height;
        TotalArea = 2 * Math.PI * Radius * (Height + Radius);
        Volume = Math.PI * Radius * Radius * Height;
    }

    public void Result()
    {
        Console.WriteLine(
            "Radius: " + Radius +"\n"+
            "Height: " + Height +"\n"+
            "Base: " + BaseArea +"\n"+
            "Lateral: " + LateralArea +"\n"+
            "Total: " + TotalArea +"\n"+
            "Volume: " + Volume +"\n"
            
            );
    }
}