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
            WriteLine("CREATE A NEW BOOK", ConsoleColor.Green);
            var title = InputString("Title"); //đọc vào biến title            
            var authors = InputString("Authors"); //đọc vào biến authors            
            var publisher = InputString("Publisher"); //đọc vào biến publisher
            var year = InputInt("Year"); // nhập giá trị cho biến year
            var edition = InputInt("Edition"); // nhập giá trị cho biến edition
            var tags = InputString("Tags");
            var description = InputString("Description");
            var rate = InputInt("Rate");
            var reading = InputBool("Reading");
            var file = InputString("File");
        }
        /// <summary>
        /// xuat thong tin ra console voi mau sac (WriteLine co mau)
        /// </summary>
        /// <param name="message">thong tin can xuat ra</param>
        /// <param name="color">mau chu</param>
        /// <param name="ResetColor">tra lai mau mac dinh hay khong</param>
        private void WriteLine(string message, ConsoleColor color = ConsoleColor.White, bool ResetColor = true)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            if (ResetColor)
                Console.ResetColor();
        }
        /// <summary>
        /// xuat thong tin ra console voi mau sac (Write co mau)
        /// </summary>
        /// <param name="message">thong tin can xuat ra</param>
        /// <param name="color">mau chu</param>
        /// <param name="ResetColor">tra lai mau mac dinh hay khong</param>
        private void Write(string message, ConsoleColor color = ConsoleColor.White, bool ResetColor = true)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            if (ResetColor)
                Console.ResetColor();
        }
        /// <summary>
        /// in ra thong bao va tiep nhan chuoi ky tu nguoi dung nhap roi chuyen sang kieu bool
        /// </summary>
        /// <param name="label">dong thong bao</param>
        /// <param name="labelColor">mau chu thong bao</param>
        /// <param name="valueColor">mau chu nguoi dung nhap</param>
        /// <returns></returns>
        private bool InputBool(string label, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.White)
        {
            Write($"{label} [y/n]: ", labelColor);
            ConsoleKeyInfo key = Console.ReadKey(); // doc 1 ky tu vao bien key
            Console.WriteLine();
            bool @char = key.KeyChar == 'y' || key.KeyChar == 'Y' ?
                true : false; // chuyen sang kieu bool dung bieu thuc dieu kien
            return @char; // luu y cach viet ten bien @char - them @ vao truoc ten bien ma ten bien nay trung voi cac keyword cua ngon ngu c#
        }
        /// <summary>
        /// in ra thong bao va tiep nhan chuoi ky tu nguoi dung nhap roi chuyen sang so nguyen
        /// </summary>
        /// <param name="label">dong thong bao</param>
        /// <param name="labelColor">mau chu thong bao</param>
        /// <param name="valueColor">mau chu nguoi dung nhap</param>
        /// <returns></returns>
        private int InputInt(string label, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.White)
        {
            while (true)
            {
                var str = InputString(label, labelColor, valueColor);
                var result = int.TryParse(str, out int i);
                if (result == true)
                {
                    return i;
                }
            }
        }

        /// <summary>
        /// in ra thong bao va tiep nhan chuoi ky tu nguoi dung nhap
        /// </summary>
        /// <param name="label">dong thong bao</param>
        /// <param name="labelColor">mau chu thong bao</param>
        /// <param name="valueColor">mau chu nguoi dung nhap</param>
        /// <returns></returns>
        private string InputString(string label, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.White)
        {
            Write($"{label}: ", labelColor, false);
            Console.ForegroundColor = valueColor;
            string value = Console.ReadLine();
            Console.ResetColor();
            return value;
        }
    }
}