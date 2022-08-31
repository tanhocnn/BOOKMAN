namespace BookMan.ConsoleApp.Models
{
    /// <summary>
    /// Lop mo ta sach dien tu
    /// </summary>
    class Book
    {
        private int _id = 1;
        /// <summary>
        /// so dinh danh duy nhat cho moi object
        /// </summary>
        /// <value></value>
        public int Id
        { 
            get => _id; 
            set { if (value >= 1) _id = value; }
        }
        private string _authors = "Unknow author";
        /// <summary>
        /// ten tac gia hoac nhom tac gia, khong nhan xau rong
        /// </summary>
        /// <value></value>
        public string Authors
        {
            get { return _authors; }
            set { if (!string.IsNullOrEmpty(value)) _authors = value; }
        }
        private string _title = "A new book";
        /// <summary>
        /// tieu de sach, khong nhan xau rong
        /// </summary>
        /// <value></value>
        public string Title
        {
            get { return _title; }
            set { if (!string.IsNullOrEmpty(value)) _title = value; }
        }
        private string _publisher = "Unknown publisher";
        /// <summary>
        /// Nha xuat ban, khong nhan xau rong
        /// </summary>
        /// <value></value>
        public string Publisher
        {
            get { return _publisher; }
            set { if (!string.IsNullOrEmpty(value)) _publisher = value; }
        }
        private int _year = 2018;
        /// <summary>
        /// nam san xuat, khong nho hon 1950
        /// </summary>
        /// <value></value>
        public int Year
        {
            get { return _year; }
            set { if (value>=1950) _year = value; }
        }
        private int _edition = 1;
        /// <summary>
        /// Lan tai ban, khong nho hon 1
        /// </summary>
        /// <value></value>
        public int Edition
        {
            get { return _edition; }
            set { if (value >= 1) _edition =value; }
        }
        /// <summary>
        /// ma so quoc te
        /// </summary>
        /// <value></value>
        public string Isbn { get; set; } = "";
        /// <summary>
        /// tu khoa mo ta noi dung / the loai
        /// </summary>
        /// <value></value>
        public string Tags { get; set; } = "";
        /// <summary>
        /// mo ta tom tat noi dung
        /// </summary>
        /// <value></value>
        public string Description { get; set; } = "A new book";
        private int _rating = 1;
        /// <summary>
        /// danh gia ca nhan, gia tri tu 1 den 5
        /// </summary>
        /// <value></value>
        public int Rating
        {
            get { return _rating; }
            set { if (value>=1 && value<=5) _rating =value; }
        }
        /// <summary>
        /// danh dau la dang doc
        /// </summary>
        /// <value></value>
        public bool Reading { get; set; }
        private string _file = "";
        /// <summary>
        /// file sach (gom duong dan)
        /// </summary>
        /// <value></value>
        public string File
        {
            get { return _file; }
            set { if (System.IO.File.Exists(value)) _file =value; }
        }
        /// <summary>
        /// file sach (khong co duong dan)
        /// </summary>
        /// <value></value>
        public string FileName
        {
            get { return System.IO.Path.GetFileName(_file); }
        }
    }
}