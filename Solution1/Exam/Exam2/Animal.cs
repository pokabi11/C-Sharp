namespace Solution1.Exam.Exam2;

internal class Animal
{
    private string name;
    private double weight;
    public string Name
    {
        get => this.Name;
        set => this.Name = value;
    }

    public double Weight
    {
        get => this.Weight;
        set => this.Weight = value;
    }

    public virtual void Show()
    {
        Console.WriteLine(
            "Name:" + Name + "\n" +
            "Weight:" + Weight + "\n"
            );
    }

    public virtual void SetMe(double weight, string name)
    {
        Weight = weight;
        Name = name;
    }
}