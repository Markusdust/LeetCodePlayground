using DisjointSet;


namespace leetCodePlayground
{
    internal class Programm
    {
        static void Main(string[] args)
        {

            var test = new DisjointSetObj();


            test.Union(0, 1);
            test.Union(0, 2);
            test.Union(1, 3);

            

            Console.WriteLine(""+test.FindRoot(3));

            Console.ReadKey();



        }
    }
}
