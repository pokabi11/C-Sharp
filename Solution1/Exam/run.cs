using Solution1.Exam;
using Solution1.Exam.Exam2;

namespace Solution1;

internal class run
{
    static void Main1(string[] args)
    {
        Cylinder cl = new Cylinder(26.56, 14.33);
        cl.Process();
        cl.Result();
    }

    static void Main(string[] args)
    {
        Lion l1 = new Lion(200.3, "LionKing");
        Tiger t1 = new Tiger(150.7, "SmolTiger");
        l1.Show();
        t1.Show();
    }
}