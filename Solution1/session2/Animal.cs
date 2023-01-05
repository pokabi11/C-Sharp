namespace Solution1.session2
{
    public class Animal : AbstractAnimal
    {
        private string kind;

        public Animal(string kind)
        {
            this.kind = kind;
        }

        public virtual void SetKind(string k)
        {
            kind = k;
        }

        public string GetKind()
        {
            return kind;
        }

        public override void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public override void Run()
        {
            Console.WriteLine("Running...");
        }
    }
}