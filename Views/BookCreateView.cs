namespace BookMan.ConsoleApp.Views
{
    /// <summary>
    /// class de them mot cuon sach moi
    /// </summary>
    internal class BookCreateView
    {
        public BookCreateView()
        {
        }
        /// <summary>
        /// yeu cau nguoi dung nhap tung thong tin va luu lai thong tin do
        /// </summary>
        public void Render()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CREATE A NEW BOOK");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Title: ");
            Console.ResetColor();
            string title = Console.ReadLine(); // doc 1 dong va luu vao bien title
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Authors: ");
            Console.ResetColor();
            string authors = Console.ReadLine(); /// doc 1 dong va luu vao bien authors
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Publisher: ");
            Console.ResetColor();
            string publisher = Console.ReadLine(); // doc 1 dong va luu vao bien publisher
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Year: ");
            Console.ResetColor();
            string yearString = Console.ReadLine(); // doc 1 dong va luu vao bien yearString
            int year = int.Parse(yearString); // chuyen chuoi sangg so nguyen
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Edition: ");
            Console.ResetColor();
            string editionString = Console.ReadLine(); // doc 1 dong va luu vao bien edition
            int edition = int.Parse(editionString);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Reading [y/n]: ");
            Console.ResetColor();
            ConsoleKeyInfo readingChar = Console.ReadKey(); // doc 1 ky tu va luu vao bien readingChar
            bool reading = readingChar.KeyChar == 'y' || readingChar.KeyChar == 'Y' ?
                true:false; // chuyen sang kieu bool dung bieu thuc dieu kien
            Console.WriteLine();
            // TODO: tam dung o day, se quay lai
        }
    }
}