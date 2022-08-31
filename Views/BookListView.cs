using Framework;
namespace BookMan.ConsoleApp.Views
{
    using Models;
    internal class BookListView
    {
        protected Book[] Model; // mang cua cac object kieu Book
        public  BookListView(Book[] model)
        {
            Model = model;
        }
        public void Render()
        {
            if (Model.Length == 0)
            {
                ViewHelp.WriteLine("No book found!", ConsoleColor.Yellow);
                return;
            }
            ViewHelp.WriteLine("THE BOOK LIST", ConsoleColor.Green);
            int i = 0;
            while (i < Model.Length)
            {
                ViewHelp.Write($"[{Model[i].Id}]", ConsoleColor.Yellow);
                ViewHelp.WriteLine($" {Model[i].Title}", Model[i].Reading ? ConsoleColor.Cyan : ConsoleColor.White);
                i++;
            }
        }
    }
}