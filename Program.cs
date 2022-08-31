namespace BookMan.ConsoleApp
{
    using Controllers;
    internal class Program
    {
        private static void Main(string[] args)
        {
            BookController controler = new BookController();
            controler.Single(0);
            Console.ReadKey();
        }
    }
}