using FrameWork;
namespace BookMan.ConsoleApp.Views
{
    using Models;
    class BookUpdateView
    {
        protected Book Model;
        public BookUpdateView(Book model)
        {
            Model = model;
        }
        public void Render()
        {
            ViewHelp.WriteLine("UPDATE BOOK INFORMATION", ConsoleColor.Green); //sử dụng phương thức static
            ConsoleColor labelColor = ConsoleColor.Magenta, valueColor = ConsoleColor.White;
            // hiển thị giá trị cũ           
            ViewHelp.Write("Authors: ", labelColor); //sử dụng phương thức static
            ViewHelp.WriteLine(Model.Authors, valueColor); //sử dụng phương thức static
            // yêu cầu nhập giá trị mới            
            ViewHelp.Write("New value: ", labelColor); //sử dụng phương thức static
            // đọc giá trị mới 
            var str = Console.ReadLine();
            /* nếu người dùng ấn enter luôn (bỏ qua nhập dữ liệu) thì lấy lại giá trị cũ
             * của trường Authors gán cho biến cục bộ authors.
             * Nếu người dùng nhập giá trị mới thì biến cục bộ authors nhận giá trị này.
             * Giá trị của biến authors về sau sẽ chuyển về controller để xử lý.
             */
            var authors = string.IsNullOrEmpty(str.Trim()) ? Model.Authors : str;
            // TẠM DỪNG .... VẪN CÒN NHIỀU CODE LẶP
        }
        private void WriteLine(string message, ConsoleColor color = ConsoleColor.White, bool resetColor = true)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            if (resetColor)
                Console.ResetColor();
        }
        private void Write(string message, ConsoleColor color = ConsoleColor.White, bool resetColor = true)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            if (resetColor)
                Console.ResetColor();
        }
    }
}