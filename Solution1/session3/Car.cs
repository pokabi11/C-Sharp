namespace Solution1.session3;

public class Car
{
    public List<string> machines = new List<string>();
    public Car()
    {
        machines.Add("Camera hanh trinh");
        machines.Add("Loa");
    }

    public string Brand
    {
        get;
        set;
    }
    public string Type
    {
        get;
        set;
    }
    public string Price
    {
        get;
        set;
    }

    public string this[int index] //indexer
    {
        get => machines[index];
        set => machines[index] = value;
    }
}

