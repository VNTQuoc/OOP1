using System;
namespace BT
{
    class toado
    {
        int x, y;
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        
        public void output()
        {
            Console.WriteLine("{0}({1},{2})", this.name, this.x, this.y);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            toado p = new toado();
            Console.WriteLine("Please type the Name: ");
            p.Name = Console.ReadLine();
            Console.WriteLine("Please type the number for x: ");
            p.X = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type the number for y: ");
            p.Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Result: ");
            p.output();

            
        }
    }
    
}
