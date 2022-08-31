namespace BookMan.ConsoleApp.Views
{
    using Models; // chu y cach dung using ben trong namepace
    internal class BookSingleView
    {
        protected Book Model; // bien nay de luuu tru thong tin cuon sach dang can hien thi
        /// <summary>
        /// day la ham tao, se duoc goi dau tien khi tao object
        /// </summary>
        /// <param name="model">mot cuon sach cu the se duoc hien thi</param>
        public BookSingleView(Book model)
        {
            Model = model; // chuyen du lieu tu tham so sang bien thanh vien de su dung trong toan class
        }
        /// <summary>
        /// thuc hien in thong tin ra man hinh console
        /// </summary>
        public void Render()
        {
            if (Model == null) // kiem tra xem object co du lieu khong
            {
                // Console.ForegroundColor = ConsoleColor.Red; // doi mau chu sang do
                // Console.WriteLine("NO BOOK FOUND. SORRY!"); // in ra dong thong bao
                // Console.ResetColor(); // tra lai mau chu mac dinh
                WriteLine("NO BOOK FOUND. SORRY!", ConsoleColor.Red);
                return; // ket thuc thuc hien phuong thuc (bo qua phan con lai)
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BOOK DETAIL INFORMATION");
            Console.ResetColor();
            /* Cac dong duoi day viet ra thong tin cu the theo tung dong
             * su dung cach tao xau kieu "interpolation"
             * va dung dau cach de can chinh tao tham my
             */
            Console.WriteLine($"Authors:        {Model.Authors}");
            Console.WriteLine($"Title:          {Model.Title}");
            Console.WriteLine($"Publisher:      {Model.Publisher}");
            Console.WriteLine($"Year:           {Model.Year}");
            Console.WriteLine($"Edition:        {Model.Edition}");
            Console.WriteLine($"Isbn:           {Model.Isbn}");
            Console.WriteLine($"Tags:           {Model.Tags}");
            Console.WriteLine($"Desciption:     {Model.Description}");
            Console.WriteLine($"Rating:         {Model.Rating}");
            Console.WriteLine($"Reading:        {Model.Reading}");
            Console.WriteLine($"File:           {Model.File}");
            Console.WriteLine($"FileName:       {Model.FileName}");
        }
        /// <summary>
        /// in thong bao ra man hinh console voi chu mau
        /// </summary>
        /// <param name="message">thong bao</param>
        /// <param name="color">mau</param>
        protected void WriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}