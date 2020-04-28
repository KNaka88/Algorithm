using System;

namespace Union_find
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Algorithm: 1. QuickFind 2. QuickUnion");
            var option = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Type Number");
            var N = Convert.ToInt32(Console.ReadLine());
            UnionFindBase UnionFind;

            switch(option)
            {
                case 1:
                    UnionFind = new QuickFind(N);
                    break;
                case 2:
                    UnionFind = new QuickUnion(N);
                    break;
                default:
                    UnionFind = new QuickFind(N);
                    break;
            }

            do 
            {
                Console.WriteLine("Type Number for First Value");
                var p = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Type Number for Second Value");
                var q = Convert.ToInt32(Console.ReadLine());
                if (UnionFind.Connected(p, q))
                {
                    continue;
                }

                UnionFind.Union(p, q);
                Console.WriteLine($"{p} {q}");
                Console.WriteLine("If you want to quit, type q");
            }  
            while (Console.ReadLine() != "q");
            Console.WriteLine(UnionFind.Count() + " components");
        }
    }
}
