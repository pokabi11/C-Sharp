namespace Solution1.Exam;

public class Cylinder
{
    public double Radius { get; set; }
    public double Height { get; set; }
    private double BaseArea { get; set; }
    private double LateralArea { get; set; }
    private double TotalArea { get; set; }
    private double Volume { get; set; }

    public void Process()
    {
        BaseArea = Radius * Radius * Math.PI;
        LateralArea = 2 * Math.PI * Radius * Height;
        TotalArea = 2 * Math.PI * Radius * (Height + Radius);
        Volume
    }
}