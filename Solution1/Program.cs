using Solution1.session1;

public class Program

{
public static void Main(string[] args)
    {
        int x = 10;
        double y = 3.14;
        Console.WriteLine("Hello xd " + x);
        int[] ns = { 1, 3, 5, 6, 7 };
        foreach (int i in ns) { Console.WriteLine(i); }
        for(int i = 0; i < ns.Length; i++) { Console.WriteLine(i); }
        
        string input = Console.ReadLine(); //scan
        int num = Convert.ToInt32(input);
        Console.WriteLine("num = " + num );

        Human h = new Human();
        h.name = "aaaaaaaaaaaaaaaaaaaaaaa";
        
    }

}