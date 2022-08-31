namespace BookMan.ConsoleApp.Controllers
{
    using Models; // luu y cach dung using voi khong gian ten con
    using Views;
    /// <summary>
    /// Lop dieu khien, giup ghep noi du lieu sach voi giao dien
    /// </summary>
    class BookController
    {
        /// <summary>
        /// ghep noi du lieu 1 cuon sach voi giao dien hien thi 1 cuon sach
        /// </summary>
        /// <param name="id">ma dinh danh cua cuon sach</param>
        public void Single(int id)
        {
            Book model = new Book()
            {
                Id = 1,
                Authors = "Adam Freeman",
                Title = "Expert asp.net web api 2 for mvc developers",
                Publisher = "Apress",
                Year = 2004,
                Tags = "c#, asp.net, mvc",
                Description = "Expert insight and understanding of how to create, customize, and deploy complex, plexible, and robust httpp web",
                Rating = 5,
                Reading = true
            };
            // khoi tao view
            BookSingleView view = new BookSingleView(model);
            // goi phuong thuc Render de thuc su hien thi ra man hinh
            view.Render();
        }
        public void Create()
        {
            BookCreateView view = new BookCreateView(); // khoi tao object
            view.Render(); // hien thi ra man hinh
        }
    }
}