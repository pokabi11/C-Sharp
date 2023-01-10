using Solution1.session1;
using Solution1.session2;
using System.Collections.Generic;
using Solution1.session3;
public class Program
{
    public static void Main(string[] args)
    {
        PrintString ps = new PrintString(ShowDanger);
        
        ps+= DemoDelegate.Alert();
        ps+= new DemoDelegate().ShowMessage;
        ps("Nguy hiem lam xd");
    }
    ps += (s) =>{
        Console.WriteLine("Giau ten: " + s);
        }
        ps+= delegate (string s){
            Console.WriteLine("Giau ten: " + s);
        };
        
    public static void ShowDanger()
    {
        Console.WriteLine("Danger: " + mg);
    }

    public static void Main3(string[] args)
    {
        Car c = new Car(){Brand = "BMW",Type = "i8"};
        Console.WriteLine(c.machines[0]);
        Console.WriteLine(c[1]);
        // Console.WriteLine(c[2]);
        // c[2] = "x9"; khi chạy sẽ báo lỗi
        c.machines.Add("Led");
        try
        {
            int x = 10;
            int y = 0;
            if (y == 0)
            {
                throw new Exception("Error, y = 0");
            }
            Console.WriteLine("x / y = ");
            int z = x / y;
            Console.WriteLine(z);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public static void Main3(string[] args)
    {
        //Dog d = new Dog();
        //d.SetKind("DOG");
        //d.Info();
        Dog d = new Dog("Dog", 12);
        d.Weight = 10;
        d.Color = "yellow";
        Console.WriteLine(d.Weight);
        Console.WriteLine(d.Color);
        Dog[] dd = new Dog[10];

        for(int i = 0; i < dd.Length; i++)
        {
            dd[i] = new Dog();
        }
        // dd[0].Weight = 20;

        foreach(Dog o in dd)
        {
            o.Color = "green";
        }

        List<Dog> ls = new List<Dog>();
        ls.Add(new Dog());
        Console.WriteLine(ls.Count);// .Count -> kich thuoc tap hop
        List<int> ints = new List<int>();

    }

    public static void Main2(string[] args)
    {
        
        double y = 3.14;
        
        string s = "T2204M";

        int x = 10;
        if (x >= 10)
        {
            Console.WriteLine("A");
        }else if (x > 5)
        {
            Console.WriteLine("B");
        }else if (x > 15)
        {
            Console.WriteLine("C");
        }
        else
        {
            Console.WriteLine("D");
        }

        int[] ns = new int[3];

        ns[0] = 15;
        ns[1] = 20;
        ns[2] = 25;

        foreach(int n in ns)
        {
            //n
        }

        for(int i = 0; i < ns.Length; i++)
        {
            // ns[i]
        }

        string input = Console.ReadLine(); // scan
        int num = Convert.ToInt32(input);
        Console.WriteLine("num = " + num);

        Human h = new Human();
        h.name = "Nguyen Van An";
        h.Run();
    }
}

namespace Solution1.session3
{
    
}